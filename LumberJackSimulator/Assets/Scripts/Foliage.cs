using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Foliage : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Ground")
        {
            Destroy(transform.parent.gameObject, .1f);
        }
    }
}
