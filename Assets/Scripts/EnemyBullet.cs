using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    //Speed of the bullet
    public float speed = 20f;

    //Damage of the bullet
    public int damage = 40;

    //Import the Rigidbody2D and name it "rb"
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        //We just tell our bullet to go right, respective to the rotation of the firepoint and multiply it to our speed
        rb.velocity = transform.right * speed;
    }

    //Collision of the bullet
    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        //Damage the enemy on collision
        PlayerController player = hitInfo.GetComponent<PlayerController>();
        if (player != null)
        {
            player.TakeDamage(damage);
        }

        //Get rid of the bulelet
        Destroy(gameObject);
    }
}
