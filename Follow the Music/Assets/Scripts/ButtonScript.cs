using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ButtonScript : MonoBehaviour
{

    UnityStandardAssets.Characters.FirstPerson.FirstPersonController firstPersonScript;
    public bool changeColour = false;

    // Use this for initialization
    void Start ()
    {
        GetComponent<MeshRenderer>().materials[1].color = Color.red;
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (changeColour == true)
        {
            GetComponent<MeshRenderer>().materials[1].color = Color.blue;
        }
        else
        {
            GetComponent<MeshRenderer>().materials[1].color = Color.red;
        }
    }


     
        
}
