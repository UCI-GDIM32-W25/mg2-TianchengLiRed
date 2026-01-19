using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] private GameObject CoinPrefab;

    // Start is called before the first frame update
    void Start()
    {
        
        StartCoroutine(CoinGenerate());
    }

    // Update is called once per frame
    void Update()
    {
    }

    IEnumerator CoinGenerate()
    {
        
        while (true)
        {
            float x = Random.Range(0.0f,1.0f);
            Instantiate(CoinPrefab, transform.position, transform.rotation);
            yield return new WaitForSeconds(x);

        }
        

    }
}
