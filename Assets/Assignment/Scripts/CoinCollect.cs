using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollect : MonoBehaviour
{
    Fence fence;
    public GameObject coin;

    void Start()
    {
        Debug.Log("|FIND 3 COINS TO ESCAPE|");
        fence = FindObjectOfType<Fence>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
            fence.coinCount++;
            Destroy(gameObject);
            Debug.Log("Coins: " + fence.coinCount);
    }
}
