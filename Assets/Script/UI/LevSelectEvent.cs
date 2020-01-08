using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LevSelectEvent : MonoBehaviour {
 

    public string mainMenuSceneName;

    public void loadScene(int index){
        SceneManager.LoadScene(index);
    }

    public void backMainMenu(){
        SceneManager.LoadScene(mainMenuSceneName);
    }
}
