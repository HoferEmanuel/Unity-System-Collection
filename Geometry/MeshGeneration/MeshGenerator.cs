using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshGenerator : MonoBehaviour
{
    public MeshFilter meshFilter;

    private void Start()
    {
        GenerateTriangle();
    }    

    private void GenerateTriangle()
    {
        Mesh mesh = new Mesh();

        Vector3[] verts = new Vevtor3{
            new Vector3(0, 0, 0),
            new Vector3(-1, 1, 0),
            new Vector3(1, 1, 0)
        };
        
        mesh.vertices = verts;

        Vector2[] uv = new Vector2{
            new Vector2(0.5f, 0),
            new Vector2(0, 1),
            new Vector2(1, 1)
        };
        
        mesh.uv = uv;

        Vector3[] normals = new [] {
            // pointing normal at (0,0,-1) i.e perpendicular to triangle we will be creating
            // flipping normals gives incorrect lighting
            -Vector3.forward,
            -Vector3.forward,
            -Vector3.forward,
        };
        
        mesh.normals = normals;

        int[] triangles = new int{
            0,1,2
        };

        mesh.triangles = triangles;

        meshFilter.mesh = mesh;
    }

    private void GenerateQuad()
    {
        Mesh mesh = new Mesh();

        Vector3[] verts = new Vector3{
            new Vector3(0, 0, 0),
            new Vector3(1, 0, 0),
            new Vector3(1, -1, 0),
            new Vector3(-1, -1, 0)
        } 

        mesh.vertices = verts;
    }
}