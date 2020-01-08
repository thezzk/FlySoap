using UnityEngine;
using System.Collections;

public class SnowBall : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if(this.transform.position.y<-1000){
            Destroy(this.gameObject);
        }
	
	}
}
