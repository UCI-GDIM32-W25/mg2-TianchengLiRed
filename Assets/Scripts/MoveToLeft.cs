using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToLeft : MonoBehaviour
{
    private float _speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveLeft();
    }
    
    private void MoveLeft()
    {
        transform.Translate(Vector3.left * _speed * Time.deltaTime);
    }
    
}
