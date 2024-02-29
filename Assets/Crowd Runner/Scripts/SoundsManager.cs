using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundsManager : MonoBehaviour
{

    [Header(" Sounds ")]
    [SerializeField] private AudioSource doorHitSound;

    // Start is called before the first frame update
    void Start()
    {
        PlayerDetection.onDoorsHit += PlayDoorHitSound;
    }

    private void OnDestroy()
    {
        PlayerDetection.onDoorsHit -= PlayDoorHitSound;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void PlayDoorHitSound()
    {
        doorHitSound.Play();
    }

    public void DisableSounds()
    {
        doorHitSound.volume = 0;
    }

    public void EnableSounds()
    {
        doorHitSound.volume = 1;
    }

}
