using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    protected bool isFaceRight = true;
    protected float horizontalMovement, verticalMovement;
    [SerializeField]protected Animator playerAnimator;
    [SerializeField]Rigidbody2D playerRigidbody2D;

    private void Awake() {
        playerRigidbody2D = GetComponent<Rigidbody2D>();
        playerAnimator = GetComponent<Animator>();        
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
    //When player change look. It's code work 
    protected void FlipLook(){    
           Vector2 currentScale = gameObject.transform.localScale;
           currentScale.x *= -1;
           gameObject.transform.localScale = currentScale;
           isFaceRight = !isFaceRight;
    }
    protected void PlayerAnimationControl(){
        playerAnimator.SetFloat("isMovingHorizontal",Mathf.Abs(horizontalMovement));
        playerAnimator.SetFloat("isMovingVertical",Mathf.Abs(verticalMovement));
    }
}