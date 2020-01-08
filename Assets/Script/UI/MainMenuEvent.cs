using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class MainMenuEvent : MonoBehaviour {

    public Canvas optionMenu;
    public Canvas achieveMenu;
    public string selLevName;
    public Text soundSwitchText;
    public Selectable mainSel;
    public Selectable optionSel;
    public Selectable achieveSel;



    public void showOptionMenu(){
        optionMenu.gameObject.SetActive(true);
        optionSel.Select();
    }
    public void closeOptionMenu(){
        optionMenu.gameObject.SetActive(false);
        mainSel.Select();
    }
    public void showAchieveMenu(){
        achieveMenu.gameObject.SetActive(true);
        achieveSel.Select();
    }
    public void closeAchieveMenu(){
        achieveMenu.gameObject.SetActive(false);
        mainSel.Select();
    }
    public void startGame(){
        SceneManager.LoadScene(selLevName);
    }
    public void workShop(){
        SceneManager.LoadScene("WorkShop");
    }
    public void turnAudioSwith(){
        AudioListenerCtrl audioListenerCtrl=FindObjectOfType<AudioListenerCtrl>();
        if(audioListenerCtrl!=null){
            if(audioListenerCtrl.GetComponent<AudioListener>().enabled==true){
                audioListenerCtrl.GetComponent<AudioListener>().enabled=false;
                soundSwitchText.text="Sound:Off";
                PlayerPrefs.SetInt("SoundOption",0);
            }
            else{
                audioListenerCtrl.GetComponent<AudioListener>().enabled=true;
                soundSwitchText.text="Sound:On";
                PlayerPrefs.SetInt("SoundOption",1);
            }
        }


    }

    void Start(){
        AudioListenerCtrl audioListenerCtrl=FindObjectOfType<AudioListenerCtrl>();
        if(audioListenerCtrl!=null){
            if(audioListenerCtrl.GetComponent<AudioListener>().enabled==true){
                soundSwitchText.text="Sound:On";
            }
            else{
                soundSwitchText.text="Sound:Off";
            }
        }
    }


}
