using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciadorMove : MonoBehaviour
{
    float intervalo;
    [SerializeField] GameObject[] obstaculos;
    [SerializeField] 
    InitGame initGame;
    int columna =6;

    // Start is called before the first frame update
    void Start()
    {
        initGame = GameObject.Find("InitGame").GetComponent<InitGame>();
        intervalo = 4;
        StartCoroutine("CrearColumna");
        
        for (int n = 0; n < columna; n++) ;
    }
    

    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator CrearColumna()
    {
        float speed;
        while (true)
        {
            speed = initGame.spaceshipSpeed;
            print(intervalo);
          
            float randomX = Random.Range(-12f, 12f);
            Vector3 newPos = new Vector3(randomX, transform.position.y,transform.position.z);

            //Genero número aleatorio para elegir obstaculo
            int numAl = Random.Range(0, obstaculos.Length);
            Instantiate(obstaculos[numAl], newPos, Quaternion.identity);


            /*
            if(numAl == 0)

            {

            //Instantiate(columna, newPos, Quaternion.identity);

            }
            else
            {
               //Instantiate(pared, newPos, Quaternion.identity);
            }

            */

            yield return new WaitForSeconds(intervalo);

        }

       
    }
}
