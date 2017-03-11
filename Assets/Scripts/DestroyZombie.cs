using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyZombie : MonoBehaviour {
    //private float breakForce = 150f;

	// Use this for initialization
//	void Start () {
  //      GetComponent<Rigidbody>.collisionDetectionMode = CollosionDetectionMode.Continuous;

            	
	//}
	
	void OnCollisionEnter(Collision collision)
    {
       
            GameObject[] enemies = GameObject.FindGameObjectsWithTag("enemy");
            foreach (GameObject enemy in enemies)
            {
                Destroy(enemy);
            }

    }
}
