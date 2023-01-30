using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desk : Collidable
{
    public static bool canInteract;
    BoxCollider2D deskCollider;
    protected override void OnCollide(Collider2D coll)
    {
        if (canInteract != true)
        {
            canInteract = true;
        }
    }
}
