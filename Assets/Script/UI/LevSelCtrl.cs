using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class LevSelCtrl : MonoBehaviour {


    public Scrollbar scrollbar;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if(Input.GetAxis("Vertical")>0.01f){
            scrollbar.value+=0.03f;
        }
        if(Input.GetAxis("Vertical")<-0.01f){
            scrollbar.value-=0.03f;
        }

	
	}
}
