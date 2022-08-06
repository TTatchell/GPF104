using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lives : MonoBehaviour
{
    public int lives;
    private GameObject bossController;
    // Start is called before the first frame update
    void Start()
    {
        lives = 0;
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void DecrementLife()
    {
        if (lives > 0)
        {
            lives--;
        }
        else
        {
            bossController = GameObject.Find("BossController");
            bossController.GetComponent<GameOver>().RunGameOver();
        }
    }
}
