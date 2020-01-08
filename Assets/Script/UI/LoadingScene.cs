using UnityEngine;
using System.Collections;

public class LoadingScene : MonoBehaviour {
    AsyncOperation async;
    // Use this for initialization
    void Start () {
        StartCoroutine(loadScene());
    }
	
	// Update is called once per frame
	void Update () {
        Debug.Log("Peocess" + async.progress);
	
	}
    IEnumerator loadScene()
    {
      
        async = Application.LoadLevelAsync(AsynLevLoad.levId);
        yield return async;

    }
}








