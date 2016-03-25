using UnityEngine;
using System.Collections;

public class Laser : MonoBehaviour 
{
	float laserVelocity = 800f;
	public Rigidbody laserRigidbody;


	void Awake () 
	{
        //Debug.Log ("Go!");
		fire ();
		timeDestroy ();
	}
	
	void fire ()
	{
		laserRigidbody.AddForce (new Vector3 (0f, laserVelocity, 0f));
        //Debug.Log(startTime);
	}

	void timeDestroy()
	{
        Destroy(gameObject, 2);  
	}
}
