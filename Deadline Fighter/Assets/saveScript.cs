using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class saveScript : MonoBehaviour
{
    public GameObject pauseMenu;

    public logicScript logic; 
    public buttonPopUpScript buttonPopUpSystem;



    int daysSave;
    int moneySave;
    int happinessSave;
    int socialSave;

    int languageSave;
    int mathematicsSave;
    int scienceSave;
    int humanitiesSave;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void saveButton()
    {
        /*
        daysSave = logic.days;
        moneySave = logic.money;
        happinessSave = logic.happiness;
        socialSave = logic.social;

        languageSave = logic.language;
        mathematicsSave = logic.mathematics;
        scienceSave = logic.science;
        humanitiesSave = logic.humanities;
        */

        PlayerPrefs.SetInt("Days",logic.days);
        PlayerPrefs.SetInt("Money",logic.money);
        PlayerPrefs.SetInt("Happiness",logic.happiness);
        PlayerPrefs.SetInt("Social",logic.social);

        PlayerPrefs.SetInt("Language",logic.language);
        PlayerPrefs.SetInt("Math",logic.mathematics);
        PlayerPrefs.SetInt("Science",logic.science);
        PlayerPrefs.SetInt("Humanities",logic.humanities);

        PlayerPrefs.SetInt("Disney",logic.disneyCount);
        PlayerPrefs.SetInt("Study",logic.studyCount);
        PlayerPrefs.SetInt("StudyGroup",logic.studyGroupCount);
        PlayerPrefs.SetInt("Bowling",logic.bowlingCount);
        PlayerPrefs.SetInt("Cashier",logic.cashierCount);
        PlayerPrefs.SetInt("Tutor",logic.tutorCount);
        PlayerPrefs.SetInt("Hiking",logic.hikingCount);
        buttonPopUpSystem.buttonEnable();
        pauseMenu.SetActive(false);


    }

    public void loadButton()
    {
        logic.days = PlayerPrefs.GetInt("Days", 100);
        logic.money = PlayerPrefs.GetInt("Money", 100);
        logic.happiness = PlayerPrefs.GetInt("Happiness", 100);
        logic.social = PlayerPrefs.GetInt("Social", 100);
        
        logic.language = PlayerPrefs.GetInt("Language", 0);
        logic.mathematics = PlayerPrefs.GetInt("Math", 0);
        logic.science = PlayerPrefs.GetInt("Science", 0);
        logic.humanities = PlayerPrefs.GetInt("Humanities", 0);


        logic.disneyCount = PlayerPrefs.GetInt("Disney",0);
        logic.studyCount = PlayerPrefs.GetInt("Study",0);
        logic.studyGroupCount = PlayerPrefs.GetInt("StudyGroup",0);
        logic.bowlingCount = PlayerPrefs.GetInt("Bowling",0);
        logic.cashierCount = PlayerPrefs.GetInt("Cashier",0);
        logic.tutorCount = PlayerPrefs.GetInt("Tutor",0);
        logic.hikingCount = PlayerPrefs.GetInt("Hiking",0);

        logic.daysNumber.text = "Days Left: " + logic.days.ToString();
        logic.moneyNumber.text = "Money: " + logic.money.ToString();
        logic.happinessNumber.text = "Happiness: " + logic.happiness.ToString() + "%";
        logic.socialNumber.text = "Social: " + logic.social.ToString() + "%";

        logic.languageNumber.text = "Language: " + logic.language.ToString() + "%";
        logic.mathNumber.text = "Math: " + logic.mathematics.ToString() + "%";
        logic.scienceNumber.text = "Science: " + logic.science.ToString() + "%";
        logic.humanitiesNumber.text = "Humanities: " + logic.humanities.ToString() + "%";

        buttonPopUpSystem.buttonEnable();
        pauseMenu.SetActive(false);
    }
}
