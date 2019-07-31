using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour

//camera follow to be attached to the camera 
  //keep the offest at 0 or 4 because it the view of the player that is the target 
  {
	public float yOffset;
    private Vector3 initialPosition;
    private Transform target;

    // Start is called before the first frame update
    void Start()
    {
        //this will the reference to the player as it is the target position; disabled for now 
        //target = FindObjectOfType<PlayerMovement>().transform;
    }

    void LateUpdate()
    {
        transform.position = initialPosition + Vector3.up * yOffset + target.position;
    }
}


