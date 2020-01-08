using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class PlayerMadeLevEvent : MonoBehaviour {

    public void backToWorkShop(){
        SceneManager.LoadScene("WorkShop");
    }

}
