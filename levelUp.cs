using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelUp : MonoBehaviour
{
    public void ButtonPressed() {
        PlayerLevel.instance.AddXP(10); 
    }
}
