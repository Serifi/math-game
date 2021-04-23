using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroll : MonoBehaviour
{
    public float scrollSpeed = 0.25f;
    private MeshRenderer _meshRenderer;
    public GameObject cntrlr;

    private void Awake()
    {
        _meshRenderer = GetComponent<MeshRenderer>();
    }

    void Update()
    {
        Scrolll();
    }

    void Scrolll()
    {
        Controller controller = cntrlr.GetComponent<Controller>();
        if (controller.isStarted)
        {
            Vector2 offset = _meshRenderer.sharedMaterial.GetTextureOffset("_MainTex");
            offset.y -= Time.deltaTime * scrollSpeed;
            _meshRenderer.sharedMaterial.SetTextureOffset("_MainTex", offset);
        }
    }
}