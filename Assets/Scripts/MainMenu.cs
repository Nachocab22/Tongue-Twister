using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEditor;
using UnityEngine;

public class MainMenu : MonoBehaviour
{

    public void empezar(){
        SceneManager.LoadSceneAsync("PreGame");
    }

    public void atras(){
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
    }

    public void opciones(){
        SceneManager.LoadScene("Opciones", LoadSceneMode.Single);
    }

    public void salir(){
        Debug.Log("Salir del juego");
        Application.Quit();
    }
}
