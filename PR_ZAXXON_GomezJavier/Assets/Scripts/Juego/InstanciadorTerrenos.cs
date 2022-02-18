using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciadorTerrenos : MonoBehaviour
{

    [SerializeField] GameObject terrenosPrefab;
    Transform initPos;
    // Start is called before the first frame update
    void Start()
    {
        //initPos = gameObject
        //CrearTerrenos()
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   public void CrearTerrenos()
    {
        print("Crear Terreno");
        Vector3 pos = new Vector3(0f, 0f, 190f);
        Instantiate(terrenosPrefab, pos, Quaternion.identity);
    }
}
