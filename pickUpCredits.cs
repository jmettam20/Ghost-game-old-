using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickUpCredits : MonoBehaviour
{
    GameObject player;

    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.tag == "Player")
        {
            print("Xaxor picked up 1 credit");
            Destroy(this.gameObject);

            player.GetComponent<PlayerInventory>().credits = player.GetComponent<PlayerInventory>().credits ++;
        }
    }
}
