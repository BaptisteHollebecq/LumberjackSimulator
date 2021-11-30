using Parabox.CSG;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class test : MonoBehaviour
{
    public GameObject test1;
    public GameObject test2;

    public void Start()
    {
        // Initialize two new meshes in the scene
/*        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        sphere.transform.localScale = Vector3.one * 1.3f;*/


        //// Perform boolean operation
        Model result = CSG.Subtract(test1, test2);

/*        foreach (var item in result.indices)
        {
            foreach(int i in item)
            {
                Debug.Log(i);
            }
            Debug.Log("NEW LIST");
        }*/

        // // Create a gameObject to render the result
        var composite = new GameObject();
        composite.AddComponent<MeshFilter>().sharedMesh = result.mesh;
        composite.AddComponent<MeshRenderer>().sharedMaterials = result.materials.ToArray();
        composite.AddComponent<MeshCollider>();
        composite.AddComponent<SetVerticesNeighbours>();

    }


}
