using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testCollision : MonoBehaviour
{
    public float divider = 100;
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("name " + collision.gameObject.name);
        Debug.Log("total count " + collision.contactCount);
        Debug.Log("impulse " + collision.impulse);

    }

    void Update()
    {
        Mesh mesh = GetComponent<MeshFilter>().mesh;
        Vector3[] vertices = mesh.vertices;
        Vector3[] normals = mesh.normals;

        for (var i = 0; i < vertices.Length; i++)
        {
            vertices[i] += normals[i] * (Mathf.Sin(Time.time)/ divider);
        }

        mesh.vertices = vertices;
    }
}
