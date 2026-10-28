using System.Collections;
using UnityEngine;

public class P1Attacks : MonoBehaviour
{
    public Punch Punche;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            StartCoroutine(punch());
        }
    }
        
        IEnumerator punch()
        {
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
}
