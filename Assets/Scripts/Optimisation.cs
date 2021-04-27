using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Optimisation : MonoBehaviour
{
    public PolygonModelerCustom[] objects;
    public GameObject[] o;
    void Start()
    {
        objects = GameObject.FindObjectsOfType<PolygonModelerCustom>();

        o= new GameObject[objects.Length];
        int i =0;
        foreach (PolygonModelerCustom poly in objects)
        {
            o[i] = poly.gameObject;
            i++;
            
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        foreach (GameObject obj in o)
        {
            if(Vector3.Distance( obj.transform.position, transform.position) > 50f){
                obj.SetActive(false);
            }else{
                obj.SetActive(true);
            }
        }
    }
}
