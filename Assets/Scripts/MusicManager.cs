using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    public AudioSource source;
    public AudioSource source2;
    public AudioClip firstLoop, loop;
    public bool musicStarted = false;

    void Start()
    {
        
    }

    
    void Update()
    {
        if(!musicStarted) return;
        if(!source.isPlaying && source.clip == firstLoop && !source2.isPlaying){
            source2.Play();
            Destroy(this);

        } 

        
    }

    public void StartMusic(){
        source.Play();
        musicStarted = true;

    }
}
