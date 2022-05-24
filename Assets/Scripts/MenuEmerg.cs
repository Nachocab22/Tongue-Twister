using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuEmerg : MonoBehaviour
{
    [SerializeField] GameObject tutEmerg;
    // Start is called before the first frame update
    void Start()
    {
        tutEmerg.gameObject.SetActive(false);
    }

    public void tutorialOn(){
        tutEmerg.gameObject.SetActive(true);
    }

    public void tutorialOff(){
        tutEmerg.gameObject.SetActive(false);
    }
}
