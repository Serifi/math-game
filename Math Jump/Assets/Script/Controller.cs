using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controller : MonoBehaviour
{
    private Rigidbody2D rb2d;
    private float moveInput;
    private float speed = 10f;
    public Text scoreText;
    private float topScore = 0.0f;
    private bool isStarted = false;
    public Text startText;
    
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.gravityScale = 0;
        rb2d.velocity = Vector3.zero;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isStarted == false)
        {
            isStarted = true;
            startText.gameObject.SetActive(false);
            rb2d.gravityScale = 5f;
        }

        if (isStarted)
        { 
            //Spieler rechts/links spiegeln
        if (moveInput > 0) this.GetComponent<SpriteRenderer>().flipX = true;
        else this.GetComponent<SpriteRenderer>().flipX = false;

        //Score
        if (rb2d.velocity.y > 0 && transform.position.y > topScore) topScore = transform.position.y;
        scoreText.text = Math.Round(topScore).ToString();
        }
    }

    void FixedUpdate()
    {
        if (isStarted)
        {
            moveInput = Input.GetAxis("Horizontal");
            rb2d.velocity = new Vector2(moveInput * speed, rb2d.velocity.y);
        }
    }
}