using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NaveMove : MonoBehaviour
{
    [SerializeField] float desplSpeed;
    [SerializeField] float rotationSpeed;
    float limiteH = 18f;
    float limiteV = 10f;
    float limiteSuelo = 1f;
    // Start is called before the first frame update
    void Start()
    {
        //Asigno el valor de las variables de mvimiento
        desplSpeed = 20f;
        rotationSpeed = 100f;
    }

    // Update is called once per frame
    void Update()
    {
        //IMPORTANTE: el método Update tiene que estar vacío
        MoverNave();
     
    }

    
    void MoverNave()
    {
      
        float desplX = Input.GetAxis("Horizontal");
        float desplY = Input.GetAxis("Vertical");
        float desplR = Input.GetAxis("69");

        float posX = transform.position.x;
        float posY = transform.position.y;

        if ((posX < limiteH || desplX < 0f) && (posX > -limiteH || desplX > 0f))
        {
            transform.Translate(Vector3.right * Time.deltaTime * desplSpeed * desplX, Space.World);
        }

        if ((posY < limiteV || desplY < 0f) && (posY > limiteSuelo || desplY > 0f))
        {
            transform.Translate(Vector3.up * Time.deltaTime * desplSpeed * desplY, Space.World);
        }
        // transform.Rotate(0f, 0f, desplR * Time.deltaTime * -rotationSpeed);





    }


}
