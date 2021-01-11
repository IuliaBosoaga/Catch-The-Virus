using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Caracter : MonoBehaviour
{
    public List<GameObject> characters;

    public GameObject caracterPlayer;
    // Start is called before the first frame update
    void Awake  ()
    {
        int caracterSelectat = PlayerPrefs.GetInt("CaracterSelectat");

        Debug.Log(caracterSelectat);
        switch(caracterSelectat)
        {
            case 0:
                caracterPlayer = Instantiate(characters[0]);
            break;

            case 1:
                caracterPlayer = Instantiate(characters[1]);
            break;

            case 2:
                caracterPlayer = Instantiate(characters[2]);
            break;

            case 3:
                caracterPlayer = Instantiate(characters[3]);
            break;

            case 4:
                caracterPlayer = Instantiate(characters[4]);
            break;

            case 5:
                caracterPlayer = Instantiate(characters[5]);
            break;

            //default:
             //   caracterPlayer = Instantiate(characters[0]);
              //  break;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
