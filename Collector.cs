using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector: MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        other.GetComponent<PlayerCoin>().points++;
        if (other.name == "Player")
        {
            Destroy(gameObject);
        }
    }
}
