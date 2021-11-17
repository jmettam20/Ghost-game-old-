using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class takeDamage : MonoBehaviour
{
    GameObject player;

    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
     void OnTriggerEnter2D(Collider2D other)
        {

            if (other.gameObject.tag == "Player")
            {
                print("Taken 10 damage from light close range enemy");


                player.GetComponent<PlayerInventory>().Health = player.GetComponent<PlayerInventory>().Health - 10; 
            }
        
    }
}
