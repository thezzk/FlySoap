using UnityEngine;
using System.Collections;
using Acrocatic;
public class AudioListenerCtrl : MonoBehaviour {

    private float waitTime=0f;
    private Player myPlayer = null;
    void Awake(){
        DontDestroyOnLoad(this.gameObject);
        myPlayer = null;
    }
    void Start(){
        if(FindObjectsOfType<AudioListenerCtrl>().Length>1){
            Destroy(this.gameObject);
        }
        int soundOption=PlayerPrefs.GetInt("SoundOption",1);
        if(soundOption==1){
            GetComponent<AudioListener>().enabled=true;
        }
        else{
            GetComponent<AudioListener>().enabled=false;
        }
    }
    void Update()
    {
        if(myPlayer==null)
            waitTime += 0.05f;
        if (waitTime > 5f&& myPlayer==null)
        {
            
            myPlayer = FindObjectOfType<Player>();
            
            waitTime = 0f;
        }
        if (myPlayer != null)
        {

            this.gameObject.transform.position = myPlayer.transform.position;
        }
    }
}
