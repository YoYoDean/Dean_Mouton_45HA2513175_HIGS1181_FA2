using UnityEngine;

public class CollectiblesPickUp : MonoBehaviour
{



    void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.name == "Player") //Seeing if player has collided
        {
            Debug.Log("Collected a Collectible");
            Destroy(this.gameObject);                   //Removing collectible if collided

            GameManager.Instance.addScore(1);       // adding 1 to score , acctually subtracting one 
        }
    }
}
