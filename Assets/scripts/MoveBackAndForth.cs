using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBackAndForth : MonoBehaviour {

	private int direction=1;
	private float ypos;

	// Use this for initialization
	void Start () {
		ypos=transform.position.y;
	}
	
	// Update is called once per frame
	void Update () {
		transform.localPosition=new Vector3(transform.localPosition.x,transform.localPosition.y+Random.Range(0.001f,0.1f)*direction,transform.localPosition.z);
		if(transform.localPosition.y>=2.68)
		{
			direction=-1;
		}
		if(transform.localPosition.y<=.68)
		{
			direction=1;
		}
	}
}
