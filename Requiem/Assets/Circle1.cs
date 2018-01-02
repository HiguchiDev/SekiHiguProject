using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class Circle1 : MonoBehaviour {
	public Rigidbody rbody;
	private float speed;
	private float radius;
	private float zPosition;
 
	// Use this for initialization
	void Start () {
		speed = 10.0f;
		radius = 2.0f;
		zPosition = 0.5f;
	}
 
	// Update is called once per frame
	void Update () {
 
		rbody.MovePosition (new Vector3(radius*Mathf.Sin(Time.time*speed), radius*Mathf.Cos(Time.time*speed),zPosition));
 
	}
}
