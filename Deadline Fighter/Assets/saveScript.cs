using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class saveScript : MonoBehaviour
{

    public logicScript logic; 

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
    }

    public void loadButton()
    {
        logic.days = PlayerPrefs.GetInt("Days", 100);
        logic.money = PlayerPrefs.GetInt("Money", 100);
        logic.happiness = PlayerPrefs.GetInt("Happiness", 100);
        logic.social = PlayerPrefs.GetInt("Social", 100);
        
        logic.language = PlayerPrefs.GetInt("Language", 100);
        logic.mathematics = PlayerPrefs.GetInt("Math", 100);
        logic.science = PlayerPrefs.GetInt("Science", 100);
        logic.humanities = PlayerPrefs.GetInt("Humanities", 100);

        logic.daysNumber.text = "Days Left: " + logic.days.ToString();
        logic.moneyNumber.text = "Money: " + logic.money.ToString();
        logic.happinessNumber.text = "Happiness: " + logic.happiness.ToString();
        logic.socialNumber.text = "Social: " + logic.social.ToString();

        logic.languageNumber.text = "Language: " + logic.language.ToString();
        logic.mathNumber.text = "Math: " + logic.mathematics.ToString();
        logic.scienceNumber.text = "Science: " + logic.science.ToString();
        logic.humanitiesNumber.text = "Humanities: " + logic.humanities.ToString();
    }
}
