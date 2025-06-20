using UnityEngine;

public class BackgroundMusic : MonoBehaviour
{
    public AudioClip musicClip;

    private AudioSource audioSource;

    void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.clip = musicClip;
        audioSource.loop = true;
        audioSource.playOnAwake = true;
        audioSource.Play();
    }
}
