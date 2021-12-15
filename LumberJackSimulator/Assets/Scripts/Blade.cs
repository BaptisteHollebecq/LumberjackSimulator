using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Parabox.CSG;
using EzySlice;

public class Blade : MonoBehaviour
{
    public GameObject BladeShape;
    public Transform Test;
    public GameObject plan;

    public LayerMask TreeMask;

    bool canCut = true;
    Transform Foliage = null;

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
        if (canCut)
        {
            canCut = false;

            if (obj.transform.childCount != 0)
            {
                Foliage = obj.transform.GetChild(0);
                Foliage.SetParent(null);
            }

            StartCoroutine(ResetCut());
            Model result = CSG.Subtract(obj, BladeShape);

            // Create a gameObject to render the result
            var composite = new GameObject();

            composite.AddComponent<MeshFilter>().sharedMesh = result.mesh;
            composite.AddComponent<MeshRenderer>().sharedMaterials = result.materials.ToArray();
            composite.AddComponent<MeshCollider>();

            composite.layer = LayerMask.NameToLayer("Tree");

            composite.AddComponent<Tree>();

            if (Foliage != null)
                Foliage.SetParent(composite.transform);

            Destroy(obj);

            StartCoroutine(CheckIfCut(composite));
        }
    }

    IEnumerator CheckIfCut(GameObject obj)
    {

        yield return new WaitForEndOfFrame();

        Collider[] touched = Physics.OverlapBox(plan.transform.position, plan.GetComponent<BoxCollider>().bounds.extents, Quaternion.identity, TreeMask);

        if (touched.Length == 0)
        {

            SlicedHull hull = obj.Slice(plan.transform.position, plan.transform.up);
            if (hull != null)
            {
                Transform Foliage = obj.transform.GetChild(0);
                Foliage.SetParent(null);

                GameObject bot = hull.CreateLowerHull(obj, null);
                MeshCollider col = bot.AddComponent<MeshCollider>();
                col.convex = true;
                bot.GetComponent<MeshFilter>().mesh.Optimize();

                GameObject top = hull.CreateUpperHull(obj, null);
                top.layer = LayerMask.NameToLayer("Tree");
                Rigidbody rb = top.AddComponent<Rigidbody>();
                rb.useGravity = true;
                rb.mass = 1000;
                MeshCollider coltop = top.AddComponent<MeshCollider>();
                coltop.convex = true;

                Foliage.SetParent(top.transform);

                Destroy(obj, .1f);
            }
        }
    }

    IEnumerator ResetCut()
    {
        yield return new WaitForSeconds(.2f);
        canCut = true;
    }
}
