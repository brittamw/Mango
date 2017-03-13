using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyZombie : MonoBehaviour {
    Animator ani;

    private void Start()
    {
        GetComponent<Rigidbody>().collisionDetectionMode = CollisionDetectionMode.Continuous;
        ani = GetComponent<Animator>();
    }

    private void OnCollisionEnter(Collision collision)
    {
            if (collision.collider.gameObject.tag == "enemy")
            {
                
                ani.SetTrigger("back_fall");
                //Destroy(collision.gameObject);
            }
        }
    

    
    

    
}







