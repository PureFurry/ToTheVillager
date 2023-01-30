using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectGrabbable : MonoBehaviour
{
    public void Grab(Transform objectGrabPointTransform){
        this.gameObject.transform.parent = objectGrabPointTransform;
        this.gameObject.transform.position = objectGrabPointTransform.position;
    }
    public void DropObject(Transform objectDropPointTransform){
        this.gameObject.transform.parent = objectDropPointTransform;
        this.gameObject.transform.position = objectDropPointTransform.position;
    }
}
