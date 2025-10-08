using UnityEngine;

public class CollectiblesPickUp : MonoBehaviour
{



    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("IN Collition");
        if (collision.gameObject.name == "Player")
        {

            Destroy(this.gameObject);

            GameManager.Instance.addScore(1);
        }
    }
}
