using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Creating a public float called "speed" and setting it to 5
    public float speed = 5f;

    //Importing the Rigidbody2D to "rb"
    public Rigidbody2D rb;

    //Importing the Main Camera to "cam"
    public Camera cam;

    //Public Int for health
    public int health = 100;

    //Creating a Vector2 term called "movement"
    Vector2 movement;

    //Creating a Vector2 term called "mousePos" which stands for the Mouse Position
    Vector2 mousePos;

    // Update is called once per frame
    void Update()
    {
        //Getting the raw horizontal axis for the x axis movement
        movement.x = Input.GetAxisRaw("Horizontal");

        //Getting the raw vertical axis for the y axis movement
        movement.y = Input.GetAxisRaw("Vertical");

        //Getting the mouse position for looking at mouse command
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
    }

    private void FixedUpdate()
    {
        //Movement Command
        rb.MovePosition(rb.position + movement * speed * Time.deltaTime);

        //Subtracting the two vectors to get the "lookDir' which stands for look direction
        Vector2 lookDir = mousePos - rb.position;

        //getting the angle of the mouse using Atan2, Atan2 is basically the angle to the line drawn from axis to the mouse, in our case, (Atan2 uses the y, x btw) after that when we get the "radians" from Atan2 we convert them to Degrees
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg;

        //Just defining the rotation of the Rigidbody 2D to be = "angle", which I defined above
        rb.rotation = angle;
    }

    //Taking Damage
    public void TakeDamage(int Damage)
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
