using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickUpEnergyLanceLazer : MonoBehaviour
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
            print("Xaxor got the EnergyLance(Lazer)");
            Destroy(this.gameObject);

            player.GetComponent<PlayerInventory>().energy_lance_lazer = true;
        }
    }
}
