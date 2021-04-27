using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;
public class Projectile : MonoBehaviour
{
    public float timer = 0f;
    public Light2D light;
    float timeToKill = 13f;
    void Start()
    {
        timer = timeToKill;
        for (int i = 0; i < 6; i++)
        {
            sources[i] = gameObject.AddComponent<AudioSource>();
            sources[i].maxDistance = source.maxDistance;
            sources[i].spatialBlend = 1f;
            sources[i].outputAudioMixerGroup = source.outputAudioMixerGroup;
        }
    }


    void Update()
    {
        timer -= Time.deltaTime;
        if(timer < 2f) light.intensity = timer;
        if(timer < 0) Destroy(this.gameObject);
    }

    public AudioSource source;
    AudioSource[] sources = new AudioSource[6];
    int i = 0;
    public Rigidbody2D rg;
    void OnCollisionEnter2D(Collision2D other)
    {
        
        sources[i].pitch = Random.Range(.85f,1.15f);
        sources[i].PlayOneShot(source.clip, Mathf.Clamp01(rg.velocity.magnitude) );
        i++;
        if(i>sources.Length-1) i = 0;
        
    }
}
