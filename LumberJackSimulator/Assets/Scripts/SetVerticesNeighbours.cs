using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetVerticesNeighbours : MonoBehaviour
{
    Mesh mesh;

    private void Awake()
    {
        mesh = GetComponent<MeshFilter>().mesh;

        Debug.Log(mesh.subMeshCount);
    }
}
