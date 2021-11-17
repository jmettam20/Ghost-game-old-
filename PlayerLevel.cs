using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerLevel : MonoBehaviour
{
    

    public TextMeshProUGUI currentXPtext, targetXPtext;
    public int currentXP, targetXP;

    public static PlayerLevel instance; 

    private void Awake() {
        if (instance == null) 
            instance = this;
            else 
                Destroy(gameObject);
            
        
    }


    public void AddXP(int xp) {
        currentXP += xp;
        currentXPtext.text = currentXP.ToString(); 
    }
    








}

    
