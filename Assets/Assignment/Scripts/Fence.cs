using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fence : MonoBehaviour
{
    public GameObject fence;
    public float coinCount = 0;

    void Start()
    {
    
    }

    void Update()
    {


        if(coinCount == 3)
        {
            Debug.Log("YOU HAVE FOUND ALL COINS, EXIT IS NOW OPEN");
            Destroy(fence);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("NEED TO COLLECT 3 COINS TO OPEN!!");
    }
}
