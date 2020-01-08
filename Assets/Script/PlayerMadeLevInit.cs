using UnityEngine;
using System.Collections;

public class PlayerMadeLevInit : MonoBehaviour {




	// Use this for initialization
	void Start () {
        GameObject.FindObjectOfType<SoapEditorSerialize>().Deserialize();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

}
