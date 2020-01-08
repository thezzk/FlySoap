using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class LevEnterButton : MonoBehaviour {

    public int levId;
	void Start () {
        if(PlayerPrefs.GetInt("Lev"+levId+"Complete",0)!=1){
            this.GetComponent<Button>().interactable=false;
        }
    }
	
	
}
