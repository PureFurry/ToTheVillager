using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPickUp : MonoBehaviour
{
    [SerializeField]protected Transform playerRaycastTransform;
    [SerializeField]protected LayerMask objectGrabLayerMask;
    [SerializeField]protected Transform objectGrabPointTransform;
    [SerializeField]protected LayerMask objectDropLayerMask;
    [SerializeField]protected bool isHandEmpty = true;
    private void Update() {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            float pickUpDistance = 2f;
            RaycastHit2D hitForward = Physics2D.Raycast(playerRaycastTransform.position,playerRaycastTransform.forward, pickUpDistance, objectGrabLayerMask);
            RaycastHit2D hitUp = Physics2D.Raycast(playerRaycastTransform.position,playerRaycastTransform.up, pickUpDistance, objectGrabLayerMask);
            RaycastHit2D hitDown = Physics2D.Raycast(playerRaycastTransform.position,playerRaycastTransform.up * -1.0f, pickUpDistance, objectGrabLayerMask);
            RaycastHit2D hitBack = Physics2D.Raycast(playerRaycastTransform.position,playerRaycastTransform.forward * -1.0f, pickUpDistance, objectGrabLayerMask);

            if (hitForward || hitUp || hitDown || hitBack)
            {
                if (hitForward.collider != null && hitForward.collider.tag == "Grabbable" && isHandEmpty == true)
                {
                    hitForward.collider.gameObject.GetComponent<ObjectGrabbable>().Grab(objectGrabPointTransform);
                    isHandEmpty = false;
                }
                else if (hitBack.collider != null && hitBack.collider.tag == "Grabbable" && isHandEmpty == true)
                {
                    hitBack.collider.gameObject.GetComponent<ObjectGrabbable>().Grab(objectGrabPointTransform);
                    isHandEmpty = false;
                }
                else if (hitUp.collider != null && hitUp.collider.tag == "Grabbable" && isHandEmpty == true)
                {
                    hitUp.collider.gameObject.GetComponent<ObjectGrabbable>().Grab(objectGrabPointTransform);
                    isHandEmpty = false;
                }
                else if (hitDown.collider != null && hitDown.collider.tag == "Grabbable" && isHandEmpty == true)
                {
                    hitDown.collider.gameObject.GetComponent<ObjectGrabbable>().Grab(objectGrabPointTransform);
                    isHandEmpty = false;
                }
            }  
        }
        if(Input.GetKeyDown(KeyCode.Space))
        {
            float dropDistance = 2f;
            RaycastHit2D hitForward = Physics2D.Raycast(playerRaycastTransform.position,playerRaycastTransform.forward, dropDistance, objectDropLayerMask);
            RaycastHit2D hitUp = Physics2D.Raycast(playerRaycastTransform.position,playerRaycastTransform.up, dropDistance, objectDropLayerMask);
            RaycastHit2D hitDown = Physics2D.Raycast(playerRaycastTransform.position,playerRaycastTransform.up * -1.0f, dropDistance, objectDropLayerMask);
            RaycastHit2D hitBack = Physics2D.Raycast(playerRaycastTransform.position,playerRaycastTransform.forward * -1.0f, dropDistance, objectDropLayerMask);

            if (hitForward || hitUp || hitDown || hitBack)
            {
                if (hitForward.collider == null && hitForward.collider.tag == "WorldObject" && isHandEmpty == false)
                {
                    hitForward.collider.gameObject.GetComponent<ObjectGrabbable>().DropObject(hitForward.collider.gameObject.transform);
                    isHandEmpty = true;
                }
                else if (hitBack.collider == null && hitBack.collider.tag == "WorldObject" && isHandEmpty == false)
                {
                    hitBack.collider.gameObject.GetComponent<ObjectGrabbable>().DropObject(hitBack.collider.gameObject.transform);
                    isHandEmpty = true;
                }
                else if (hitUp.collider == null && hitUp.collider.tag == "WorldObject" && isHandEmpty == false)
                {
                    hitUp.collider.gameObject.GetComponent<ObjectGrabbable>().DropObject(hitUp.collider.gameObject.transform);
                    isHandEmpty = true;                
                }
                else if (hitDown.collider == null && hitDown.collider.tag == "WorldObject" && isHandEmpty == false)
                {
                    hitDown.collider.gameObject.GetComponent<ObjectGrabbable>().DropObject(hitDown.collider.gameObject.transform);
                    isHandEmpty = true;
                }
            } 
        }
    }

}
