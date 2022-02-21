using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NaveMove : MonoBehaviour
{
    [SerializeField] float desplSpeed;
    [SerializeField] float rotationSpeed;
    float limiteH = 18f;
    float limiteV = 10f;
    float limiteSuelo = 1f;

    InitGame InitGame;

    AudioSource AudioSource;
    [SerializeField] AudioClip motor;


    [SerializeField] Transform navePos;
    [SerializeField] GameObject Explosion;


    // Start is called before the first frame update
    void Start()
    {
        //Asigno el valor de las variables de mvimiento
        desplSpeed = 20f;
        rotationSpeed = 100f;

        InitGame = GameObject.Find("InitGame").GetComponent<InitGame>();

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
        float posR = transform.position.z;

        if ((posX < limiteH || desplX < 0f) && (posX > -limiteH || desplX > 0f))
        {
            transform.Translate(Vector3.right * Time.deltaTime * desplSpeed * desplX, Space.World);
        }

        if ((posY < limiteV || desplY < 0f) && (posY > limiteSuelo || desplY > 0f))
        {
            transform.Translate(Vector3.up * Time.deltaTime * desplSpeed * desplY, Space.World);
        }
         transform.Rotate(0f, 0f, desplR * Time.deltaTime * -rotationSpeed);
     





    }

    private void OnTriggerEnter(Collider other)
    {
        print("He chocado con" + other.gameObject.layer);
        if(other.gameObject.layer == 6)

        {
            InitGame.spaceshipSpeed = 0f;
            GameObject.Find("Cuerpo").GetComponentInChildren<Renderer>().enabled = false;
            GameObject.Find("Alas").GetComponentInChildren<Renderer>().enabled = false;
            GameObject.Find("ert").GetComponentInChildren<Renderer>().enabled = false;
            InitGame.alive = false;
            Instantiate(Explosion, navePos.position, Quaternion.identity);
            Invoke("GameOver", 2f);



        }
    }
    public void GameOver()
    {
        SceneManager.LoadScene(5);
    }

}
