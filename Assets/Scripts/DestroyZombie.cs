using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyZombie : MonoBehaviour {
    
	
	//void OnCollisionEnter(Collision collision)
 //   {
       
   //         GameObject[] enemies = GameObject.FindGameObjectsWithTag("enemy");
     /*       foreach (GameObject enemy in enemies)
            {
                Destroy(enemy);
            }

    }*/

    private float breakForce = 150f;

    private void Start()
    {
        GetComponent<Rigidbody>().collisionDetectionMode = CollisionDetectionMode.Continuous;
    }

    private void OnCollisionEnter(Collision collision)
    {
            if (collision.collider.gameObject.tag == "enemy")
            {
                Destroy(collision.gameObject);
            }
        }
    

    
    

    
}







