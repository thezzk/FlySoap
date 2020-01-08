using UnityEngine;
using System.Collections;

public class CheckPointInfo : MonoBehaviour {


    public int checkPontID=0;
    public float checkPointDurability=100f;

    void Awake(){
        if(FindObjectsOfType<CheckPointInfo>().Length>1)
            Destroy(this.gameObject);
        DontDestroyOnLoad(this.gameObject);
    }

}
