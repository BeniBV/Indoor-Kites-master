using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpItem : MonoBehaviour {

    public Transform theDestination;

    // if mouse button is clicked on the objects collider then move that objects position 
     void OnMouseDown()
    {
        GetComponent<Rigidbody>().useGravity = false;
        this.transform.position = theDestination.position;
        this.transform.parent = GameObject.Find("Destination").transform;
    }

    // if mouse button is released then drop obect. 
    void OnMouseUp()
    {
        this.transform.parent = null;
        GetComponent<Rigidbody>().useGravity = true; 
    }
}
