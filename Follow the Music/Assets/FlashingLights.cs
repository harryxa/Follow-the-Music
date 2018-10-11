using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashingLights : MonoBehaviour {


    public float lightTimer;
	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        lightTimer += Time.deltaTime;

        if(lightTimer >= 1)
        {
            GetComponent<Light>().enabled = !GetComponent<Light>().enabled;
            lightTimer = 0.0f;
        }



	}
}
