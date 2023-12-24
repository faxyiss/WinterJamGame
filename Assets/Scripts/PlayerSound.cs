using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSound : MonoBehaviour
{
    [SerializeField] AudioSource JumpAudioSource;
    [SerializeField] AudioSource deathSound;
    public void JumpSound()
    {
        JumpAudioSource.Play();
    }
    public void DeathSound()
    {
        deathSound.Play();
    }
}
