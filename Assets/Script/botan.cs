using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class botan : MonoBehaviour
{
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlayStart()
    {
        audioSource.PlayOneShot(audioSource.clip);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
