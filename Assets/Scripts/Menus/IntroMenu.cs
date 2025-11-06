using JetBrains.Annotations;
using UnityEngine;

public class IntroMenu : MonoBehaviour
{
    //[SerializeField] GameObject leaderboardUI;
    
    public void OpenOptions()
    {
        LevelManager.LoadOptions();
    }
    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Backspace)) LevelManager.LoadMainMenu();
    }

    public void OpenAccount() { LevelManager.LoadAccount(); }
    public void OpenAchievements() { LevelManager.LoadAchievements(); }
    public void OpenBuyTicket() { LevelManager.LoadBuyTicket(); }
    public void OpenPlanJourney() {  LevelManager.LoadPlanJourney(); }
    public void Skip() { LevelManager.LoadMainMenu(); }
    
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
