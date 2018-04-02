using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {



    private float vertical;
    private float horizontal;
	
    // Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {

        vertical = Input.GetAxis("Vertical");
        horizontal = Input.GetAxis("Horizontal");

        if (vertical > 0)
        {

        }
	}
}
