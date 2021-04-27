using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;
public class BadGuy : MonoBehaviour
{
    public List<GameObject> entities = new List<GameObject>();
    public Lights[] playerLights;
    Rigidbody2D rg;
    Vector3 vel;
    public bool playerIsLight;
    public Light2D warningLight;
    public Color calmColor,AngryColor;
    float speed = 3.5f;
    Mamager manager;
    Vector3 startPosition;
    public AudioSource source;
    void Start()
    {
        rg = GetComponent<Rigidbody2D>();
        manager = GameObject.Find("manager").GetComponent<Mamager>();
        startPosition = transform.position;

    }
    public bool saw{
        get{ return Saw;}

        set{
            if(value != Saw){
                Saw = value;
                if(!source.isPlaying)source.PlayOneShot(source.clip);

            }
        }
    }
    bool Saw = false;
    void Update()
    {
        playerIsLight = false;
        warningLight.color = calmColor;
        if(entities.Count>0) 
        {
            if(entities[entities.Count-1].tag == "Player" ){
               foreach (Lights light in playerLights)
               {
                   if(light.on) playerIsLight = true;
               }

               if(playerIsLight){
                    saw = true;
                    
               }else{

               }
            }else {
                saw = true;
            }
        }
        if(saw){
            warningLight.color = AngryColor;
            //rg.AddForce(transform.right * speed ,ForceMode2D.Force);
            //rg.MovePosition( (rg.position+Vector2.right) * speed * Time.deltaTime);
            transform.Translate(Vector3.right * Time.deltaTime * 3f);
            
        } 

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(!other.GetComponent<Rigidbody2D>())return;
        
        if(!entities.Contains(other.gameObject)) entities.Add(other.gameObject);

        
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if(entities.Contains(other.gameObject)) entities.Remove(other.gameObject);
       
        
    }
    
    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.collider.GetComponent<PlayerMovements>() != null) {
            StartCoroutine(Reset())    ;

        }
        
    }

    IEnumerator Reset(){
        
        warningLight.enabled =false;
        manager.Respawn();
        rg.velocity = Vector2.zero;
        transform.position = startPosition;
        yield return new WaitForSeconds(1.0f);
        rg.velocity = Vector2.zero;
        saw = false;
        warningLight.enabled =true;
        yield return new WaitForEndOfFrame();
    }

}
