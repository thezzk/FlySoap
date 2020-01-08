using UnityEngine;
using System.Collections;
using Acrocatic;

public class DurBlock : MonoBehaviour {
    public float restoreAmount=10f;
    private float toDestroy = -0.1f;
    void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag=="Player"){
            Player player;
            player=other.gameObject.GetComponent<Player>();
            if(player!=null&&toDestroy<0f){
                this.GetComponent<AudioSource>().Play();
                player.restoreDurability(restoreAmount);

                toDestroy = 0.1f;
                
            }
        }
        
    }
    void FixedUpdate()
    {

        if (toDestroy > 0f)
            toDestroy += 0.1f;
        if (toDestroy > 0.6f)
            Destroy(this.gameObject);
    }
	
}
