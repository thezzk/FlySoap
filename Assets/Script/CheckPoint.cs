using UnityEngine;
using System.Collections;
using Acrocatic;
public class CheckPoint : MonoBehaviour {
    public int checkPointId;
    public Sprite LightOn;
    public Sprite LightOff;
    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.tag=="Player"){
            CheckPointInfo checkPointInfo;
            checkPointInfo=FindObjectOfType<CheckPointInfo>();
            checkPointInfo.checkPointDurability=other.gameObject.GetComponent<Player>().currentDurability;
            checkPointInfo.checkPontID=checkPointId; 
            this.GetComponent<SpriteRenderer>().sprite=LightOn;
        }
        Debug.Log("check point!");
    }
    void OnTriggerExit2D(Collider2D other){
        if(other.gameObject.tag=="Player"){
            this.GetComponent<SpriteRenderer>().sprite=LightOff;
        }
    
    }
}
