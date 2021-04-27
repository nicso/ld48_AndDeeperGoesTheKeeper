using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovements : MonoBehaviour
{
    public Rigidbody2D rg;
    public Vector2 inputsDirection;
    public float speed = 10f;
    float x,y;
    Inputs  controls;
    Mamager manager;

    AudioSource source;
    public AudioClip shock;
    bool canMove;

    void Awake()
    {
        manager = GameObject.Find("manager").GetComponent<Mamager>();
        controls = new Inputs();
        controls.Player.Horizontal.performed += ctx => x = ctx.ReadValue<float>();
        controls.Player.Vertical.performed += ctx => y = ctx.ReadValue<float>();
        controls.Player.Vertical.canceled += ctx => y = 0;
        controls.Player.Horizontal.canceled += ctx => x = 0;

        controls.Player.respawn.performed += ctx => manager.Respawn();
        controls.Player.toggleMap.performed += ctx => manager.ToggleMap();

        controls.Player.q_low.performed += ctx => manager.ChangeQuality(0);
        controls.Player.q_normal.performed += ctx => manager.ChangeQuality(1);
        controls.Player.q_ultra.performed += ctx => manager.ChangeQuality(2);
    }
    void Start()
    {
        source = GetComponent<AudioSource>();   
    }

    void OnEnable()
    {
        controls.Player.Enable();
    }
    void OnDisable()
    {
           controls.Player.Disable();
    }

    void Update(){
        inputsDirection = Vector2.zero;
        inputsDirection = new Vector2(x,y);
    }

    
    void FixedUpdate()
    {

        rg.AddForce(inputsDirection * speed, ForceMode2D.Force);
        
    }

    
    void OnCollisionEnter2D(Collision2D other)
    {
        source.pitch = Random.Range(.85f,1.15f);
        source.PlayOneShot(shock, Mathf.Clamp01(rg.velocity.magnitude) );
    }
}

