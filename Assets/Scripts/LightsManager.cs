using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Experimental.Rendering.Universal;

public class LightsManager : MonoBehaviour
{
    public GameObject lightTop;
    Light2D _lightTop;
    public GameObject lightBottom;
    Light2D _lightBottom;
    public GameObject lightLeft;
    Light2D _lightLeft;
    public GameObject lightRight;
    Light2D _lightRight;

    Lights l_top;
    Lights l_bottom;
    Lights l_right;
    Lights l_left;

    public Light2D pointLight;
    Light2D plightTop;
    Light2D plightBottom;
    Light2D plightLeft;
    Light2D plightRight;

    public Transform lookRight;
    public Transform lookLeft;
    public Transform lookBottom;
    public Transform lookTop;
    
    public Rigidbody2D rg;

    public Transform lookAt;

    public float temp;

    public float fullLight = 1.25f;
    public float timer = 0f;
    public float timeForShoot = 1f;
    public float projectileForce = 3f;
    public GameObject projectilePrefab;
    Inputs controls;
    public bool shootted= false;
    void Awake()
    {
        controls = new Inputs();   
        controls.Player.BottomLight.performed += ctx => ToggleBottomLight();
        controls.Player.TopLight.performed += ctx => ToggleTopLight();
        controls.Player.LeftLight.performed += ctx => ToggleLeftLight();
        controls.Player.RightLight.performed += ctx => ToggleRightLight();

        controls.Player.BottomLight.canceled += ctx => OffBottomLight();
        controls.Player.TopLight.canceled += ctx => OffTopLight();
        controls.Player.RightLight.canceled += ctx => OffRightLight();
        controls.Player.LeftLight.canceled += ctx => OffLeftLight();


        controls.Player.Shoot.performed += ctx => Shoot();
    }
    void OnEnable()
    {
        controls.Enable();
    }
    void OnDisable()
    {
        controls.Disable();
    }

    void ToggleBottomLight(){
        l_bottom.Toggle_On();
    }
    void ToggleTopLight(){
        l_top.Toggle_On();
    }
    void ToggleLeftLight(){
        l_left.Toggle_On();
    }
    void ToggleRightLight(){
        l_right.Toggle_On();
    }

    void OffBottomLight(){
        l_bottom.Toggle_Off();
    }
    void OffTopLight(){
        l_top.Toggle_Off();
    }
    void OffRightLight(){
        l_right.Toggle_Off();
    }
    void OffLeftLight(){
        l_left.Toggle_Off();
    }




    void Shoot(){
        if(shootted) return;
        shootted = true;
        if(l_bottom.on){
            GameObject p = Instantiate(projectilePrefab,rg.position+Vector2.down, Quaternion.identity);
            p.GetComponent<Rigidbody2D>().AddForce(Vector2.down * projectileForce);
        }
        if(l_top.on){
            GameObject p = Instantiate(projectilePrefab,rg.position+Vector2.up, Quaternion.identity);
            p.GetComponent<Rigidbody2D>().AddForce(Vector2.up * projectileForce);
        }
        if(l_left.on){
            GameObject p = Instantiate(projectilePrefab,rg.position+Vector2.left, Quaternion.identity);
            p.GetComponent<Rigidbody2D>().AddForce(Vector2.left * projectileForce);
        }
        if(l_right.on){
            GameObject p = Instantiate(projectilePrefab,rg.position+Vector2.right, Quaternion.identity);
            p.GetComponent<Rigidbody2D>().AddForce(Vector2.right * projectileForce);
        }
    }




    void Start()
    {
        _lightTop = lightTop.GetComponent<Light2D>();
        _lightBottom = lightBottom.GetComponent<Light2D>();
        _lightLeft = lightLeft.GetComponent<Light2D>();
        _lightRight = lightRight.GetComponent<Light2D>();

        plightBottom = lightBottom.transform.GetChild(0).GetComponent<Light2D>();
        plightTop = _lightTop.transform.GetChild(0).GetComponent<Light2D>();
        plightLeft = lightLeft.transform.GetChild(0).GetComponent<Light2D>();
        plightRight = lightRight.transform.GetChild(0).GetComponent<Light2D>();

        l_bottom = lightBottom.GetComponent<Lights>();
        l_top = _lightTop.GetComponent<Lights>();
        l_right = lightRight.GetComponent<Lights>();
        l_left = lightLeft.GetComponent<Lights>();
    }


    IEnumerator ToggleLightOn(Light2D light){
        if(changingLight) yield return new WaitForEndOfFrame();
        while(light.intensity < fullLight){
            light.intensity += 2f * Time.deltaTime;
            light.intensity = Mathf.Clamp(light.intensity,0,fullLight);
            yield return new WaitForEndOfFrame();
        }
        yield return new WaitForSeconds(1f);
        changingLight = false;
        yield return new WaitForEndOfFrame();
    }
    IEnumerator ToggleLightOff(Light2D light){
        if(changingLight) yield return new WaitForEndOfFrame();
        while(light.intensity > 0){
            light.intensity -= 2f * Time.deltaTime;            
            light.intensity = Mathf.Clamp(light.intensity,0,fullLight);
            yield return new WaitForEndOfFrame();
        }
        yield return new WaitForSeconds(1f);
        changingLight = false;
        yield return new WaitForEndOfFrame();
    }
    public bool changingLight = false;


    void ToggleLights(Vector2 dir){
        if(dir == Vector2.up){

        }
        

    }
    float shootCooldown = 1f;
    float shootTimer = 0;
    void Update()
    {
        if(shootted){
            shootTimer += Time.deltaTime;
        }
        if(shootTimer >= shootCooldown){
            shootted = false;
            shootTimer = 0;
        }

        plightBottom.intensity = _lightBottom.intensity;
        plightTop.intensity = _lightTop.intensity;
        plightLeft.intensity = _lightLeft.intensity;
        plightRight.intensity = _lightRight.intensity;

        pointLight.intensity = Mathf.Clamp((_lightTop.intensity + _lightLeft.intensity + _lightRight.intensity +  _lightBottom.intensity) /2f,0 , 0.19f) ;
    }
    void LateUpdate()
    {
       Vector2 direction = new Vector2(lookTop.position.x - lightTop.transform.position.x, lookTop.position.y - lightTop.transform.position.y);
       lightTop.transform.up = Quaternion.AngleAxis(0, Vector3.forward) * direction;

       direction = new Vector2(lookRight.position.x - lightRight.transform.position.x, lookRight.position.y - lightRight.transform.position.y);
       lightRight.transform.up = Quaternion.AngleAxis(0, Vector3.forward) * direction;

       direction = new Vector2(lookBottom.position.x - lightBottom.transform.position.x, lookBottom.position.y - lightBottom.transform.position.y);
       lightBottom.transform.up = Quaternion.AngleAxis(0, Vector3.forward) * direction;

       direction = new Vector2(lookLeft.position.x - lightLeft.transform.position.x, lookLeft.position.y - lightLeft.transform.position.y);
       lightLeft.transform.up = Quaternion.AngleAxis(0, Vector3.forward) * direction;

       lookAt.position = rg.position + Vector2.ClampMagnitude(rg.velocity, 1.7f);
    }
}
