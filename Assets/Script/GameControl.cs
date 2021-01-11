using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameControl : MonoBehaviour
{

    public static GameControl instance;

    public GameObject caracter;

    public int caracterSelectatIndex = 0;

    private void Awake()
    {
        if(instance == null)
        {
            DontDestroyOnLoad(gameObject);
            instance = this;
        }
        else if(instance != this)
        {
            Destroy(gameObject);
        }
    }
    
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void setCharacter(GameObject player)
    {
        Destroy(caracter);
        caracter = Instantiate(caracter);
        caracter.SetActive(false);
    }

    public void setCharacterIndex(int selectedShipIndex)
    {
        this.caracterSelectatIndex = caracterSelectatIndex;
    }    

}
