﻿using UnityEngine;
using System.Collections;
// using UnityStandardAssets.ImageEffects;
public class TelescopicView : MonoBehaviour
{
    public float zoom = 2.0f;
    public float speedIn = 100.0f;
    public float speedOut = 100.0f;
    private float initFov;
    private float currFov;
    private float minFov;
    private float addFov;
    // private VignetteAndChromaticAberration v;
    public float vMax = 10.0f;
    void Start()
    {
        initFov = Camera.main.fieldOfView;
        minFov = initFov / zoom;
        // v = this.GetComponent<VignetteAndChromaticAberration>()
        // as VignetteAndChromaticAberration;
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
            ZoomView();
        else
            ZoomOut();
        float currDistance = currFov - initFov;
        float totalDistance = minFov - initFov;
        float vMultiplier = currDistance / totalDistance;
        float vAmount = vMax * vMultiplier;
        vAmount = Mathf.Clamp(vAmount, 0, vMax);
        // v.intensity = vAmount;
    }
    void ZoomView()
    {
        currFov = Camera.main.fieldOfView;
        addFov = speedIn * Time.deltaTime;
        if (Mathf.Abs(currFov - minFov) < 0.5f)
            currFov = minFov;
        else if (currFov - addFov >= minFov)
            currFov -= addFov;
        Camera.main.fieldOfView = currFov;
    }
    void ZoomOut()
    {
        currFov = Camera.main.fieldOfView;
        addFov = speedOut * Time.deltaTime;
        if (Mathf.Abs(currFov - initFov) < 0.5f)
            currFov = initFov;
        else if (currFov + addFov <= initFov)
            currFov += addFov;
        Camera.main.fieldOfView = currFov;
    }
}