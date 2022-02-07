using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inicio : MonoBehaviour
{

    [SerializeField] Text volumenText;
   
    // Start is called before the first frame update
    void Start()
    {
        volumenText.text = "Volumen:" +ConfigVars.musicVolume;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
