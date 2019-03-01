using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerMovement))] 
public class PlayerController : MonoBehaviour {

    public LayerMask movementMask;

    Camera cam;
    PlayerMovement movement; 
	// Use this for initialization
	void Start () {
        cam = Camera.main;
        movement = GetComponent<PlayerMovement>();
		
	}
	
	// Update is called once per frame
	void Update ()
        // if the mouse button is clicked on the ground then move to that position 
    {
		if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 120, movementMask))
            {
                //Debug.Log("WE HIT!!!!!" + hit.collider.name + "" + hit.point);
                movement.MoveToPoint(hit.point);
            }
        }
	}
}
