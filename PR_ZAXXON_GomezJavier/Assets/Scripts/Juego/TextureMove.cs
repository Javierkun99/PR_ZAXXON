using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextureMove : MonoBehaviour
{

    [SerializeField] Material mat;
    [SerializeField] float speed;
    // Start is called before the first frame update
    void Start()
    {
        speed = 0;

    }

    // Update is called once per frame
    void Update()
    {
        speed += 0.0005f;
        mat.SetFloat("Vector1_79bc9be061d24c85b07e9cd32099b3b0", speed);
    }
}
