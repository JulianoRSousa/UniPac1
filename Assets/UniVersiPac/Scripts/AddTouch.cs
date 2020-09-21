using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddTouch : MonoBehaviour

{
    private void OnCollisionEnter(Collision objeto)
    {
        if (objeto.gameObject.CompareTag("Enemy"))
        {
            // Destroy(objeto.gameObject);
            print("colisão");
            Time.timeScale = 0;
        }
    }
}
