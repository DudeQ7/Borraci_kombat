using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] float mult = 250f;
    public float shake = 20f;
    public float time = 99f;
    public TextMeshProUGUI timer;
    private float x, y, t;
    private Vector3 start;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        timer = gameObject.GetComponent<TextMeshProUGUI>();
        start = transform.position;
    }
    
    // Update is called once per frame
    void Update()
    {
        if (time <= 0)
        {
            timeUp();
        }
        else
        {
            Shake(-x, -y);
            t = 1 - time / shake;
            time -= Time.deltaTime;
            timer.text = System.Math.Ceiling(time).ToString();
            x = rand(t);
            y = rand(t);
            Shake(x, y);
        }
    }

    private void Shake(float x, float y)
    {
        timer.transform.position += new Vector3(x, y, 0);
    }

    private float rand(float scale = 1f)
    {
        return (Random.value - .5f)*(float)System.Math.Pow(mult, scale);
    }

    public void timeUp()
    {
        timer.transform.position = start;
        Time.timeScale = 0;
        this.enabled = false;
    }
    
    public void resetTime(float f = 99)
    {
        time = f;
    }
}
