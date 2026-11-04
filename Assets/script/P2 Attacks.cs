using System.Collections;
using UnityEngine;

public class P2Attacks : MonoBehaviour
{
    public PlayerBehaviour p1;
    public PlayerBehaviour p2;
    public Punch Punche;
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
        if (Input.GetKeyDown(KeyCode.Keypad5))
        {
            StartCoroutine(punch());
        }
    }
        
        IEnumerator punch()
        {
        p2.dmg = 5;
            for(int i=0; i<5; i++)
        {
            yield return null;
        }
           Punche.gameObject.SetActive(true);
        for (int i = 0; i < 15; i++)
        {
            yield return null;
        }
        Punche.gameObject.SetActive(false);
    }

    public void OnTriggerEnter(Collider other)
    {
        p1.health -= p2.dmg;
    }
}
