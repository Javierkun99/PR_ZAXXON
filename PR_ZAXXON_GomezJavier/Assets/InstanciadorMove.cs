using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciadorMove : MonoBehaviour
{
    float intervalo;
    [SerializeField] GameObject columna;
    [SerializeField] Transform instatiatePosition;
    // Start is called before the first frame update
    void Start()
    {
        intervalo = 1f;
        StartCoroutine("CrearColumna");
    }

    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator CrearColumna()
    {
        while (true)
        {
            print("Hola");

            Instantiate(columna);

            yield return new WaitForSeconds(intervalo);
        }
    }
}
