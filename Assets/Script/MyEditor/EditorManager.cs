using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class EditorManager : MonoBehaviour {

    public ObjSelector currentSelector;
    public GameObject[,] blockMap=new GameObject[500,500];

    public void backToWorkShop(){
        SceneManager.LoadScene("WorkShop");
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
