using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddOne : MonoBehaviour
{
    private int coinVault = 0;

    private void OnTriggerEnter(Collider objeto)
    {
        if (objeto.gameObject.CompareTag("OnePlus"))
        {
            Destroy(objeto.gameObject);
            coinVault = coinVault + 1;
            print(coinVault);
        }
    }

    
}
