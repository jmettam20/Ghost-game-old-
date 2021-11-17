using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightCloseRange : MonoBehaviour
{
   
    int health = 10;


    void update() {
        healthCheck();
    }

    void healthCheck() {
        if (health <= 0)
        {
            
            PlayerLevel.instance.AddXP(10);
            Destroy(this.gameObject); 
        }
    }


}
     



   
    
    
    

