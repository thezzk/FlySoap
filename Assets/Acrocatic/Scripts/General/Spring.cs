using System.Collections;
using UnityEngine;
namespace Acrocatic
{
    public class Spring: MonoBehaviour
    {
       
        private Player player;  
        // Check if the player is entering the trigger.
        void OnTriggerEnter2D(Collider2D other) {
            if (other.gameObject.tag == "Player" ) {
                // Make sure the player is dead.
                Debug.Log("Spring");
                player=(Player)other.gameObject.GetComponent<Player>();
                player.rigidbody.AddForce(new Vector2(0f, 1000f));
            }
        }
         


    }
}

