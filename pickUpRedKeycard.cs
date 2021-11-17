using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickUpRedKeycard : MonoBehaviour
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
            print("Xaxor got the Red Keycard");
            Destroy(this.gameObject);

            player.GetComponent<PlayerInventory>().keycardRed = true;
        }
    }
}
