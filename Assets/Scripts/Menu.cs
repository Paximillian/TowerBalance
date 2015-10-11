using UnityEngine;
using System.Collections;
using GooglePlayGames;
using GooglePlayGames.BasicApi;
using UnityEngine.SocialPlatforms;

public class Menu : MonoBehaviour
{
    private const string k_GameScene = "TowerBuildingStage";
    private const string k_CreditsScene = "Credits";
    private const string k_MainMenuScene = "MainMenu";

    // Use this for initialization
    void Start()
    {
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void StartGame()
    {
        Application.LoadLevel(k_GameScene);
    }
    
    public void HighScores()
    {
        if(!Social.localUser.authenticated)
        {
            PlayGamesClientConfiguration config = new PlayGamesClientConfiguration.Builder().Build();
            PlayGamesPlatform.InitializeInstance(config);
            PlayGamesPlatform.Activate();

            Social.localUser.Authenticate((success) =>
            {
                if(success)
                {
                    Social.ReportScore(PlayerPrefs.GetInt("HighScore", 0), "CgkIrsrB6OwBEAIQAA", (s) => { });
                    Social.ShowLeaderboardUI();
                }
            });
        }
        else
        {
            Social.ReportScore(PlayerPrefs.GetInt("HighScore", 0), "CgkIrsrB6OwBEAIQAA", (s) => { });
            Social.ShowLeaderboardUI();
        }
    }

    public void Credits()
    {
        Application.LoadLevel(k_CreditsScene);
    }

    public void MainMenu()
    {
        Application.LoadLevel(k_MainMenuScene);
    }
}
