using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    //Public transform for the spawner
    public Transform spawner;

    //Public Game Object for the enemy
    public GameObject enemy;

    void Update()
	{
        if (Input.GetButtonDown("Fire1"))
		{
            Instantiate(enemy, spawner.position, spawner.rotation);
		}
    }
}
