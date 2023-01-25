using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : PlayerController
{
    public static float player_speed = 5;
    public static int player_damage;
    public static int player_heath;
    public static int player_stamina;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetInputs();
        Movement();
    }
}
