using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mercyScript : MonoBehaviour
{
    public Rigidbody2D myRigidBody;
    public float flapStrength = 11;
    public LogicScript logic;
    public bool isAlive = true;
    public AudioSource collisionSFX;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true && isAlive) {
            myRigidBody.velocity = Vector2.up * flapStrength;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!logic.gameOverIsActive)
        {
            collisionSFX.Play();
        }
        logic.gameOver();
        isAlive = false;
    }
}
