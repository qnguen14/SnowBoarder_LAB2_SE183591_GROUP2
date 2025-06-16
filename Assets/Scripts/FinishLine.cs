using UnityEngine;

public class FinishLine : MonoBehaviour
{
    private AudioSource finishSound;

    void Start()
    {
        
        finishSound = GetComponent<AudioSource>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Finish Line reached!");

            
            if (finishSound != null)
            {
                finishSound.Play();
            }

            
        }
    }
}
