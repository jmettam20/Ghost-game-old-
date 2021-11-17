using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attackEnemy : MonoBehaviour
{

    GameObject enemy;

    void Awake()
    {
        enemy = GameObject.FindGameObjectWithTag("SandWorm");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.tag == "SandWorm")
        {
           
            enemy.GetComponent<wormScript>().health = enemy.GetComponent<wormScript>().health - 5;

        }
    }
}
