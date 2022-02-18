using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciadorNew : MonoBehaviour
{
    float intervalo;
    [SerializeField] GameObject[] terreno;
    [SerializeField]
    InitGame initGame;
    int tereno = 6;

    // Start is called before the first frame update
    void Start()
    {
        initGame = GameObject.Find("InitGame").GetComponent<InitGame>();


    }


    // Update is called once per frame
    void Update()
    {

    }
    

    public void CrearTerrenos()
    {
        print("Crear Terreno");
    }
}
