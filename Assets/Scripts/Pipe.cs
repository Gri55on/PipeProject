using UnityEngine;
using System.Collections;

public class Pipe : MonoBehaviour 
{
    //Pipe logic
	 void OnTriggerStay(Collider other)
    {
        //Turns off gravity
        other.gameObject.GetComponent<Rigidbody>().useGravity = false;
        
        //Test freeze of object
        other.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;

        //Add Plain force
        other.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, 1, 0));

        //Add Relative force
         other.gameObject.GetComponent<Rigidbody>().AddRelativeForce(new Vector3 (0,1,0));
    }
	
}
