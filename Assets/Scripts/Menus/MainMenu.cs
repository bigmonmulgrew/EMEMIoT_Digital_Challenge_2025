using JetBrains.Annotations;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    //[SerializeField] GameObject leaderboardUI;
    public void StartGame()
    {
        LevelManager.LoadFirstLevel();
    }

    public void OpenOptions()
    {
        LevelManager.LoadOptions();
    }

    public void OpenAccount() { LevelManager.LoadAccount(); }
    public void OpenAchievements() { LevelManager.LoadAchievements(); }
    public void OpenBuyTicket() { LevelManager.LoadBuyTicket(); }
    public void OpenPlanJourney() {  LevelManager.LoadPlanJourney(); }
    
    //public void ToggleLeaderboard()
    //{
    //    leaderboardUI.SetActive(!leaderboardUI.activeSelf);

    //    if (leaderboardUI.activeSelf) 
    //    {
    //        LeaderboardManager.Instance.GetScores();
    //    }
    //    else
    //    {
    //        leaderboardUI.GetComponent<LeaderboardUI>().ClearLeaderboard();
    //    }
    //}
}
