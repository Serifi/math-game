using System;
using UnityEngine;
using UnityEngine.UI;

public class Controller : MonoBehaviour
{
    private Rigidbody2D rb2d;
    private float moveInput;
    private float moveSpeed = 50f;
    public Text scoreText;
    public Text startText;
    private float topScore = 0.0f;
    private int highscore = 0;
    private bool isStarted = false;
    
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.gravityScale = 0;
        rb2d.velocity = Vector3.zero;
    }

    private void Update()
    {
        //Sapce zum Starten
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
        
            if (topScore > highscore)
            {
                highscore = (int) topScore;
                PlayerPrefs.SetInt("highscore", highscore);
                PlayerPrefs.Save();
            }
        
        }
        Transmitter.isStartedT = isStarted;
    }

    void FixedUpdate()
    {
        if (isStarted)
        {
            moveInput = Input.GetAxis("Horizontal");
            rb2d.velocity = new Vector2(moveInput * moveSpeed, rb2d.velocity.y);
        }
    }
}