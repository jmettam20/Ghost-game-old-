using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menu : MonoBehaviour
{

    public void start() {
        Application.LoadLevel("MainLevel");
    }

    public void options() { 
    
    }

    public void quit() {
        Application.Quit();
    }

   
         public void mainMenu()
    {
        Application.LoadLevel("MainMenu");
    }
    
}
