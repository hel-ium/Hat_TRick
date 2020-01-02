using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collector : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Fruit" || target.tag == "Bomb" || target.tag == "coin" || target.tag == "Life")
        {
            Destroy(target.gameObject);
        }
    }
}
