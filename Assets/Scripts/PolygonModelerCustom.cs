using UnityEngine;
using System.Collections;
using UnityEngine.Experimental.Rendering.Universal;
[RequireComponent( typeof( PolygonCollider2D ) )]
[RequireComponent( typeof( MeshFilter ) )]
[RequireComponent( typeof( MeshRenderer ) )]
public class PolygonModelerCustom : MonoBehaviour
{

    public bool snap = false;
    public float xOffset =0;
    public float yOffset =-1;
    public float depth = 1;

    public PolygonCollider2D _collider;
    public Vector2[] _points;

    public Vector3[] newVertices;
    public Vector2[] newUV;
    public int[] newTriangles;

    public bool shadowCaster = false;
    public float shadowOffset = 1;
    public GameObject shadow;



    public void UpdateMesh()
    {
        _collider = gameObject.GetComponent<PolygonCollider2D>();
        _points = new Vector2[_collider.points.Length];

        newVertices = new Vector3[_collider.points.Length];


        for (int i = 0; i < _collider.points.Length; i++)
        {
            if (snap)
            {
                _points[i] = new Vector2(Mathf.Round(_collider.points[i].x), Mathf.Round(_collider.points[i].y));
            }
            else _points[i] = new Vector2(_collider.points[i].x, _collider.points[i].y);

            newVertices[i] = new Vector3(_points[i].x, _points[i].y, 0);
        }



        BuildMesh();
        _collider.points = _points;
    }
    public void buildShadow()
    {
        ShadowCaster2DFromCollider ShadowCaster2DFromCollider;
        if(gameObject.GetComponent<ShadowCaster2DFromCollider>() == null) ShadowCaster2DFromCollider = gameObject.AddComponent<ShadowCaster2DFromCollider>();
        else ShadowCaster2DFromCollider = GetComponent<ShadowCaster2DFromCollider>();

        ShadowCaster2DFromCollider.ManualUpdate();
        
    }


    static Mesh CreateMesh(Vector2[] poly ,float yO,float xO,float depth)
    {
        // convert polygon to triangles
        Triangulator triangulator = new Triangulator(poly);
        int[] tris = triangulator.Triangulate();
        Mesh m = new Mesh();
        Vector3[] vertices = new Vector3[poly.Length*2];

        for ( int i = 0 ; i < poly.Length ; i++ )
        {
            vertices[ i ].x = poly[ i ].x;
            vertices[ i ].y = poly[ i ].y;
            vertices[ i ].z = 0; // front vertex
            vertices[ i + poly.Length ].x = poly[ i ].x + xO;
            vertices[ i + poly.Length ].y = poly[ i ].y + yO ;
            vertices[ i + poly.Length ].z = depth;  // back vertex    
        }
        int[] triangles = new int[tris.Length*2+poly.Length*6];
        int count_tris = 0;
        for ( int i = 0 ; i < tris.Length ; i += 3 )
        {
            triangles[ i ] = tris[ i ];
            triangles[ i + 1 ] = tris[ i + 1 ];
            triangles[ i + 2 ] = tris[ i + 2 ];
        } // front vertices
        count_tris += tris.Length;
        for ( int i = 0 ; i < tris.Length ; i += 3 )
        {
            triangles[ count_tris + i ] = tris[ i + 2 ] + poly.Length;
            triangles[ count_tris + i + 1 ] = tris[ i + 1 ] + poly.Length;
            triangles[ count_tris + i + 2 ] = tris[ i ] + poly.Length;
        } // back vertices
        count_tris += tris.Length;
        for ( int i = 0 ; i < poly.Length ; i++ )
        {
            // triangles around the perimeter of the object
            int n = (i+1)%poly.Length;
            triangles[ count_tris ] = i;
            triangles[ count_tris + 1 ] = n;
            triangles[ count_tris + 2 ] = i + poly.Length;
            triangles[ count_tris + 3 ] = n;
            triangles[ count_tris + 4 ] = n + poly.Length;
            triangles[ count_tris + 5 ] = i + poly.Length;
            count_tris += 6;
        }
        m.vertices = vertices;
        m.triangles = triangles;
        m.RecalculateNormals();
        m.RecalculateBounds();
        ;
        return m;
    }


    public void RoundingPositions()
    {
        
        _collider.points = _points;
    }

    public void PlaceGameobjects()
    {
        GameObject[] objects = new GameObject[_points.Length];
        
        for ( int i = 0 ; i < objects.Length ; i++ )
        {
            GameObject go = new GameObject();
            go.name = ("("+ i.ToString() +")" );
            go.transform.position = _points[ i ];
           
            //objects[ i ] = Instantiate( go, _points[ i ] , Quaternion.identity ) as GameObject;
            
        }
    }
    public void Gameobjects()
    {
        GameObject[] objects = new GameObject[_points.Length];

        for ( int i = 0 ; i < objects.Length ; i++ )
        {
            GameObject go = new GameObject();
            go.name = ( "(" + i.ToString() + ")" );
            go.transform.position = _points[ i ];

            //objects[ i ] = Instantiate( go, _points[ i ] , Quaternion.identity ) as GameObject;

        }
    }

    public void BuildMesh()
    {

        Mesh mesh = new Mesh();

        mesh.vertices = newVertices;
        mesh.uv = newUV;

        Triangulator tr = new Triangulator(_points);
        int[] indices = tr.Triangulate();
        newTriangles = indices;

        mesh.triangles = indices;

        mesh.RecalculateNormals();
        mesh.RecalculateBounds();

        GetComponent<MeshFilter>().mesh = mesh;
    }


}
