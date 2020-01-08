using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class ObjSelector : MonoBehaviour {

    public GameObject obj;
    public EditorArrow editorArrow;
    public Canvas dashBoard;
   
    // Use this for initialization


    public void selectObj(){
        EditorManager em=GameObject.FindObjectOfType<EditorManager>();
        if(em.currentSelector!=null)
            em.currentSelector.closeDashboard();
        em.currentSelector=this;
        showDashboard();
        editorArrow.ChangeObjToSet(obj);
    }
    public virtual void showDashboard(){
    }
    public virtual void closeDashboard(){
    }

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
