using UnityEngine;
using System.Collections;

public class RipSelector : ObjSelector
{

    private Canvas currentDashBoard;
    public override void showDashboard(){
        currentDashBoard=(Canvas)Instantiate(dashBoard,Vector3.zero,Quaternion.identity);
    }
    public override void closeDashboard(){
        Destroy(currentDashBoard.gameObject);
    }

    // Use this for initialization
    void Start()
    {
	
    }
	
    // Update is called once per frame
    void Update()
    {
	
    }
}

