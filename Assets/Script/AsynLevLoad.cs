using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class AsynLevLoad {
    public static int levId;

    public static void asynLoad(int id)
    {
        levId = id;
        SceneManager.LoadScene("LoadingScene");
    }
    public static void asynLoad(string levName)
    {
        levId = SceneManager.GetSceneByName(levName).buildIndex;
        SceneManager.LoadScene("LoadingScene");
    }
    
}
