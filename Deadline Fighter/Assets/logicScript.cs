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

    [ContextMenu("School")]
    void school()
    {
        int schoolIncrease = Random.Range(3, 6);
        int subjectChoice = Random.Range(1, 5); 

        switch(subjectChoice)
        {
            case 1:
                language = language + schoolIncrease;
                languageNumber.text = "Language: " + language.ToString();
                break;

            case 2:
                mathematics = mathematics + schoolIncrease;
                mathNumber.text = "Math: " + mathematics.ToString();
                break;

            case 3:
                science = science + schoolIncrease;
                scienceNumber.text = "Science: " + science.ToString();
                break;

            case 4:
                humanities = humanities + schoolIncrease;
                humanitiesNumber.text = "Humanities: " + humanities.ToString();
                break;
        }
    }
}
