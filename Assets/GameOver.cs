using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RunGameOver()
    {
        Debug.Log("GAME OVER")
        Time.timeScale = 0;
        //SceneManager.LoadScene(sceneName: "GameOver");
        Application.Quit();
    }
}
