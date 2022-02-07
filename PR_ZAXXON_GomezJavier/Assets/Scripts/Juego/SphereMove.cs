using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMove : MonoBehaviour
{
    float speed;
    InitGame initGame;

    // Start is called before the first frame update
    void Start()
    {
        initGame = GameObject.Find("InitGame").GetComponent<InitGame>();

        speed = initGame.spaceshipSpeed;

        Quaternion Finter;
    }

    // Update is called once per frame
    void Update()
    {
        speed = initGame.spaceshipSpeed;
        transform.Translate(Vector3.back * Time.deltaTime * speed);

        float posZ = transform.position.z;
        if (posZ < -20)
        {
            Destroy(gameObject);
        }
    }
}
