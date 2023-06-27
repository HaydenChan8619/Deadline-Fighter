using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 


public class pauseMenuScript : MonoBehaviour
{

    public GameObject pauseMenu;
    public logicScript logic;

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
            Debug.Log("yes");
            if (pauseMenu.activeSelf)
            {
                pauseMenu.SetActive(false);
            } else 
            {
                pauseMenu.SetActive(true);
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

        logic.daysNumber.text = "Days Left: " + logic.days.ToString();
        logic.moneyNumber.text = "Money: " + logic.money.ToString();
        logic.happinessNumber.text = "Happiness: " + logic.happiness.ToString();
        logic.socialNumber.text = "Social: " + logic.social.ToString();

        logic.languageNumber.text = "Language: " + logic.language.ToString();
        logic.mathNumber.text = "Math: " + logic.mathematics.ToString();
        logic.scienceNumber.text = "Science: " + logic.science.ToString();
        logic.humanitiesNumber.text = "Humanities: " + logic.humanities.ToString();

        pauseMenu.SetActive(false);
        
    }
    
}
