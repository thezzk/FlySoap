using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class PlayMov : MonoBehaviour {
    public MovieTexture movTexture;



	void Start () {
        #if !UNITY_STANDALONE
        Handheld.PlayFullScreenMovie ("SoapMov.mov", Color.black, FullScreenMovieControlMode.CancelOnInput);
        SceneManager.LoadScene("MainMenu");
        #endif
        #if UNITY_STANDALONE
        GetComponent<Renderer>().material.mainTexture = movTexture;
        movTexture.loop = false;
        movTexture.Play();
        #endif
	}
    void Update(){
        #if UNITY_STANDALONE
        if(Input.anyKeyDown||!movTexture.isPlaying){
            SceneManager.LoadScene("MainMenu");
        }
        #endif


    }

}
