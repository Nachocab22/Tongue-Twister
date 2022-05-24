using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    private AudioSource audioSource;
    private static MusicManager _instance;
    
    private void Awake(){

        if(!_instance)
            _instance = this;
        else
            this.gameObject.SetActive(false);

        DontDestroyOnLoad(this.gameObject);
        audioSource = GetComponent<AudioSource>();
    }
    
    public void PlayMusic(){
        if(!_instance.audioSource.isPlaying)
            _instance.audioSource.Play();
    }

    public void StopMusic(){
        _instance.audioSource.Stop();
    }

    public void Volumen(float volumen){
        _instance.audioSource.volume = volumen;
    }
}
