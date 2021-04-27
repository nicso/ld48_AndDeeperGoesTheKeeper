using UnityEngine;
//using System.Collections;
using UnityEditor;
[CustomEditor(typeof(PolygonModelerCustom))]
public class PolygonModelerEditor : Editor
{

    public override void OnInspectorGUI()
    {
        PolygonModelerCustom modeler = (PolygonModelerCustom)target;
        modeler.UpdateMesh();
        if (GUILayout.Button("build shadow"))
        {
            modeler.buildShadow();
        }
        DrawDefaultInspector();
    }
    
    void Update()
    {

    }
}
