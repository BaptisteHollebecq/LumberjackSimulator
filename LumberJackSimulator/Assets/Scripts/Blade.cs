using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Parabox.CSG;

public class Blade : MonoBehaviour
{
    public GameObject BladeShape;
    public Transform Test;

    public LayerMask TreeMask;

    private void Start()
    {
  
    }

    private void Update()
    {
        if (Physics.Raycast(Test.transform.position + Test.transform.forward * 10, -Test.transform.forward, 10, TreeMask))
        {
            Debug.DrawRay(Test.transform.position, Test.transform.forward * 10, Color.red);
        }
        else
            Debug.DrawRay(Test.transform.position, Test.transform.forward * 10, Color.green);


    }

    public void Cut(GameObject obj)
    {
        Debug.Log("Cut");

        Model result = CSG.Subtract(obj, BladeShape);

        // Create a gameObject to render the result
        var composite = new GameObject();

        composite.AddComponent<MeshFilter>().sharedMesh = result.mesh;
        composite.AddComponent<MeshRenderer>().sharedMaterials = result.materials.ToArray();
        composite.AddComponent<MeshCollider>();
        //composite.gameObject.layer = TreeMask;

        composite.layer = LayerMask.NameToLayer("Tree");

        Destroy(obj);
        composite.AddComponent<Tree>();
    }
}
