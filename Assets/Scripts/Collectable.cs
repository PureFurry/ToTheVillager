using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : Collidable
{

    protected Player playerObjectPlayerCode;
    protected GameObject playerHandObject;
    protected bool collacted = false;
    protected override void OnCollide(Collider2D coll)
    {
        if (coll.CompareTag("Player"))
        {
            playerHandObject = coll.gameObject.transform.GetChild(0).gameObject;
            OnCollacted();
            playerObjectPlayerCode = coll.GetComponent<Player>();
        }
    }

    protected virtual void OnCollacted(){
        collacted = true;
    }
}
