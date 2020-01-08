using UnityEngine;
using System.Collections;
using Acrocatic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityStandardAssets.CrossPlatformInput;
public class LevelComplete : MonoBehaviour {

    public string nextLevName;
    public Canvas levCompleteUI;
    public Image cupImage;
    public Player player;
    public Text scoreText;
    
    public int levId;
    public int achievementScore;
    public Selectable levCompleteMenuSel;

    private bool levCompleted=false;
    private int playerScore=0;
    private bool afterScoreShow=false;

    void Start(){
        levCompleted=false;
        afterScoreShow=false;
        playerScore=0;
    }

    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.tag=="Player"){
            levCompleted=true;
            PlayerPrefs.SetInt("Lev"+levId+"Complete",1);
            levCompleteUI.gameObject.SetActive(true);
            levCompleteMenuSel.Select();
            player.moveable = false;
            Destroy(GameObject.FindObjectOfType<CheckPointInfo>().gameObject);
           
        }
    }

    void FixedUpdate(){
        if(levCompleted){
            if(player.currentDurability>0.51f){
             
               
                player.currentDurability-=0.5f;
                playerScore+=5;
                scoreText.text="Score:"+playerScore;
            }
            else if(afterScoreShow==false){
                int highScore=PlayerPrefs.GetInt("Lev"+levId+"HighScore",0);
                if(highScore<playerScore){
                    PlayerPrefs.SetInt("Lev"+levId+"HighScore",playerScore);
                }
                if(playerScore>=achievementScore){
                    PlayerPrefs.SetInt("Lev"+levId+"Achievement",1);
                    cupImage.gameObject.SetActive(true);
                }

                player.GetComponent<PlayerJump>().enabled=false;
                player.GetComponent<PlayerRun>().enabled=false;
                player.GetComponent<Player>().enabled=false;
                afterScoreShow=true;
            }
          
        }
       
    }

    void OnGUI(){
        if(levCompleted&&!afterScoreShow){
#if !MOBILE_INPUT
            Input.ResetInputAxes();
#endif
#if MOBILE_INPUT
            CrossPlatformInputManager.UnRegisterVirtualAxis("Horizontal");
            CrossPlatformInputManager.UnRegisterVirtualButton("Jump");
#endif
        }
    }

    public void loadNextLevel(){
        SceneManager.LoadScene(nextLevName);
    }
}
