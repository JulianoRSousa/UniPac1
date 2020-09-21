using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddContact : MonoBehaviour
{
    private void OnCollisionEnter(Collision objeto)
    {
        if (objeto.gameObject.CompareTag("Enemy"))
        {
            print("Contato iniciado");
        }
    }
}
