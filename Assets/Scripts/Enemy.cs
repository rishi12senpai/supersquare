using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    //Public Int for health
    public int health = 100;

    //Taking damage
    public void TakeDamage (int Damage)
	{
        health -= Damage;

        //If statement for death
        if (health <= 0)
		{
            Die();
		}
	}

    //Death
    void Die()
	{
        Destroy(gameObject);        
    }
}
