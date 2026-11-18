using Unity.VisualScripting;
using UnityEngine;
using System;

public class attacks : MonoBehaviour
{
    public event Action p1attacked;
    [SerializeField]
    int dmg;
    [SerializeField]
    int startup;
    [SerializeField]
    int plussness;
    [SerializeField]
    int recovery;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    private void Awake()
    {
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
