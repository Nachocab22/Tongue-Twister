using TextSpeech;
using UnityEngine.Android;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using UnityEngine.SceneManagement;


public class VoiceManager : MonoBehaviour {
    
    [SerializeField] Text erText;
    LevelManager levelManager;
    GameManager gameManager;
    public Button start;
    public Button stop;
    [SerializeField] GameObject Camaleon;

    //SpeechToText variables
    const string LANG_CODE_ES = "es-ES";
    const string LANG_CODE_EN = "en-GB";

    

    void Start() {

        levelManager = GameObject.Find("LevelManager").GetComponent<LevelManager>();
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();

        if(levelManager.txtIdioma.text == "Español"){
            Setup(LANG_CODE_ES);
            SpeechToText.instance.onResultCallback = OnFinalSpeechResultEs;
        }
        if(levelManager.txtIdioma.text == "Ingles"){
            Setup(LANG_CODE_EN);
            SpeechToText.instance.onResultCallback = OnFinalSpeechResultEn;
        }

        CheckPermission();
        stop.image.gameObject.SetActive(false);
    }

    void CheckPermission(){
#if UNITY_ANDROID
        if(!Permission.HasUserAuthorizedPermission(Permission.Microphone))
            Permission.RequestUserPermission(Permission.Microphone);
#endif
    }

    void Setup(string code){
        SpeechToText.instance.Setting(code);
    }

    #region Speech to Text
        public void StartListening(){
            SpeechToText.instance.StartRecording();
            start.image.gameObject.SetActive(false);
            stop.image.gameObject.SetActive(true);
            Camaleon.SetActive(true);
        }

        public void StopListening(){
            SpeechToText.instance.StopRecording();
            start.image.gameObject.SetActive(true);
            stop.image.gameObject.SetActive(false);
            Camaleon.SetActive(false);
            SceneManager.LoadScene("PostGame");
        }
        
        void OnFinalSpeechResultEs(string result){
            //Codigo con las comprobaciones para la puntuacion
            string[] lines = System.IO.File.ReadAllLines("Assets/Español.txt");
            string frase = lines[levelManager.numLvl];
            char[] f1 = result.ToCharArray();
            char[] f2 = frase.ToCharArray();
            gameManager.puntuacionMax = frase.Length * 10;
            if(result.Length == frase.Length){
                for(int i=0; i < result.Length; i++){
                    if(f2[i] == f1[i])
                        gameManager.puntuacion += 10;
                }
            }
        }

        void OnFinalSpeechResultEn(string result){
            //Codigo con las comprobaciones para la puntuacion
            string[] lines = System.IO.File.ReadAllLines("Assets/Ingles.txt");
            string frase = lines[levelManager.numLvl];
            char[] f1 = result.ToCharArray();
            char[] f2 = frase.ToCharArray();
            gameManager.puntuacionMax = frase.Length * 10;
            if(result.Length == frase.Length){
                for(int i=0; i < result.Length; i++){
                    if(f2[i] == f1[i])
                        gameManager.puntuacion += 10;
                }
            }
        }

        
    #endregion
}