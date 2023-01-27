using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float horizontalMovement, verticalMovement;
    [SerializeField]Rigidbody2D playerRigidbody2D;

    private void Awake() {
        playerRigidbody2D = GetComponent<Rigidbody2D>();        
    }
    //for mvoement
    protected void Movement(){
        playerRigidbody2D.velocity = new Vector2(horizontalMovement*Player.player_speed,verticalMovement*Player.player_speed);
    }
    //for Getting players inputs
    protected void GetInputs(){
        horizontalMovement = Input.GetAxis("Horizontal");
        verticalMovement = Input.GetAxis("Vertical");
    }
}
