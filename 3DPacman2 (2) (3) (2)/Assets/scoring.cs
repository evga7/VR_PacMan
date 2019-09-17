using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoring : MonoBehaviour
{
    coinmanager coinmana;
    // Use this for initialization
    void Start()
    {
        coinmana = GameObject.Find("Coinman").GetComponent<coinmanager>();
        //coin = GameObject.Find("Sphere");
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider c)
    {
        if (c.gameObject.tag == "Player")
        {
            coinmana.AddScore(50);
			Destroy(gameObject);
        }
    }


}
