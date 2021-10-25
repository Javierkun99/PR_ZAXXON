using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PruebasInstanciar : MonoBehaviour
{
    [SerializeField] GameObject a;
    [SerializeField] Transform b;

    float desplX = 1.1f;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 destPos = b.position;
        Vector3 despl = new Vector3(desplX, 0, 0);
        for (int n = 0; n < 10; n++)
        {
            Instantiate(a, destPos, Quaternion.identity);
            destPos = destPos + despl;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
