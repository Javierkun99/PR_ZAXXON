using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitGame : MonoBehaviour
{

    public float spaceshipSpeed= 20f;
    // Start is called before the first frame update
    void Start()
    {
        spaceshipSpeed = 20f;
    }

    // Update is called once per frame
    void Update()
    {
        spaceshipSpeed += 0.001f;
    }
}
