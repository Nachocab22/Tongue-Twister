using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEditor;

public class OptionManager : MonoBehaviour
{
    public bool idioma; //Si es true es Español si es false es Ingles
    private static OptionManager _instance;
    public GameObject optionManager; 
    
    // Start is called before the first frame update
    void Awake() {

        idioma = true;
        if(!_instance)
            _instance = this;
        else
            this.gameObject.SetActive(false);
            
        GameObject.DontDestroyOnLoad(optionManager);
    }
}
