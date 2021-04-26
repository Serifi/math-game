using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Bottom : MonoBehaviour
{
    public Text scoreT;
    private GameObject bottom;
    private float playerPos;

    private void Update()
    {
        bottom = GameObject.Find("Bottom");
        playerPos = GameObject.Find("Player").transform.position.y;
        
        if (playerPos > bottom.transform.position.y + 50)
            bottom.transform.SetPositionAndRotation(new Vector3(bottom.transform.position.x, playerPos - 50), Quaternion.identity);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            SceneManager.LoadScene("Restart");
            Transmitter.scoreT = Int32.Parse(this.scoreT.text);
        }
    }
}
