using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameOver : MonoBehaviour
{
    public GameObject player, restart, platform;
    
    private void Update()
    {
        if (player != null)
            if (platform.transform.childCount==0)
            {
            Destroy(player);
            restart.SetActive(true);
            }
        
    }
    public void restartGame()
    {
        SceneManager.LoadScene("Game");
    }
}
