using UnityEngine;
using System.Collections;

public class RipPanel : MonoBehaviour {
    private GameObject rip;



    public void rotateRip(){
        EditorArrow editorArrow=FindObjectOfType<EditorArrow>();
        rip=editorArrow.objToSet;
        for(int i=0;i<rip.transform.childCount;i++){
            Transform tmp=rip.transform.GetChild(i);
            tmp.Rotate(0f,0f,90f);
    
        }
    }
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
