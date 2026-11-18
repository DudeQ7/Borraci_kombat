using UnityEngine;

public class attackmanager : MonoBehaviour
{
    public attacks punch;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    private void Awake()
    {
        punch.gameObject.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
