using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnaMove : MonoBehaviour
{
    float speed;
    float intervalo;
    // Start is called before the first frame update
    void Start()
    {
        speed = 10f;
        intervalo = 1f;

        StartCoroutine("Corrutina");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.back * Time.deltaTime * speed);
    }

    IEnumerator CrearColumna()
    {
        while(true)
        {
            print("Hola");
            yield return new WaitForSeconds(intervalo);
        }
    }
}
