using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class logicScript : MonoBehaviour
{

    public int days = 100;
    public int money;
    public int happiness;
    public int social;

    public int language;
    public int mathematics;
    public int science;
    public int humanities;

    public Text daysNumber;
    public Text moneyNumber;
    public Text happinessNumber;
    public Text socialNumber;

    public Text languageNumber;
    public Text mathNumber;
    public Text scienceNumber;
    public Text humanitiesNumber;

    void statBoost (int subject, int increase, int size)
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

    [ContextMenu("School")]
    void school()
    {
        int increase = Random.Range(3, 6);
        int subject = Random.Range(1, 5); 

        statBoost(subject, increase, 3);
    }

    [ContextMenu("Small Increase")]
    void smallIncrease(int subject)
    {
        int increase = Random.Range(1,4);

        statBoost(subject, increase, 1);
    }

    [ContextMenu("Big Increase")]
    void bigIncrease(int subject)
    {
        int increase = Random.Range(3,6);

        statBoost(subject, increase, 2);
        
    }
}
