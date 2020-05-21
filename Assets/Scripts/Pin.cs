using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin : MonoBehaviour
{
	public AudioSource heavySource;
    // Start is called before the first frame update
    void Start()
    {
        heavySource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collision){
    	if (collision.gameObject.tag == "ball"){
    		heavySource.Play();
    	}
    }
}
