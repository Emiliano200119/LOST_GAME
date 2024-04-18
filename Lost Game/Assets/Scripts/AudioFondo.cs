using UnityEngine;

public class MusicaFondo : MonoBehaviour
{
    private AudioSource audioSource;

    public AudioClip musicaDeFondo;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }

        audioSource.clip = musicaDeFondo;

        audioSource.Play();
    }
}
