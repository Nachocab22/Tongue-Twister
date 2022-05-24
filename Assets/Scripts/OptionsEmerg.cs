using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsEmerg : MonoBehaviour
{
    OptionManager optionManager;
    [SerializeField] GameObject dudaEmer;
    [SerializeField] GameObject atClienteEmer;
    [SerializeField] GameObject espanoltxt;
    [SerializeField] GameObject inglestxt;
    float activeTime = 3.0f;
    float timeToDisappear;

    // Start is called before the first frame update
    void Start()
    {
        optionManager = GameObject.Find("OptionManager").GetComponent<OptionManager>();
        dudaEmer.gameObject.SetActive(false);
        atClienteEmer.gameObject.SetActive(false);
        espanoltxt.gameObject.SetActive(false);
        inglestxt.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(espanoltxt.gameObject.activeSelf && Time.time >= timeToDisappear)
            espanoltxt.gameObject.SetActive(false);
        if(inglestxt.gameObject.activeSelf && Time.time >= timeToDisappear)
            inglestxt.gameObject.SetActive(false);
    }

    public void dudaIdiomaOn(){
        dudaEmer.gameObject.SetActive(true);
    }

    public void dudaIdiomaOff(){
        dudaEmer.gameObject.SetActive(false);
    }

    public void atClienteOn(){
        atClienteEmer.gameObject.SetActive(true);
    }

    public void atClienteOff(){
        atClienteEmer.gameObject.SetActive(false);
    }

    public void español(){
        optionManager.idioma = true;
        timeToDisappear = Time.time + activeTime;
        espanoltxt.gameObject.SetActive(true);
    }

    public void ingles(){
        optionManager.idioma = false;
        timeToDisappear = Time.time + activeTime;
        inglestxt.gameObject.SetActive(true);
    }
}
