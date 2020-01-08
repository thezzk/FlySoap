using UnityEngine;
using System.Collections;
using Acrocatic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GamingEvent : MonoBehaviour {

    public Player player;

    public Transform[] checkPoints;

    public Canvas pauseMenu;

    public string levSelSceneName; 

    private CheckPointInfo checkPointInfo;

    public float deathMenuDelayTime; 

    private float currentDeathTime=0f;

    public Canvas deathMenu;

    public Selectable pauseMenuSel;

    public Selectable gameoverMenuSel;



    void Start(){
        checkPointInfo=FindObjectOfType<CheckPointInfo>();
        player.transform.position=checkPoints[checkPointInfo.checkPontID].position;
        player.currentDurability=checkPointInfo.checkPointDurability;
        currentDeathTime=0f;


    }

    void FixedUpdate(){
        if (checkPointInfo == null)
        {
            checkPointInfo = GameObject.FindObjectOfType<CheckPointInfo>();
        }
        if(player==null&&deathMenuDelayTime>currentDeathTime){
            currentDeathTime+=0.1f;
           

        }
        if(deathMenuDelayTime<currentDeathTime&&deathMenuDelayTime+10f>currentDeathTime){
            //Time.timeScale=0f;
            deathMenu.gameObject.SetActive(true);
            gameoverMenuSel.Select();
            currentDeathTime += 100f;

        }
    }
    void Update()
    {
        
        if(checkPoints.Length==0){// Maybe in editor mode
            CheckPoint[] tmp=GameObject.FindObjectsOfType<CheckPoint>();
            checkPoints=new Transform[tmp.Length];
            for(int i=0;i<tmp.Length;i++){
                checkPoints[i]=tmp[i].transform;
            }
            player.transform.position=checkPoints[checkPointInfo.checkPontID].position;
            player.currentDurability=checkPointInfo.checkPointDurability;
            currentDeathTime=0f;
        }

        if (Input.GetButtonUp("Pause"))
        {
            if (Time.timeScale < 0.1f)
            {
                
                continueGame();
                
            }
            else if(player!=null&&player.moveable==true)
            {
                pause();
            }
        }
    }
    public void pause(){
        Time.timeScale=0f;
        pauseMenu.gameObject.SetActive(true);
        pauseMenuSel.Select();
    }

    public void continueGame(){
        Input.ResetInputAxes();
        Time.timeScale=1f;
        pauseMenu.gameObject.SetActive(false);
    }

    public void backToLevSelMenu(){
        Time.timeScale=1f;
        if(checkPointInfo!=null)
            Destroy(checkPointInfo.gameObject);
        SceneManager.LoadScene(levSelSceneName);

    }

    public void backToCheckPoint(){
        Time.timeScale=1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void reTry() {
        Time.timeScale = 1f;
        if (checkPointInfo != null) { 
        checkPointInfo.checkPontID = 0;
        checkPointInfo.checkPointDurability = 100f;
        }
        backToCheckPoint();
    }
}
