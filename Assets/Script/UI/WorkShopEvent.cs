using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class WorkShopEvent : MonoBehaviour {
    
    public InputField createField;
    public InputField playField;
    public Canvas createPlane;
    public Canvas playPlane;

    public const string BUFF_PREF_SUFFIX="-generator-prefs";
    public const string BUFF_FILE_SUFFIX="-generator-files";
    public const string PREF_BUFF_KEY="PrefBuff";
    public const string FILE_BUFF_KEY="FileBuff";
    public void showCreatePlane(){
        createPlane.gameObject.SetActive(true);
    }
    public void showPlayPlane(){
        playPlane.gameObject.SetActive(true);
    }
    public void closeCreatePlane(){
        createPlane.gameObject.SetActive(false);
    }
    public void closePlayPlane(){
        playPlane.gameObject.SetActive(false);
    }
    public void goCrate(){
        string tmp=createField.text;
        if(tmp==""){
            return;
        }

        PlayerPrefs.SetString(PREF_BUFF_KEY,tmp+BUFF_PREF_SUFFIX);
        PlayerPrefs.SetString(FILE_BUFF_KEY,tmp+BUFF_FILE_SUFFIX);
        SceneManager.LoadScene("EditorLevel");

    }
    public void goPlay(){
        string tmp=playField.text;
        if(tmp==""){
            return;
        }
        PlayerPrefs.SetString(PREF_BUFF_KEY,tmp+BUFF_PREF_SUFFIX);
        PlayerPrefs.SetString(FILE_BUFF_KEY,tmp+BUFF_FILE_SUFFIX);
        SceneManager.LoadScene("testLoad");
    }


    public void backToMainMenu(){
        SceneManager.LoadScene("MainMenu");
    }

    // Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
