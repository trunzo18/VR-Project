﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
public class PlayerController : MonoBehaviour
{

	//public SteamVR_Action_Vector input;
	public float speed = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position += speed * Time.deltaTime * new Vector3(input.axis.x, 0, input.axis.y);
    }
}
