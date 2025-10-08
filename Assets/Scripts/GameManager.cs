using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    
    public int playerScore = 0;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
        
    }
    void Start()
    {
        playerScore += GridManager.totalCollectibles;
        Debug.Log(playerScore);
    }


    public void addScore(int score)
    {
        playerScore -= score;
        Debug.Log(playerScore + " Collectibles remaining");
    }
}
