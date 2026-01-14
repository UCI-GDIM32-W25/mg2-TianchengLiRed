using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BirdController : MonoBehaviour
{
    private float _speed = 7f;
    private int _point;
    private Rigidbody2D rb;
    private bool isGround = false;
    public PointUI pointUI;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        _point = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (isGround)
        {
            if (Input.GetKeyDown(KeyCode.Space))
           {
               rb.AddForce(Vector3.up * _speed, ForceMode2D.Impulse);
               isGround =false;
           }
        }

        pointUI.UpdateText(_point);
        
        
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGround = true;
        }


    }
    void OCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Coin"))
        {
          _point++;
          Debug.Log(""+ _point);
        }
    }

}
