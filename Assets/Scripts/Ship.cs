using UnityEngine;
using System.Collections;

public class Ship : MonoBehaviour 
{
	public float paddleSpeed = 1f;
	private Vector3 playerPosition = new Vector3 (0, -3, 0);
	private GameObject cloneLaser;
	public GameObject ShipLaser;
	
	void Update () 
	{
		Shoot ();
		float xPosition = transform.position.x + (Input.GetAxis ("Horizontal") * paddleSpeed);
		playerPosition = new Vector3 (Mathf.Clamp (xPosition, -10f, 10f), -3f, 0f);
		transform.position = playerPosition;
	}

	void Shoot ()
	{
		if (Input.GetButtonDown("Jump"))
		{
			Debug.Log ("Shoot");
			cloneLaser = Instantiate (ShipLaser, transform.position, Quaternion.identity) as GameObject;
		}
	}

    void OnTriggerEnter(Collider other)
    {
        if (gameObject.other.tag )
        Debug.Log("Hit");
    }

}
