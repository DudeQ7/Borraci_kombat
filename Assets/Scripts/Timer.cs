using TMPro;
using UnityEngine;
using System;

public class Timer : MonoBehaviour
{
    public float time = 99f;
    public TextMeshProUGUI timer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        timer = gameObject.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        timer.text = Math.Ceiling(time).ToString();
    }

    public void timeUp()
    {

    }
    
    public void resetTime(float f = 99)
    {
        time = f;
    }
}
