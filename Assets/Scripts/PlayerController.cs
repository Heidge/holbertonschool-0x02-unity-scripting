using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public Rigidbody rb;
	public float speed = 1000f;

	// Use this for initialization
	void Start () {
		
	}

	// Increase the number of calls to FixedUpdate.
    void FixedUpdate()
    {

		if (Input.GetKey("z"))
		{
			rb.AddForce(0, 0, 500 * Time.deltaTime);
		}

		if (Input.GetKey("s"))
		{
			rb.AddForce(0, 0, -500 * Time.deltaTime);
		}

		if (Input.GetKey("d"))
		{
			rb.AddForce(500 * Time.deltaTime, 0, 0);
		}

		if (Input.GetKey("q"))
		{
			rb.AddForce(-500 * Time.deltaTime, 0, 0);
		}
    }
}