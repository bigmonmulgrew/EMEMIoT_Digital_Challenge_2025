using JetBrains.Annotations;
using UnityEngine;

public class PlayJourneyMenu : MonoBehaviour
{
    [SerializeField] GameObject skipButton;
    [SerializeField] GameObject[] hideableObjects;

    int currentItem = 0;
    public void SkipTutorial()
    {
        if(currentItem >= hideableObjects.Length )
        {
            skipButton.SetActive(false);
            return;
        }

        hideableObjects[currentItem].SetActive(true);
        currentItem++;
    }

    private void Start()
    {
        if (hideableObjects.Length == 0)  return;
        foreach (GameObject go in hideableObjects)
        {
            go.SetActive(false);
            
        }
    }

    private void Update()
    {
        if(Input.GetKeyUp(KeyCode.Backspace)) LevelManager.LoadMainMenu();
    }

    public void OpenOptions()
    {
        LevelManager.LoadOptions();
    }

    public void OpenAccount() { LevelManager.LoadAccount(); }
    public void OpenAchievements() { LevelManager.LoadAchievements(); }
    public void OpenBuyTicket() { LevelManager.LoadBuyTicket(); }
    public void OpenPlanJourney() {  LevelManager.LoadPlanJourney(); }
    
}
