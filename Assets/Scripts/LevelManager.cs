using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public Text numNivel;
    public Text txtIdioma;
    OptionManager optionManager;
    float tiempo;
    public Text txtTiempo;
    public int numLvl;
    public GameObject levelManager;
    
    void Awake() 
    {
        optionManager =  GameObject.Find("OptionManager").GetComponent<OptionManager>();
        
        if(optionManager.idioma == true)
            txtIdioma.text = "Español";
        else
            txtIdioma.text = "Ingles";
        
        numNivel.text = (numLvl+1).ToString();
        tiempo = 5.5f;
    }

    void Update() {
        if(SceneManager.GetActiveScene().Equals(SceneManager.GetSceneByName("PreGame"))){
            tiempo -= Time.deltaTime;
            txtTiempo.text = ((int)tiempo).ToString();        
            if(tiempo < 1.001){
                if(numLvl == 0)
                    GameObject.DontDestroyOnLoad(levelManager);
                else
                    GameObject.Destroy(levelManager);
                SceneManager.LoadScene("MainGame", LoadSceneMode.Single);
            }
        }
    }

    /*public void nextLevel()
    {
        numLvl++;
        SceneManager.LoadScene("PreGame", LoadSceneMode.Single);
    }*/
}
