using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControler : MonoBehaviour {
	
	public float speed;
	//public jumpforce;
	
	private Rigidbody rb;
	
	void Start ()
	{
		rb=GetComponent<Rigidbody>();
	}
	
	void FixedUpdate () 
	{
		//debug.DrawRay
		
		//isGrounded=physics.Raycast(transform.position,Vector3.down,0.5f);
		if(Input.GetKey(KeyCode.Space)){
			rb.AddForce(0,12,0);
		}
		
		float moveHorizontal=Input.GetAxis("Horizontal");
		float moveVertical=Input.GetAxis("Vertical");
		Vector3 movement=new Vector3 (moveHorizontal,0.0f,moveVertical);
		rb.AddForce(movement*speed);
	}
}
