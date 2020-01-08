using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class ShowCup : MonoBehaviour {

    public Image cupImage;
    public int levId; 
    void OnEnable(){
        int haveCup=PlayerPrefs.GetInt("Lev"+levId+"Achievement",0);
        if(haveCup==1){
            cupImage.gameObject.SetActive(true);
        }
    }
}
