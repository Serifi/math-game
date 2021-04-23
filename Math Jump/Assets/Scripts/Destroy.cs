using UnityEngine;

public class Destroy : MonoBehaviour
{
    public GameObject player;
    public GameObject platformPrefab;
    public float spawnTime;
    public float spawnDelay;
    private int counter = 3;
    
    
    void Start()
    {
        
    }

    public void SpawnObject()
    {
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject) counter++;
        Destroy(collision.gameObject);
        if (counter == 4)
        {
            Instantiate(platformPrefab, new Vector2(-50, player.transform.position.y + 20), Quaternion.identity);
            Instantiate(platformPrefab, new Vector2(20, player.transform.position.y + 20), Quaternion.identity);
            Instantiate(platformPrefab, new Vector2(-20, player.transform.position.y + 20), Quaternion.identity);
            Instantiate(platformPrefab, new Vector2(50, player.transform.position.y + 20), Quaternion.identity);
            counter = 0;
        }
    }
}