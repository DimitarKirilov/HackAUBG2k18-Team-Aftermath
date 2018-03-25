using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitScene : MonoBehaviour {

    public void ExitToMainMenu()
    {
        SceneManager.LoadScene("Main Menu", LoadSceneMode.Single);
    }

    public void LoadMedievalTown()
    {
        SceneManager.LoadScene("Medieval Town", LoadSceneMode.Single);
    }

    public void LoadArtGallery()
    {
        SceneManager.LoadScene("Art Gallery", LoadSceneMode.Single);
    }

    public void LoadEgyptianCity()
    {
        SceneManager.LoadScene("Egyptian City", LoadSceneMode.Single);
    }

    void Start()
    {

    }
}
