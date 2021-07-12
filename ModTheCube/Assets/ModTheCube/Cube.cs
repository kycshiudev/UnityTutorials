using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    public float shiftRate = 5.0f;
    public float scaleMag = 4.0f;
    private int shiftDirection = 1;

    void Start()
    {
        transform.position = new Vector3(3, 4, 1);
        transform.localScale = Vector3.one * 1.3f;

        Material material = Renderer.material;

        material.color = new Color(0.0f, 1.0f, 0.3f, 0.4f);
        InvokeRepeating("FlipColorDirection", shiftRate, shiftRate);
    }
    
    void Update()
    {
        transform.Rotate(10.0f * Time.deltaTime, 0.0f, 0.0f);
        Material material = Renderer.material;
        var rColor = material.color.r;
        rColor += 1/shiftRate * Time.deltaTime * shiftDirection;

        material.color = new Color(rColor, 0.5f, 0.3f, 0.8f);

        transform.localScale = Vector3.one + (Vector3.one * scaleMag * rColor); 
    }

    void FlipColorDirection()
    {
        shiftDirection = shiftDirection * -1;
    }
}
