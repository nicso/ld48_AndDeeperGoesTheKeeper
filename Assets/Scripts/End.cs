using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class End : MonoBehaviour
{
    public PlayerMovements playerMovements;
    public LightsManager lightsManager;
    public GameObject player;
    public Lights light;
  
    void OnTriggerEnter2D(Collider2D other)
    {
        playerMovements.enabled = lightsManager.enabled = false;
        StartCoroutine(Quit());
        //light.Toggle_On();
    }

    IEnumerator Quit(){

        yield return new WaitForSeconds(25f);
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif

    }
}
