using UnityEngine;
using System.Collections;

public class BeltReviseTrriger : MonoBehaviour {




    public AreaEffector2D areaEffector;
    public SurfaceEffector2D surfaceEffector;
    public float surSpeed;
    public float surForceScale;
    public float areaForceMag;
    public float areaForceAngle;
    public GameObject[] tranBelts;
    public Sprite lightToTrans;
    public SpriteRenderer currentLight;
    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.tag=="Player"){
            if(surfaceEffector!=null){
                surfaceEffector.speed=surSpeed;
                surfaceEffector.forceScale=surForceScale;
            }
            if(areaEffector!=null){
                
                areaEffector.forceMagnitude=areaForceMag;
                areaEffector.forceAngle=areaForceAngle;
            }
            
        }
        foreach(GameObject i in tranBelts){
            Animation[] animations=i.GetComponentsInChildren<Animation>();
            foreach(Animation j in animations){

                j.Play("WheelRotate");

            }

        }
        currentLight.sprite=lightToTrans;
        Destroy(this.gameObject);
    }
}
