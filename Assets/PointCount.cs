using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointCount : MonoBehaviour
{
    public GUIStyle pointsStyle;
    public int points;

    // Start is called before the first frame update
    void Start()
    {
        points = 0;
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void IncrementPoints()
    {
        points++;
    }

    void OnGUI()
    {
        GUI.Label(new Rect(30, 10, 100, 40), points.ToString(), pointsStyle);
    }
}
