using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class sign : MonoBehaviour
{

    public GameObject dialogBox;
    public Text dialogText;
    public string dialog;
    public bool dialogActive;

    Animator anim; 

    void Start() { 
    
    }

    // Update is called once per frame
    void Update()
    {
        anim = GetComponent<Animator>();
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            anim.SetBool("SignOn",true);
            
            dialogActive = true;

            if (dialogBox.activeInHierarchy)
            {
                dialogBox.SetActive(false);
            }
            else {
                dialogBox.SetActive(true);
                dialogText.text = dialog;
            }
        }
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
           anim.SetBool("SignOn", true);
            dialogBox.SetActive(false);
            dialogActive = false;

        }

    }
}
