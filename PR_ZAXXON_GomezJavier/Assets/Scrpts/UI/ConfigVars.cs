using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ConfigVars : MonoBehaviour
{
    public static float musicVolume = 50f;
    public static int numLives;
     public static int difficulty;

    // Start is called before the first frame update
    void Start()
    {
        musicVolume = 50f;
    }

    // Update is called once per frame
    void Update()
    {
        musicVolume += 1;
        print(musicVolume);

        if (Input.GetKeyDown("space"))
        {
            SceneManager.LoadScene(0);
        }
    }
}
