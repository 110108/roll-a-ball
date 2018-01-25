using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControler : MonoBehaviour {
	
	public float speed;
	public float jumpforce;
	public bool isGrounded;
	public type wall;
	
	private Rigidbody rb;
	
	void Start ()
	{
		rb=GetComponent<Rigidbody>();
	}
	
	void OnTriggerEnter (Collider other){
		if(other.gameObject.CompareTag("pickup")){
            other.gameObject.SetActive(false);
			//count++;
			//SetCountText();
		}
	}
	
	void FixedUpdate () 
	{
		//debug.DrawRay
		
		isGrounded=Physics.Raycast(transform.position,Vector3.down,0.5f);
		if(Input.GetKey(KeyCode.Space)&&isGrounded==true){
			rb.AddForce(0,jumpforce,0);
		}
		
		float moveHorizontal=Input.GetAxis("Horizontal");
		float moveVertical=Input.GetAxis("Vertical");
		Vector3 movement=new Vector3 (moveHorizontal,0.0f,moveVertical);
		rb.AddForce(movement*speed);
		
		if(count==21){
			wall
	}
}
