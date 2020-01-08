using UnityEngine;
using System.Collections;

public class SnowSpawn : MonoBehaviour {

    public float skipTime =10f;
    public GameObject snowBall;

    private float waitTime;
    void FixedUpdate(){
        if(waitTime<0.01f){
            Instantiate(snowBall,this.transform.position,Quaternion.identity);
            waitTime=skipTime;
        }
        waitTime-=0.1f;
        
    }
}
