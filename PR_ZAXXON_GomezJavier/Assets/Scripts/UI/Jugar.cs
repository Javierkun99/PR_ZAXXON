using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Jugar : MonoBehaviour
{
    public void Juego()
    {
        SceneManager.LoadScene("Juego");
        print("A Jugar");
    }
}
