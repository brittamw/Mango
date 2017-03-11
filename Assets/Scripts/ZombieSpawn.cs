using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSpawn : MonoBehaviour {

    public GameObject zombieagent;
    public GameObject targetObject;

	// Use this for initialization
	void Start () {

        Invoke("SpawnZombie", 5);	
	}
	
    void SpawnZombie()
    {
        GameObject zombie = (GameObject)Instantiate(zombieagent, this.transform.position, Quaternion.identity);
        zombie.GetComponent<AgentNavigationScript>().Target = targetObject.transform;
        Invoke("SpawnZombie", Random.Range(2, 5));
    }
	
}
