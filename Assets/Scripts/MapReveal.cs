using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;
public class MapReveal : MonoBehaviour
{
    float luminosityTarget;
    Light2D light;
    public bool lighted = false;    
    Mamager manager;
    public GameObject wall;
    public GameObject Blockingwall;
    public Vector3 dir;
    AudioSource source;
    public MusicManager music;
    public MapReveal secondReveal;
    void Start()
    {
        light = GetComponent<Light2D>();
        luminosityTarget = light.intensity;
        light.intensity = 0;
        manager = GameObject.Find("manager").GetComponent<Mamager>();
        source = gameObject.AddComponent<AudioSource>();
        source.clip = manager.treeGrow;
        source.spatialBlend = 1f;
        if(Blockingwall !=null)startPos = Blockingwall.transform.position;
    }


    public float timeToExtinct = 6f;
    float extinctTimer = 0;
    void Update()
    {
        if(wall != null)wall.SetActive(!lighted) ;
        if(lighted)
        {
            light.intensity += Time.deltaTime;

            if(secondReveal != null && !secondReveal.lighted){
                extinctTimer += Time.deltaTime;
                if(extinctTimer >= timeToExtinct){
                    extinctTimer = 0;
                    lighted = false;
                }
            }
        }else{
            light.intensity -= Time.deltaTime;

            if(Blockingwall !=null) Blockingwall.transform.position = Vector3.SmoothDamp(Blockingwall.transform.position, startPos,ref vel, Time.deltaTime *2f);
                //StartCoroutine(MoveWallBack());
            
        }
        light.intensity = Mathf.Clamp(light.intensity,0,luminosityTarget);
        
    }
    Vector3 vel;
    Vector3 startPos;
    bool reset = true;
    IEnumerator MoveWall(){
        
        yield return new WaitForSeconds(1f);
        source.PlayOneShot(manager.rollingStone);
        while (Vector3.Distance(Blockingwall.transform.position, startPos + dir) > 0.2f)
        {            
            Blockingwall.transform.Translate( dir.normalized * Time.deltaTime );
            yield return new WaitForEndOfFrame();
        }
    }

    IEnumerator MoveWallBack(){
        
        yield return new WaitForSeconds(1f);
        source.PlayOneShot(manager.rollingStone);
        while (Vector3.Distance(Blockingwall.transform.position, startPos - dir) > 0.2f)
        {            
            Blockingwall.transform.Translate( dir.normalized * Time.deltaTime );
            yield return new WaitForEndOfFrame();
        }
        reset = true;
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.name != "Projectile(Clone)" ) return;
        if(lighted) return;
        if(Blockingwall != null) StartCoroutine(MoveWall());
        if(music != null){
            music.StartMusic();
        }
        lighted= true;
        manager.SetRespawnPoint();
        Destroy(other.gameObject);
        source.Play();
    }
}
