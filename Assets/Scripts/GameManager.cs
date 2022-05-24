using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using System;
using System.IO;
using UnityEngine.UI;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    public Text trabalenguas;
    LevelManager levelManager;
    public int puntuacionMax;
    public int puntuacion;

    //Other variables
    Color32 orange = new Color32(0xE7, 0x94, 0x47, 0xFF);

    void Awake()
    {
        levelManager = GameObject.Find("LevelManager").GetComponent<LevelManager>();

        if(levelManager.txtIdioma.text == "Español"){
           string[] lines = System.IO.File.ReadAllLines("Assets/Español.txt");
           switch(levelManager.numLvl){
               case 0: trabalenguas.text = lines[levelManager.numLvl]; break;
               case 1: trabalenguas.text = lines[levelManager.numLvl]; break;
               case 2: trabalenguas.text = lines[levelManager.numLvl]; break;
               case 3: trabalenguas.text = lines[levelManager.numLvl]; break;
               case 4: trabalenguas.text = lines[levelManager.numLvl]; break;
               case 5: trabalenguas.text = lines[levelManager.numLvl]; break;
               case 6: trabalenguas.text = lines[levelManager.numLvl]; break;
               case 7: trabalenguas.text = lines[levelManager.numLvl]; break;
               case 8: trabalenguas.text = lines[levelManager.numLvl]; break;
               case 9: trabalenguas.text = lines[levelManager.numLvl]; break;
           }
            
        }
        if(levelManager.txtIdioma.text == "Ingles"){
            string[] lines = System.IO.File.ReadAllLines("Assets/Ingles.txt");
           switch(levelManager.numLvl){
               case 0: trabalenguas.text = lines[levelManager.numLvl]; break;
               case 1: trabalenguas.text = lines[levelManager.numLvl]; break;
               case 2: trabalenguas.text = lines[levelManager.numLvl]; break;
               case 3: trabalenguas.text = lines[levelManager.numLvl]; break;
               case 4: trabalenguas.text = lines[levelManager.numLvl]; break;
               case 5: trabalenguas.text = lines[levelManager.numLvl]; break;
               case 6: trabalenguas.text = lines[levelManager.numLvl]; break;
               case 7: trabalenguas.text = lines[levelManager.numLvl]; break;
               case 8: trabalenguas.text = lines[levelManager.numLvl]; break;
               case 9: trabalenguas.text = lines[levelManager.numLvl]; break;
           }
        }
    }
    

    
}
