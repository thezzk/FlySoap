using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class CheckPointPanel : MonoBehaviour {
    private CheckPoint checkPoint;
    public InputField inputField;
	// Use this for initialization


    public void setCheckPointId(){
        EditorArrow editorArrow=FindObjectOfType<EditorArrow>();
        checkPoint=editorArrow.objToSet.GetComponent<CheckPoint>();
        if(checkPoint!=null)
            checkPoint.checkPointId = int.Parse(inputField.text);
        
    }

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
