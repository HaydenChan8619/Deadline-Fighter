using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 

public class logicScript : MonoBehaviour
{

    public int days = 100;
    public int money = 100;
    public int happiness = 100;
    public int social = 100;

    public int language = 0;
    public int mathematics = 0;
    public int science = 0;
    public int humanities = 0;

    public Text daysNumber;
    public Text moneyNumber;
    public Text happinessNumber;
    public Text socialNumber;

    public Text languageNumber;
    public Text mathNumber;
    public Text scienceNumber;
    public Text humanitiesNumber;

    public GameObject studyButton;

    public GameObject disneyMenu;
    public GameObject studyMenu;
    public GameObject studyGroupMenu;
    public GameObject bowlingMenu;
    public GameObject cashierMenu;
    public GameObject tutorMenu;
    public GameObject hikingMenu;

    public const int maxStat = 100;
    public const int minStat = 0;

    public buttonPopUpScript buttonPopUpSystem;

    //
   void Start() 
    {
        daysNumber.text = "Days Left: " + days.ToString();
        moneyNumber.text = "Money: " + money.ToString();
        happinessNumber.text = "Happiness: " + happiness.ToString();
        socialNumber.text = "Social: " + social.ToString();
    }

    ///////////////////////////////////////////////////////////////////////////////

    ///////////////////////////////////////////////////////////////////////////////


    public void statBoost (int subject, int increase, int size)
    {
        switch(subject)
        {
            case 1:
                language = language + increase * size;
                languageNumber.text = "Language: " + language.ToString();
                break;

            case 2:
                mathematics = mathematics + increase * size;
                mathNumber.text = "Math: " + mathematics.ToString();
                break;

            case 3:
                science = science + increase * size;
                scienceNumber.text = "Science: " + science.ToString();
                break;

            case 4:
                humanities = humanities + increase * size;
                humanitiesNumber.text = "Humanities: " + humanities.ToString();
                break;

        }
    }

    ///////////////////////////////////////////////////////////////////////////////

    ///////////////////////////////////////////////////////////////////////////////

    public void statIncrease(int minChange, int MaxChange, int changeFactor)
    {
        int increase = Random.Range(minChange,MaxChange);
        int subject = Random.Range(1, 5); // may implement choosing subject later

        statBoost(subject, increase, changeFactor);
    }

    ///////////////////////////////////////////////////////////////////////////////

    ///////////////////////////////////////////////////////////////////////////////


    public void happinessChange(int change)
    {
        happiness = happiness + change;
        
        if(happiness < minStat)
        {
            happiness = minStat;
        } else if (happiness > maxStat)
        {
            happiness = maxStat;
        }
        happinessNumber.text = "Happiness: " + happiness.ToString();
    }

    public void moneyChange(int change)
    {
        money = money + change;
        moneyNumber.text = "Money: " + money.ToString();
    }

    public void socialChange(int change)
    {
        social = social + change;

        if(social < minStat)
        {
            social = minStat;
        } else if (social > maxStat)
        {
            social = maxStat;
        }
        socialNumber.text = "Social: " + social.ToString();
    }

    ///////////////////////////////////////////////////////////////////////////////

    ///////////////////////////////////////////////////////////////////////////////

    int happinessFactor()
    {
        int factor = 1;

        if (happiness > 50)
        {
            factor = 2;
        } else if (happiness > 0)
        {
            factor = 1;
        } else 
        {
            factor = 0;
        }
        return factor;
    }

    bool moneyCheck(int cost)
    {
        bool afford = money >= cost;
        return afford;
    }

    public void socialUpdate()
    {
        if (social >= 50)
        {
            happinessChange(change:5);
            socialChange(change:-10);
        } else {
            happinessChange(change:-5);
            socialChange(change:-15);
        }
    }

    public void daysChange(ref int days)
    {
        days = days - 1;
        daysNumber.text = "Days Left: " + days.ToString();
        socialUpdate();
        //school();  //COME BACK LATER AND RE-THINK IF THIS IS NEEDED.
    }

    [ContextMenu("School")]
    public void school()
    {
        int increase = Random.Range(3, 6);
        int subject = Random.Range(1, 5); 

        statBoost(subject, increase, 1);
    }

    [ContextMenu("Study")]
    public void study()
    {
        statIncrease(minChange:1, MaxChange:3,changeFactor:happinessFactor());
        happinessChange(change:-20);
        daysChange(ref days);
        studyMenu.SetActive(false);
        buttonPopUpSystem.buttonEnable();
    }

    [ContextMenu("Bowling")]
    public void bowling()
    {
        if (moneyCheck(cost:100))
        {
            happinessChange(change:20);
            moneyChange(change:-100);
            daysChange(ref days);
            bowlingMenu.SetActive(false);
            buttonPopUpSystem.buttonEnable();
        }
        

    }

    public void cashier()
    {
        happinessChange(change:-10);
        moneyChange(change:200);
        daysChange(ref days);
        cashierMenu.SetActive(false);
        buttonPopUpSystem.buttonEnable();

    }

    public void disney()
    {

        if (moneyCheck(cost:500))
        {
            happiness = 100;
            happinessNumber.text = "Happiness: " + happiness.ToString();
            moneyChange(change:-500);
            daysChange(ref days);
            disneyMenu.SetActive(false);
            buttonPopUpSystem.buttonEnable();
        }
        
    }

    public void studyGroup()
    {
        happinessChange(change:-10);
        socialChange(change:20);
        statIncrease(minChange:1, MaxChange:2,changeFactor:happinessFactor());
        daysChange(ref days);
        studyGroupMenu.SetActive(false);
        buttonPopUpSystem.buttonEnable();
    }

    public void tutor()
    {
        if (moneyCheck(cost:100))
        {
            happinessChange(change:-10);
            moneyChange(change:-100);
            statIncrease(minChange:3, MaxChange:6,changeFactor:2);
            daysChange(ref days);
            tutorMenu.SetActive(false);
            buttonPopUpSystem.buttonEnable();
        }


    }

    public void hiking()
    {
        happinessChange(change:20);
        socialChange(change:30);
        daysChange(ref days);
        hikingMenu.SetActive(false);
        buttonPopUpSystem.buttonEnable();
    }
}