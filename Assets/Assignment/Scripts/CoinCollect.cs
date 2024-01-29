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

        Instantiate(coin, new Vector3((float)3.5, (float)3.23, 0), Quaternion.identity);
        Instantiate(coin, new Vector3((float)4, (float)-5.875, 0), Quaternion.identity);
        Instantiate(coin, new Vector3((float)-2.375, (float)1.8, 0), Quaternion.identity);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
            fence.coinCount++;
            Destroy(gameObject);
            Debug.Log("Coins: " + fence.coinCount);
    }
}
