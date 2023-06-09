using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSoundsController : MonoBehaviour
{
    private AudioSource audioSource;
    [SerializeField]
    private AudioClip stepClip;
    [SerializeField]
    private AudioClip startJumpClip;
    [SerializeField]
    private AudioClip landJumpClip;

    public bool isWalking = false;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.loop = false;
        audioSource.volume = Settings.sfxVolume*Settings.masterVolume;
        PlayStep();
    }
    public bool CanChangeToStep()
    {
        if ((audioSource.isPlaying && !audioSource.loop) || (audioSource.clip == stepClip && audioSource.isPlaying))
        {
            return false;
        }
        return true;
    }
    public void PlayStep()
    {
        audioSource.clip = stepClip;
        audioSource.Play();
    }
    
    public void PlayStartJump()
    {

        audioSource.clip = startJumpClip;
        audioSource.Play();
    }

    public void PlayLandJump()
    {
        audioSource.clip = landJumpClip;
        audioSource.Play();
    }
}
