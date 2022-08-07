using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level1 : MonoBehaviour
{
    public GameObject projectile;
    public float yStart;
    public float xStart;
    public float zStart;
    public float dxStart;
    public float dyStart;
    public float dzStart;
    public float fxStart;
    public float fyStart;
    public float fzStart;
    public float jxStart;
    public float jyStart;
    public float jzStart;
    public float kxStart;
    public float kyStart;
    public float kzStart;
    public int nextAttackKey;
    public float xGoal;
    public float yGoal;
    private float nextActionTime = 0.0f;
    private float attackRestPeriod;

    // Start is called before the first frame update
    void Start()
    {
        dxStart = -11f;
        dyStart = 2.85f;
        dzStart = 55.3f;

        fxStart = -5.5f;
        fyStart = 6;
        fzStart = 24f;

        jxStart = 5.5f;
        jyStart = 6;
        jzStart = -24f;

        kxStart = 11f;
        kyStart = 2.85f;
        kzStart = -55.3f;

    }

    // Update is called once per frame
    void Update()
    {
        if (Time.timeSinceLevelLoad > nextActionTime)
        {
            // Decrease attackRestPeriod slightly to increase difficulty
            attackRestPeriod = Mathf.Pow(1.05f, Time.timeSinceLevelLoad * -1) + 0.5f;

            nextActionTime = Time.timeSinceLevelLoad + attackRestPeriod;

            nextAttackKey = Random.Range(0,4);
            switch (nextAttackKey) // can probably write this more efficiently using random selection from array
            {
                case 0:
                    xStart = dxStart;
                    yStart = dyStart;
                    zStart = dzStart;
                    break;
                case 1:
                    xStart = fxStart;
                    yStart = fyStart;
                    zStart = fzStart;
                    break;
                case 2:
                    xStart = jxStart;
                    yStart = jyStart;
                    zStart = jzStart;
                    break;
                case 3:
                    xStart = kxStart;
                    yStart = kyStart;
                    zStart = kzStart;
                    break;
            }

            Instantiate(projectile, new Vector3(xStart, yStart, 0), Quaternion.Euler(0, 0, zStart));
        }
    }

    
}
