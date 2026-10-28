using UnityEngine;
using TMPro;
public class PlayerBehaviour : MonoBehaviour
{
    public TextMeshProUGUI HPtext;
    public int health;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    private void Awake()
    {
        health = 100;
    }
    // Update is called once per frame
    void Update()
    {
        HPtext.text = health.ToString();
    }

}
