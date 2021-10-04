using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnaMove : MonoBehaviour
{
    float speed;
    [SerializeField] GameObject initObject;
    InitGame initGame;

    // Start is called before the first frame update
    void Start()
    {
        initObject = GameObject.Find("InitGame");
        initGame = initObject.transform.GetComponent<InitGame>();
        speed = initGame.spaceshipSpeed;
       
    }

    // Update is called once per frame
    void Update()
    {
        speed = initGame.spaceshipSpeed;
        transform.Translate(Vector3.back * Time.deltaTime * speed);
    }

}
