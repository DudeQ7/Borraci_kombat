using System.Collections;
using System.Diagnostics;
using UnityEngine;
public struct attacksoalgo
{
    private float dmg;
    private int startup;
    private int plussness;
    private int recovery;
    
    public attacksoalgo(int dmg, int startup, int plussness, int recovery) : this()
    {
        this.dmg = dmg;
        this.startup = startup;
        this.plussness = plussness;
        this.recovery = recovery;
    }
}
public class P1Attacks : MonoBehaviour
{
    
    attacksoalgo punch = new(5, 5, 3, 15);
    public PlayerMovement p1;
    public PlayerMovement p2;
    //public Punch Punche;
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
        if (Input.GetKeyDown(KeyCode.G))
        {
           // StartCoroutine(attack());
        }
    }
        
        IEnumerator attack()
        {
        p1.dmg = 5;
            for(int i=0; i<5; i++)
        {
            yield return null;
        }
            Punche.gameObject.SetActive(true);
        for (int i = 0; i < 15; i++)
        {
            yield return null;
        }
    } 

    public void OnTriggerEnter(Collider other)
    {
        p2.health -= p1.dmg;
    }
}

