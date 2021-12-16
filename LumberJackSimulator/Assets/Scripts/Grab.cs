using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class Grab : MonoBehaviour
{
    [SerializeField]
    private InputActionReference m_ActionReference;

    public InputActionReference actionReference { get => m_ActionReference; set => m_ActionReference = value; }

    public LayerMask GrabLayer;

    bool grab = false;
    Rigidbody inHand;

    private void Awake()
    {
        actionReference.action.Enable();
    }

    private void Update()
    {
        if (actionReference != null && actionReference.action != null)
        {
            float value = actionReference.action.ReadValue<float>();
            if (value > .99f)
                grab = true;
            else
                grab = false;
        }
    }

    private void FixedUpdate()
    {
        if (!grab)
        {
            Collider[] colliders = Physics.OverlapSphere(transform.position, .05f, GrabLayer);
            if (colliders.Length > 0)
                inHand = colliders[0].transform.GetComponent<Rigidbody>();
            else
                inHand = null;
        }
        else
        {
            if (inHand != null)
            {
                inHand.velocity = (transform.position - inHand.transform.position) / Time.fixedDeltaTime;

                inHand.maxAngularVelocity = 20;
                Quaternion deltaRot = transform.rotation * Quaternion.Inverse(inHand.transform.rotation);
                Vector3 eulerRot = new Vector3(Mathf.DeltaAngle(0, deltaRot.eulerAngles.x),
                                                                Mathf.DeltaAngle(0, deltaRot.eulerAngles.y),
                                                                Mathf.DeltaAngle(0, deltaRot.eulerAngles.z));
                eulerRot *= .95f;
                eulerRot *= Mathf.Deg2Rad;
                inHand.angularVelocity = eulerRot / Time.fixedDeltaTime;
            }
        }
    }


}
