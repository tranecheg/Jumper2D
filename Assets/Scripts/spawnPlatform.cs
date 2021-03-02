using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class spawnPlatform : MonoBehaviour
{
    public GameObject player;
    private GameObject platformPref, newPlatform;
    private Vector2 newPos;
    public static int score;
    
    private void Start()
    {
        platformPref = gameObject;
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && platformPref!=newPlatform)
        {
            score++;
            
            if (platformPref.transform.position.x > 0)
            {
                newPos = new Vector2(Random.Range(-2, -1), platformPref.transform.position.y - 3);
                player.GetComponent<SpriteRenderer>().flipX = true;
            }
            else
            {
                newPos = new Vector2(Random.Range(1, 2), platformPref.transform.position.y - 3);
                player.GetComponent<SpriteRenderer>().flipX = false;
            }
                
            newPlatform = Instantiate(platformPref, newPos, Quaternion.identity);
            newPlatform.transform.SetParent(platformPref.transform.parent);
            newPlatform.name = "Platform";
            platformPref = newPlatform;
        }
            
    }
}
