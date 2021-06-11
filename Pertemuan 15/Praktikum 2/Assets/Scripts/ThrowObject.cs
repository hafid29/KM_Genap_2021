﻿using UnityEngine;
using System.Collections;

public class ThrowObject : MonoBehaviour
{
    public GameObject prop;
    private GameObject proj;
    public Vector3 posOffset;
    public Vector3 force;
    public Transform hand;
    public float compensationYAngle = 0f;

    public void Prepare()
    {
        proj = Instantiate(prop, hand.position, hand.rotation) as GameObject;
        if (proj.GetComponent<Rigidbody>())
            Destroy(proj.GetComponent<Rigidbody>());
        proj.GetComponent<SphereCollider>().enabled = false;
        proj.name = "projectile";
        proj.transform.parent = hand;
        proj.transform.localPosition = posOffset;
        proj.transform.localEulerAngles = Vector3.zero;
    }

    public void Throw()
    {
        Vector3 dir = transform.rotation.eulerAngles;       
        dir.y += compensationYAngle;       
        proj.transform.rotation = Quaternion.Euler(dir);        
        proj.transform.parent = null;       
        proj.GetComponent<SphereCollider>().enabled = true;        
        Rigidbody rig = proj.AddComponent<Rigidbody>();       
        rig.collisionDetectionMode = CollisionDetectionMode.ContinuousDynamic;       
        Collider propCollider = proj.GetComponent<Collider>();       
        Collider col = GetComponent<Collider>();        
        Physics.IgnoreCollision(propCollider, col);
        rig.AddRelativeForce(force);
    }
}
