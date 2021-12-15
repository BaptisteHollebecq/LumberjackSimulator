using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent<Blade>(out Blade b))
        {
            Debug.Log("Tree : Collision with => " + collision.gameObject.name);
            b.Cut(gameObject);
        }
    }
}
