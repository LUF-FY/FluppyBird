using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{

    public Rigidbody2D myRigidbody2D;
    public Collider2D collider2D;
    public float flapStrength;
    public LogicScript logic;
    public bool birdIsAlive = true;
    public Animator animator;
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<LogicScript>();
    }

    public void Flap()
    {
        if (birdIsAlive)
        {
            animator.SetTrigger("flap");
            myRigidbody2D.velocity = Vector2.up * flapStrength;
        }
    }

    private void FixedUpdate()
    {       
        myRigidbody2D.rotation = myRigidbody2D.velocity.y;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        collider2D.enabled = false;
        logic.gameOver();
        birdIsAlive = false;
    }
}
