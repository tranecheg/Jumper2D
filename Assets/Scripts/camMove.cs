using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class camMove : MonoBehaviour
{
    public GameObject player;
    public Text textScore;

    private void Awake()
    {
        spawnPlatform.score=0;
    }
    private void Start()
    {
        spawnPlatform.score--;
    }
    void Update()
    {
        if(player!=null)
        transform.position = new Vector3(0, player.transform.position.y-2, -10);
        textScore.text = "Score: " + spawnPlatform.score;
    }
}
