using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTransform : MonoBehaviour
{
    public Transform targetTrans;
    public Vector3 offset;
    public bool copyRotation = false;

    private void Update()
    {
        transform.position = targetTrans.position + offset;

        if (copyRotation)
            transform.rotation = targetTrans.rotation;
    }
}