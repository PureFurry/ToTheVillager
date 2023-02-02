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
        objectDropPointTransform.parent = this.gameObject.transform;
        objectDropPointTransform.position = this.gameObject.transform.position;
    }
}
