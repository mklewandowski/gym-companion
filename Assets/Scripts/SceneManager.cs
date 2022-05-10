using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour
{
    [SerializeField]
    AudioClip[] GymSound = new AudioClip[10];

    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlaySound()
    {
        int soundNum = Random.Range(0, 10);
        audioSource.clip = GymSound[soundNum];
        audioSource.Play();
    }
}
