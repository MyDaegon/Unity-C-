using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moveoffset : MonoBehaviour
{
    private Renderer material;
    float p;
    public float speedX, speedY;
    void Start()
    {
        material = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        p += 0.01f;
        material.material.SetTextureOffset("_MainTex", new Vector2 (speedX * p, speedY *p));
    }
}
