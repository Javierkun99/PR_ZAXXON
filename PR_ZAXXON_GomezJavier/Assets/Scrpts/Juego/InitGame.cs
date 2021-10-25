using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitGame : MonoBehaviour
{
    public bool alive;
    public float spaceshipSpeed= 30f;
    public float spaceshipMoveSpeed = 30f;

    public float obstacleDistance = 30f;

    [SerializeField] TextAlignment speedText;
    // Start is called before the first frame update
    void Start()
    {
        spaceshipSpeed = 30f;
    }

    // Update is called once per frame
    void Update()
    {
        spaceshipSpeed += 0.001f;
        float veloc = (spaceshipSpeed * 3600) / 1000;
    }
}
