using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterSelection : MonoBehaviour
{

    private int selectionIndex = 0;

    public List<GameObject> characters;


    // Use this for initialization
    void Start()
    {
        characters = new List<GameObject>();
        foreach (Transform t in transform)
        {
            characters.Add(t.gameObject);
        }

        foreach (GameObject ship in characters)
        {
            ship.SetActive(false);
        }
        nextCharacter();
    }

    public void nextCharacter()
    {
        characters[selectionIndex].SetActive(false);
        selectionIndex++;

        if (selectionIndex >= characters.Count)
        {
            selectionIndex = 0;
        }
        characters[selectionIndex].SetActive(true);
        PlayerPrefs.SetInt("CaracterSelectat", selectionIndex);
       // GameControl.instance.setCharacter(characters[selectionIndex]);
    }

    public void previousCharacter()
    {
        characters[selectionIndex].SetActive(false);
        selectionIndex--;
        if (selectionIndex < 0)
        {
            selectionIndex = characters.Count - 1;
        }

        characters[selectionIndex].SetActive(true);
        PlayerPrefs.SetInt("CaracterSelectat", selectionIndex);
        // GameControl.instance.setCharacter(characters[selectionIndex]);
    }

    public void StartJoc()
    {
        SceneManager.LoadScene(1);
    }
}
