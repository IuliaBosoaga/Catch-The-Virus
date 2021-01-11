using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollectBoxes : MonoBehaviour
{

    private CharacterControll run;
    
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Box")
        {
            run = gameObject.GetComponent<CharacterControll>();
            run.inainte = 0f;
            Destroy(other.gameObject);
            SetPuzzle();
        }
    }

    void SetPuzzle()
    {
        SceneManager.LoadScene(2);
    }
}
