using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity;

public class ColourChange : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if(Input.GetKeyDown(KeyCode.R)){
            gameObject.renderer
         // gameObject.GetComponent<Renderer>().material.color("Red");
        }
        if(Input.GetKeyDown(KeyCode.G)){
           //gameObject.GetComponent<Renderer>().material.color("Green");
        }
        if(Input.GetKeyDown(KeyCode.B)){
          // gameObject.GetComponent<Renderer>().material.color("Blue");
        }
	}
}
