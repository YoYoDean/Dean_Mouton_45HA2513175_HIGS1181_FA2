using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class GameManager : MonoBehaviour
{

    //daclaring variables
    public static GameManager Instance;
    public TextMeshProUGUI scoreText;
    public GameObject winScreenGui;
    public int playerScore = 0;


    private void Awake()//setting instance of Manager
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
        playerScore += GridManager.totalCollectibles;       //getting totalcollectibles from gridmanager
        Debug.Log(playerScore);
        string strScore = playerScore + " Collectibles Remaining";      //making string variable for textmesh
        scoreText.text = strScore;                      //setting text in ui
        winScreenGui.SetActive(false);              //set screen to off for winscreen

    }

    void Update()
    {
        if (playerScore <= 0) {
            ShowWinScreen();        //if all collectibles are collected run win method
        }
    }


    public void addScore(int score)
    {
        playerScore -= score;   //decreasing score because it was picked up
        Debug.Log(playerScore + " Collectibles remaining");
        string strScore = playerScore + " Collectibles Remaining";     //setting string
        scoreText.text = strScore;       //showing ui score

    }
    public void ShowWinScreen()
    {
            winScreenGui.SetActive(true); //setting winscreen active to show
            
            Time.timeScale = 0; //Game done , freezing time
        
    }
}
