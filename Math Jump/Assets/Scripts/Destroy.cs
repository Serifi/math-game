using UnityEngine;

public class Destroy : MonoBehaviour
{
    public GameObject platformPrefab;
    private int counter = 3;
    private float playerPos;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject) counter++;
        Destroy(collision.gameObject);
        if (counter == 4)
        {
            playerPos = GameObject.Find("Player").transform.position.y;
            Instantiate(platformPrefab, new Vector2(-55, playerPos + 20), Quaternion.identity);
            Instantiate(platformPrefab, new Vector2(-20, playerPos + 20), Quaternion.identity);
            Instantiate(platformPrefab, new Vector2(20, playerPos + 20), Quaternion.identity);
            Instantiate(platformPrefab, new Vector2(55, playerPos + 20), Quaternion.identity);
            counter = 0;
        }
    }
}