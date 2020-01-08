using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class CheckPointSelector : ObjSelector{


    private Canvas currentDashBoard;
    public override void showDashboard(){
        Debug.Log("show dashboard");
        currentDashBoard=(Canvas)Instantiate(dashBoard,Vector3.zero,Quaternion.identity);
    }
    public override void closeDashboard(){
        Destroy(currentDashBoard.gameObject);
       

    }

	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
	    
	}
}
