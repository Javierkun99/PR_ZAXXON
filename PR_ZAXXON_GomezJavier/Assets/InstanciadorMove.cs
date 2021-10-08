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
        StartCoroutine("CrearColumna");
        StartCoroutine("CrearColumna");
        StartCoroutine("CrearColumna");
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
            float randomX = Random.Range(-12f, 12f);
            Vector3 newPos = new Vector3(randomX, instatiatePosition.position.y, instatiatePosition.position.z);
            Instantiate(columna,newPos,Quaternion.identity);
            yield return new WaitForSeconds(intervalo);
           
        }
    }

}
