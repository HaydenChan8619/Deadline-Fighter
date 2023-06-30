using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 


public class pauseMenuScript : MonoBehaviour
{

    public GameObject pauseMenu;
    public logicScript logic;
    public buttonPopUpScript buttonPopUpSystem;

    // Start is called before the first frame update
    void Start()
    {
        pauseMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (pauseMenu.activeSelf)
            {
                pauseMenu.SetActive(false);
                buttonPopUpSystem.buttonEnable();
                
            } else 
            {
                pauseMenu.SetActive(true);
                buttonPopUpSystem.buttonDisable();
            }
            
        }
    }

    public void closeGame()
    {
        Application.Quit();
    }


    public void restartGame()
    {
        logic.days = 100;
        logic.money = 100;
        logic.happiness = 100;
        logic.social = 100;

        logic.language = 0;
        logic.mathematics = 0;
        logic.science = 0;
        logic.humanities = 0;

        logic.disneyCount = 0;
        logic.studyCount = 0;
        logic.studyGroupCount = 0;
        logic.bowlingCount = 0;
        logic.cashierCount = 0;
        logic.tutorCount = 0;
        logic.hikingCount = 0;

        logic.daysNumber.text = "Days Left: " + logic.days.ToString();
        logic.moneyNumber.text = "Money: " + logic.money.ToString();
        logic.happinessNumber.text = "Happiness: " + logic.happiness.ToString();
        logic.socialNumber.text = "Social: " + logic.social.ToString();

        logic.languageNumber.text = "Language: " + logic.language.ToString();
        logic.mathNumber.text = "Math: " + logic.mathematics.ToString();
        logic.scienceNumber.text = "Science: " + logic.science.ToString();
        logic.humanitiesNumber.text = "Humanities: " + logic.humanities.ToString();

        pauseMenu.SetActive(false);
        buttonPopUpSystem.gameActive = true;
        buttonPopUpSystem.buttonEnable();
        
    }
    
}
