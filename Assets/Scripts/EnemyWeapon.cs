using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWeapon : MonoBehaviour
{
    //Creating a transform for the firepoint (the place from where the bullet will shoot)
    public Transform enemyFirepoint;

    //Creating a gameobject for the bullet
    public GameObject enemybulletprefab;

    // Update is called once per frame
    void Update()
    {
        //If statement for clicking the button "Fire1" (by default left click)
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    //shooting logic
    void Shoot()
    {
        //Create the bullet prefab at the position and rotation of the firepoint
        Instantiate(enemybulletprefab, enemyFirepoint.position, enemyFirepoint.rotation);
    }
}
