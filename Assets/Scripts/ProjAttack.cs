using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjAttack : MonoBehaviour
{
    private float speed;
    private float xMove;
    private float yMove;
    private float xGoal;
    private float yGoal;
    private Vector3 target;
    private GameObject bossController;

    // Start is called before the first frame update
    void Start()
    {
        xGoal = 0;
        yGoal = -3f;
        target = new Vector3(xGoal, yGoal, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        // Speed increases with time
        speed = (Time.time + 30) / 15; // Change last digit to change difficulty (10 for hard, 15 for medium, 20 for easy)

        // Calculate distance to move and move accordingly
        var step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target, step);
    }

    void OnTriggerStay2D(Collider2D box)
    {
        GameObject boxObj = box.gameObject;
        switch (boxObj.tag)
        {
            case "dBox":
                if (Input.GetKey(KeyCode.D))
                {
                    GameObject projectile = GetComponent<Collider2D>().gameObject;
                    Destroy(projectile);
                    bossController = GameObject.Find("BossController");
                    bossController.GetComponent<PointCount>().IncrementPoints();
                }
                break;

            case "fBox":
                if (Input.GetKey(KeyCode.F))
                {
                    GameObject projectile = GetComponent<Collider2D>().gameObject;
                    Destroy(projectile);
                    bossController = GameObject.Find("BossController");
                    bossController.GetComponent<PointCount>().IncrementPoints();
                }
                break;

            case "jBox":
                if (Input.GetKey(KeyCode.J))
                {
                    GameObject projectile = GetComponent<Collider2D>().gameObject;
                    Destroy(projectile);
                    bossController = GameObject.Find("BossController");
                    bossController.GetComponent<PointCount>().IncrementPoints();
                }
                break;

            case "kBox":
                if (Input.GetKey(KeyCode.K))
                {
                    GameObject projectile = GetComponent<Collider2D>().gameObject;
                    Destroy(projectile);
                    bossController = GameObject.Find("BossController");
                    bossController.GetComponent<PointCount>().IncrementPoints();
                }
                break;

            case "Player":
                if (true)
                {
                    GameObject projectile = GetComponent<Collider2D>().gameObject;
                    Destroy(projectile);
                    bossController = GameObject.Find("BossController");
                    bossController.GetComponent<Lives>().DecrementLife();
                    break;
                }
        }

    }
}
