using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerInventory : MonoBehaviour
{
    public int maxHealth = 60; 
    public int Health = 60; 

    public bool Chestplate = false;
    public bool Helmet = false;
    public bool Legs = false;
    public int credits = 0;
    public bool energy_lance_lazer = false;
    public bool energy_lance_melee = false;
    public int grenades = 0;
    public bool keycardBlue = false;
    public bool keycardGreen = false;
    public bool keycardRed = false;
    public bool keycardYellow = false;
    public bool lazerRifle = false;
    public bool healthPackSmall = false;
    public bool healthPackLarge = false;


    public healthSlider healthBar;

    public GameObject blueKeyItem;
    public GameObject redKeyItem;
    public GameObject yellowKeyItem;
    public GameObject greenKeyItem;

    public GameObject greadeItem;

    public TextMeshProUGUI grenadeCount;

    private Animator animator;

    public GameObject EnergyLanceHitbox;


   

 
    void Start() {
        Health = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        healthPackSmall = false;
        animator = GetComponent<Animator>();

        EnergyLanceHitbox.SetActive(false);
        animator.SetBool("moving", false);
    }
 

    void Update() {
        

        healthBar.SetHealth(Health); //updates healthbar

        smallHealthPack();
        largeHealthPack();

        blueKey();
        redKey();
        yellowKey();
        greenKey();

        playerDeath();

        grenade();
    }

   


   void smallHealthPack() {
        if (healthPackSmall == true)
        {
            Health = Health + 10;
            healthPackSmall = false;

            if (Health >60) {
                Health = 60; 
            }
        }
        
    }

    void largeHealthPack()
    {
        if (healthPackLarge == true)
        {
            Health = Health + 20;
            healthPackLarge = false;

            if (Health > maxHealth)
            {
                Health = maxHealth;
            }
        }

    }

    void blueKey() {
        if (keycardBlue == true) {

            blueKeyItem.SetActive(true);
        }
    }

    void redKey()
    {
        if (keycardRed == true)
        {

            redKeyItem.SetActive(true);
        }
    }

    void yellowKey()
    {
        if (keycardYellow == true)
        {

            yellowKeyItem.SetActive(true);
        }
    }

    void greenKey()
    {
        if (keycardGreen == true)
        {

            greenKeyItem.SetActive(true);
        }
    }

    void playerDeath() {
        if (Health == 0) {
            Application.LoadLevel("GameOver");
        }
    }

    void grenade() {

        if (grenades >= 1)
        {
            greadeItem.SetActive(true);
        }
        else {
            greadeItem.SetActive(false);
        }

        grenadeCount.text = grenades.ToString();
    }
}

