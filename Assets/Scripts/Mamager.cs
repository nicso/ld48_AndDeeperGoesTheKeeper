using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;
using UnityEngine.Rendering.Universal;

public class Mamager : MonoBehaviour
{
    public Vector3 respawnPoint = Vector3.zero;
    public Transform player;
    PlayerMovements playerMovements;
    LightsManager lightsManager;
    public Camera mainCam;
    public Camera mapCam;
    public bool drawMap = false;

    public Renderer2DData ultraPipe,normalPipe,lowPipe;
    public UniversalRenderPipelineAsset pipelineAsset;
    public enum Quality {
        low, normal, ultra
    };
    public Quality quality;

    public AudioClip treeGrow;
    public AudioClip rollingStone;
    public ParticleSystem plankton;
    public GameObject[] objsToOptimise;
    void Start()
    {
        playerMovements = player.GetComponent<PlayerMovements>();   
        lightsManager = player.GetComponent<LightsManager>(); 
        
        
    }

    public void ChangeQuality(int q){
        var main = plankton.main;
        switch (q)
        {
            case 0: 
                pipelineAsset.renderScale = 1f;
                mainCam.GetComponent<UnityEngine.Rendering.Universal.UniversalAdditionalCameraData>().SetRenderer(0);
                mapCam.GetComponent<UnityEngine.Rendering.Universal.UniversalAdditionalCameraData>().SetRenderer(0);                
                main.maxParticles = 2000;
                foreach (GameObject o in objsToOptimise)
                {
                    o.SetActive(false);
                }
                break;
            case 1: 
                pipelineAsset.renderScale = 1f;
                mainCam.GetComponent<UnityEngine.Rendering.Universal.UniversalAdditionalCameraData>().SetRenderer(1);
                mapCam.GetComponent<UnityEngine.Rendering.Universal.UniversalAdditionalCameraData>().SetRenderer(1);                
                main.maxParticles = 10000;
                foreach (GameObject o in objsToOptimise)
                {
                    o.SetActive(true);
                }
                break;
            case 2:
                pipelineAsset.renderScale = 1f;
                mainCam.GetComponent<UnityEngine.Rendering.Universal.UniversalAdditionalCameraData>().SetRenderer(2);
                mapCam.GetComponent<UnityEngine.Rendering.Universal.UniversalAdditionalCameraData>().SetRenderer(2);                
                main.maxParticles = 20000;
                foreach (GameObject o in objsToOptimise)
                {
                    o.SetActive(true);
                }
                break;
            default:
            break;
        }
    }

    
    void Update()
    {
        
        if(drawMap){
            Time.timeScale = 0f;
            mapCam.gameObject.SetActive(true);
            mainCam.gameObject.SetActive(false);
        }else   
        {
            Time.timeScale = 1f;
            mainCam.gameObject.SetActive(true);
            mapCam.gameObject.SetActive(false);
        }
    }

    public void SetRespawnPoint(){
        respawnPoint = player.position;
    }

    public void Respawn(){
        StartCoroutine(RespawnRoutine());
    }

    public void ToggleMap(){
        drawMap = !drawMap;
    }

    IEnumerator RespawnRoutine(){
        playerMovements.enabled = lightsManager.enabled = player.GetComponent<Rigidbody2D>().simulated = false;
        
        yield return new WaitForSeconds(.5f);
        while (Vector3.Distance(player.position, respawnPoint) > 0.2f){

            player.Translate((respawnPoint - player.position) * Time.deltaTime);
            yield return new WaitForEndOfFrame();
        }

        playerMovements.enabled = lightsManager.enabled = player.GetComponent<Rigidbody2D>().simulated = true;
        yield return new WaitForEndOfFrame();
    }
}
