using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSpawn : MonoBehaviour {

    public GameObject zombieagent;
    public GameObject targetObject;
    int count = 0;
	
	void Start () {

        Invoke("SpawnZombie", 5);
              
    }
	
    void SpawnZombie()
    {
        if (count < 10)
        {
            GameObject zombie = (GameObject)Instantiate(zombieagent, this.transform.position, Quaternion.identity);
            zombie.GetComponent<AgentNavigationScript>().Target = targetObject.transform;
            Invoke("SpawnZombie", Random.Range(2, 5));
            count++;
        }
    }
    }
	

