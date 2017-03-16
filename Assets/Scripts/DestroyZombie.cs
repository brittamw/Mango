using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyZombie : MonoBehaviour {
    

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







