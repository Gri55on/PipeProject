using UnityEngine;
using System.Collections;

public class Pipe : MonoBehaviour 
{
	 public float flowSpeed = 10.0f;

    //Pipe logic
    //On entering pipe
    void OnTriggerEnter(Collider other)
    { 
		//If the object that hits us is already colliding with a object that constains this scipt, do nothing.

		Debug.Log("Entered");
		//Turns off gravity
		other.gameObject.GetComponent<Rigidbody>().useGravity = false;
		
		//Test freeze of object
		other.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;

    }

    //While in pipe
    void OnTriggerStay(Collider other)
    {
		Debug.Log("Current");

		//Local pipe transform
		// How to store and apply transforms
		Vector3 pipeV = this.transform.TransformVector(new Vector3(0, flowSpeed, 0));

		//Adds a force relative to the direction of the pipe transform
		other.gameObject.GetComponent<Rigidbody>().AddForce(pipeV);
		
    }

	//On Pipe Exit
	void OnTriggerExit(Collider other)
	{
		Debug.Log("Exit");
		//Object affected by gravity once it has left the pipe
		other.gameObject.GetComponent<Rigidbody>().useGravity = true;

	}
	
}
