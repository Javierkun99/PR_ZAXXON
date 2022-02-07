using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomNumber : MonoBehaviour
{
    float RandomExclude(float excluir, float rango)
    {
        float returnNumber = excluir;

        float numIni = excluir - rango;
        float numFin = excluir + rango;

        while (returnNumber > numIni && returnNumber < numFin)
        {
            returnNumber = Random.Range(0f, 10f);
        }

        return returnNumber;
    }
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        float posX = Random.Range(0f, 10);
        float posX2 = RandomExclude(posX, 2f);
    }
}
