using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {

        Transform blade = collision.transform.GetChild(0);
        if (blade.TryGetComponent<Blade>(out Blade b))
        {
            //Debug.Log("Tree : Collision with => " + collision.gameObject.name);
            b.Cut(gameObject);
        }
    }
}
