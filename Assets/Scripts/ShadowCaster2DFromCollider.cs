using System.Reflection;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

/// <summary>
/// unitytips: ShadowCaster2DFromCollider Component
/// http://diegogiacomelli.com.br/unitytips-shadowcaster2-from-collider-component
/// <remarks>
/// Based on https://forum.unity.com/threads/can-2d-shadow-caster-use-current-sprite-silhouette.861256/
/// </remarks>
/// </summary>
[RequireComponent(typeof(ShadowCaster2D))]
[DefaultExecutionOrder(100)]
public class ShadowCaster2DFromCollider : MonoBehaviour
{

    static readonly FieldInfo _meshField;
    static readonly FieldInfo _shapePathField;
    static readonly MethodInfo _generateShadowMeshMethod;

    ShadowCaster2D _shadowCaster;

    EdgeCollider2D _edgeCollider;
    PolygonCollider2D _polygonCollider;

    static ShadowCaster2DFromCollider()
    {
        _meshField = typeof(ShadowCaster2D).GetField("m_Mesh", BindingFlags.NonPublic | BindingFlags.Instance);
        _shapePathField = typeof(ShadowCaster2D).GetField("m_ShapePath", BindingFlags.NonPublic | BindingFlags.Instance);

        _generateShadowMeshMethod = typeof(ShadowCaster2D)
                                    .Assembly
                                    .GetType("UnityEngine.Experimental.Rendering.Universal.ShadowUtility")
                                    .GetMethod("GenerateShadowMesh", BindingFlags.Public | BindingFlags.Static);
    }

    private void OnEnable()
    {
        _shadowCaster = GetComponent<ShadowCaster2D>();
        _edgeCollider = GetComponent<EdgeCollider2D>();

        if (_edgeCollider == null)
            _polygonCollider = GetComponent<PolygonCollider2D>();

        UpdateShadow();
    }
    public void ManualUpdate(){
        _shadowCaster = GetComponent<ShadowCaster2D>();
        _edgeCollider = GetComponent<EdgeCollider2D>();

        if (_edgeCollider == null)
            _polygonCollider = GetComponent<PolygonCollider2D>();
        _shadowCaster.selfShadows = true;
        transform.position = new Vector3(transform.position.x,transform.position.y,0);
        UpdateShadow(); 
    }
    public void UpdateShadow()
    {
        var points = _polygonCollider == null
            ? _edgeCollider.points
            : _polygonCollider.points;

        _shapePathField.SetValue(_shadowCaster, Convert2to3(points) );
        _meshField.SetValue(_shadowCaster, new Mesh());
        _generateShadowMeshMethod.Invoke(_shadowCaster, new object[] { _meshField.GetValue(_shadowCaster), _shapePathField.GetValue(_shadowCaster) });
    }

     Vector3[] Convert2to3(Vector2[] vector2s)
    {
        Vector3[] result = new Vector3[vector2s.Length];
        for(int i = 0; i < vector2s.Length; i++)
            result[i] = vector2s[i];
        return result;
    }
    
}