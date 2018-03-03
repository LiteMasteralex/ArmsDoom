using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tilt : MonoBehaviour {

    void Update(){
        if (Input.GetKey("left"))
        {
			transform.Rotate(Vector3.back);
        }
        if (Input.GetKey("right"))
        {
			transform.Rotate(Vector3.forward);
        }
    }
}
