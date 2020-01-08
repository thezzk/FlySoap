using UnityEngine;
using System.Collections;

public class FxCreator : MonoBehaviour {

    public GameObject fxObject;
    public void OnEnable(){
        GameObject.Instantiate(fxObject,this.transform.position,Quaternion.identity);
    }
}
