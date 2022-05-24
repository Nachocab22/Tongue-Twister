using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    GameManager gameManager;
    LevelManager levelManager;

    //DECLARACION ESTRELLAS//
    [SerializeField] GameObject Star1on;
    [SerializeField] GameObject Star2on;
    [SerializeField] GameObject Star3on;
    [SerializeField] GameObject Star1off;
    [SerializeField] GameObject Star2off;
    [SerializeField] GameObject Star3off;
    //FIN ESTRELLAS//

    [SerializeField] Text txtPuntuacion;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        levelManager = GameObject.Find("LevelManager").GetComponent<LevelManager>();

        if(gameManager.puntuacion == 0){ //Ninguna estrella
            Star1on.gameObject.SetActive(false);
            Star2on.gameObject.SetActive(false);
            Star3on.gameObject.SetActive(false);
            Star1off.gameObject.SetActive(true);
            Star2off.gameObject.SetActive(true);
            Star3off.gameObject.SetActive(true);
        }
        else if(gameManager.puntuacion < (gameManager.puntuacionMax*40)/100){ //Una estrella
            Star1on.gameObject.SetActive(true);
            Star2on.gameObject.SetActive(false);
            Star3on.gameObject.SetActive(false);
            Star1off.gameObject.SetActive(false);
            Star2off.gameObject.SetActive(true);
            Star3off.gameObject.SetActive(true);
        }
        else if(gameManager.puntuacion < (gameManager.puntuacionMax*85)/100){ //Dos estrellas
            Star1on.gameObject.SetActive(true);
            Star2on.gameObject.SetActive(true);
            Star3on.gameObject.SetActive(false);
            Star1off.gameObject.SetActive(false);
            Star2off.gameObject.SetActive(false);
            Star3off.gameObject.SetActive(true);
        }
        else{
            Star1on.gameObject.SetActive(true);
            Star2on.gameObject.SetActive(true);
            Star3on.gameObject.SetActive(true);
            Star1off.gameObject.SetActive(false);
            Star2off.gameObject.SetActive(false);
            Star3off.gameObject.SetActive(false);
        }
    }

    public void Reintentar(){
        SceneManager.LoadScene("PreGame");
    }

    public void Siguiente(){
        levelManager.numLvl++;
        SceneManager.LoadScene("PreGame");
    }
    
}
