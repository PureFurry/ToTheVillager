using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : PlayerController
{
    public bool playerHandEmpty = true;
    public static float player_speed = 5;

    // Update is called once per frame
    void Update()
    {
        GetInputs();
        Movement();
        if (horizontalMovement < 0 && isFaceRight == true)
        {
            FlipLook();
        }
        else if(horizontalMovement > 0 && isFaceRight == false)
        {
            FlipLook();
        }
        PlayerAnimationControl();
    }
}
