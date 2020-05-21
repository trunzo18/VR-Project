using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
	public AudioSource rollSource;
	private Vector3 startPos;
    // Start is called before the first frame update
    void Start()
    {
    	rollSource = GetComponent<AudioSource>();
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y <-5f) {
        	transform.position = startPos;
        	GetComponent<Rigidbody>().velocity = Vector3.zero;
        }
    }
    void OnCollisionEnter(Collision collision){
    	if (collision.gameObject.tag == "lane"){
    		rollSource.Play();
    	}
    }
}
