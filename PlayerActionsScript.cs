using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities; 

public class PlayerActionsScript : MonoBehaviour
{

    [SerializeField]
    private float playerSpeed; 
    private PlayerActions playerActions; 
    private Rigidbody2D playerRb; 
    private Vector2 moveInput; 

    private void Awake() {
        playerActions = new PlayerActions();
        playerRb = GetComponent<Rigidbody2D>();
        if(playerRb is null){
            Debug.LogError("No RB");
        }
    }
    
    private void OnEnable() {
        playerActions.Player_Map.Enable(); 
    }

    private void OnDisable() {
        playerActions.Player_Map.Disable(); 
    }

    private void FixedUpdate() {
        moveInput = playerActions.Player_Map.Movement.ReadValue<Vector2>(); 
        
        playerRb.velocity = moveInput * playerSpeed; 
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
