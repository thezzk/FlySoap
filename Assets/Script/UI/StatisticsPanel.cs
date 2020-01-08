using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class StatisticsPanel : MonoBehaviour {

    public Text statisText;
    void OnEnable(){
        int deathTime=PlayerPrefs.GetInt("DeathTime",0);
        statisText.text="Death Time:"+deathTime;
        
    }
}
