using UnityEngine;

public class Collectible : MonoBehaviour
{

    public ScoreManager scoreManager;
    public AudioClip pickupSound;
  
    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            scoreManager.AddPoint();
            if(pickupSound != null)
            {
                AudioSource.PlayClipAtPoint(pickupSound, transform.position);
            }
            Debug.Log("Zebrano przedmiot");
            Destroy(gameObject);
        }
    }
        
    
}
