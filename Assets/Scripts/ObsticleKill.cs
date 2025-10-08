using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObsticleKill : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene("Dean GAme");
            
        }
    }
}
