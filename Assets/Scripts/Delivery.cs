using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Delivery : MonoBehaviour
{
	bool hasPackage = false;

	[SerializeField] float destroyDelay = 0.5f;

    void OnCollisionEnter2D(Collision2D other)
	{
		
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Package" && !hasPackage)
		{
			hasPackage = true;
			Debug.Log("Package picked up.");
			Destroy(other.gameObject, destroyDelay);
		}

		if (other.tag == "Customer" && hasPackage)
		{
			hasPackage = false;
			Debug.Log("Package delivered.");
		}
	}
}
