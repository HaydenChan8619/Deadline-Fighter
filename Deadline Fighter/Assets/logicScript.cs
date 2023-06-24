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

    public void tinyIncrease()
    {
        int subject = Random.Range(1, 5); // may implement choosing subject later

        statBoost(subject, 1, happinessFactor());  
    }

    [ContextMenu("Small Increase")]
    public void smallIncrease()
    {
        int increase = Random.Range(1,3);
        int subject = Random.Range(1, 5); // may implement choosing subject later

        statBoost(subject, increase, happinessFactor());  
    }



    [ContextMenu("Big Increase")]
    public void bigIncrease()
    {
        int increase = Random.Range(3,6);
        int subject = Random.Range(1, 5); // may implement choosing subject later

        statBoost(subject, increase, 2);
        
    }

    ///////////////////////////////////////////////////////////////////////////////

    ///////////////////////////////////////////////////////////////////////////////


    public void happinessChange(int change)
    {
        happiness = happiness + change;
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
        socialNumber.text = "Social: " + social.ToString();
    }



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

    public void daysChange()
    {
        days = days - 1;
        daysNumber.text = "Days Left: " + days.ToString();
        //school();
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
        smallIncrease();
        happinessChange(-20);
        daysChange();
    }

    [ContextMenu("Bowling")]
    public void bowling()
    {
        happinessChange(20);
        moneyChange(100);
        daysChange();

    }

    public void cashier()
    {
        happinessChange(-10);
        moneyChange(200);
        daysChange();

    }

    public void disney()
    {
        happiness = 100;
        happinessNumber.text = "Happiness: " + happiness.ToString();
        moneyChange(-500);
        daysChange();
    }

    public void studyGroup()
    {
        happinessChange(-10);
        socialChange(5);
        tinyIncrease();
        daysChange();
    }

    public void tutor()
    {
        happinessChange(-10);
        moneyChange(-100);
        bigIncrease();
        daysChange();

    }

    public void hiking()
    {
        happinessChange(20);
        socialChange(20);
        daysChange();

    }
}