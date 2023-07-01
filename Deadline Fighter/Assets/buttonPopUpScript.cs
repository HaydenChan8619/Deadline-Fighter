using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 

public class buttonPopUpScript : MonoBehaviour
{
    /* 
    This script is home to the buttonEnable/Disable system, the activity button triggers to enable and disable PopUps,
    stat system, and endGame systems
    */
    public GameObject disneyMenu;
    public GameObject studyMenu;
    public GameObject studyGroupMenu;
    public GameObject bowlingMenu;
    public GameObject cashierMenu;
    public GameObject tutorMenu;
    public GameObject hikingMenu;
    public GameObject statMenu;

    public GameObject disney;
    public GameObject study;
    public GameObject studyGroup;
    public GameObject bowling;
    public GameObject cashier;
    public GameObject tutor;
    public GameObject hiking;
    public GameObject stat;
    public GameObject pauseButton;

    public Text statDescription;

    public bool gameActive = true;

    public GameObject endGameMenu;
    public Text finalScore;
    public Text highScore;

    public GameObject happinessErrorMenu;
    public GameObject moneyErrorMenu;

    public logicScript logic;
    public pauseMenuScript pause;
    public saveScript save;

    //////////////////////////////////////////////////////////
    //Below are the buttonEnable/Disable System///////////////
    //////////////////////////////////////////////////////////

    public void buttonDisable()
    {
        disney.SetActive(false);
        study.SetActive(false);
        studyGroup.SetActive(false);
        bowling.SetActive(false);
        cashier.SetActive(false);
        tutor.SetActive(false);
        hiking.SetActive(false);
        stat.SetActive(false);
        pauseButton.SetActive(false);
        
    }

    public void buttonEnable()
    {
        if (gameActive)
        {
            disney.SetActive(true);
            study.SetActive(true);
            studyGroup.SetActive(true);
            bowling.SetActive(true);
            cashier.SetActive(true);
            tutor.SetActive(true);
            hiking.SetActive(true);
            stat.SetActive(true);
            pauseButton.SetActive(true);
        }
    }

    //////////////////////////////////////////////////////////
    //Below are the open activity popup triggers//////////////
    //////////////////////////////////////////////////////////

    public void disneyButton()
    {
        disneyMenu.SetActive(true);
        buttonDisable();
        
    }
        
    public void studyButton()
    {
        studyMenu.SetActive(true);
        buttonDisable();
    }

    public void studyGroupButton()
    {
        studyGroupMenu.SetActive(true);
        buttonDisable();
    }

    public void bowlingButton()
    {
        bowlingMenu.SetActive(true);
        buttonDisable();
    }

    public void cashierButton()
    {
        cashierMenu.SetActive(true);
        buttonDisable();
    }

    public void tutorButton()
    {
        tutorMenu.SetActive(true);
        buttonDisable();
    }

    public void hikingButton()
    {
        hikingMenu.SetActive(true);
        buttonDisable();
    }

    public void statButton()
    {
        statMenu.SetActive(true);
        statLoadIn();
        buttonDisable();
    }

    //////////////////////////////////////////////////////////
    //Below are the close activity popup triggers/////////////
    //////////////////////////////////////////////////////////

    public void disneyGoBack()
    {
        disneyMenu.SetActive(false);
        moneyErrorMenu.SetActive(false);
        buttonEnable();
    }

    public void studyGoBack()
    {
        studyMenu.SetActive(false);
        happinessErrorMenu.SetActive(false);
        buttonEnable();
    }

    public void studyGroupGoBack()
    {
        studyGroupMenu.SetActive(false);
        happinessErrorMenu.SetActive(false);
        buttonEnable();
    }

    public void bowlingGoBack()
    {
        bowlingMenu.SetActive(false);
        moneyErrorMenu.SetActive(false);
        buttonEnable();
    }

    public void cashierGoBack()
    {
        cashierMenu.SetActive(false);
        happinessErrorMenu.SetActive(false);
        buttonEnable();
    }

    public void tutorGoBack()
    {
        tutorMenu.SetActive(false);
        moneyErrorMenu.SetActive(false);
        happinessErrorMenu.SetActive(false);
        buttonEnable();
    }

    public void hikingGoBack()
    {
        hikingMenu.SetActive(false);
        buttonEnable();
    }

    //////////////////////////////////////////////////////////
    //Below are the stats System//////////////////////////////
    //////////////////////////////////////////////////////////

    public void statGoBack()
    {
        statMenu.SetActive(false);
        buttonEnable();
    }

    public void statLoadIn(){
        statDescription.text = "Disney:" + logic.disneyCount + "\nStudy:" + logic.studyCount + "\nStudy Group:" + logic.studyGroupCount
                            + "\nBowling:" + logic.bowlingCount + "\nCashier:" + logic.cashierCount + "\nTutor:" + logic.tutorCount + "\nHiking:" + logic.hikingCount;
                                
    }

    //////////////////////////////////////////////////////////
    //Below are the endGame System////////////////////////////
    //////////////////////////////////////////////////////////

    public void endGame()
    {
        gameActive = false;
        endGameMenu.SetActive(true);
        buttonDisable();
        endGameFinalScore();
        highScoreUpdate();
        endGameHighScore();
    }

    public void endGameFinalScore()
    {
        finalScore.text = "Language:" + logic.language + "\nMath:" + logic.mathematics + "\nScience:" + logic.science + "\nHumanities:" + logic.humanities;
    }

    public void endGameRestart()
    {
        endGameMenu.SetActive(false);
        pause.restartGame();

    }

    public void endGameLoadButton()
    {
        endGameMenu.SetActive(false);
        gameActive = true;
        save.loadButton();
    }

    public void highScoreUpdate()
    {
        if (PlayerPrefs.GetInt("LanguageHighScore",0) < logic.language)
        {
            PlayerPrefs.SetInt("LanguageHighScore",logic.language);
        }

        if (PlayerPrefs.GetInt("MathHighScore",0) < logic.mathematics)
        {
            PlayerPrefs.SetInt("MathHighScore",logic.mathematics);
        }

        if (PlayerPrefs.GetInt("ScienceHighScore",0) < logic.science)
        {
            PlayerPrefs.SetInt("ScienceHighScore",logic.science);
        }

        if (PlayerPrefs.GetInt("HumanitiesHighScore",0) < logic.humanities)
        {
            PlayerPrefs.SetInt("HumanitiesHighScore",logic.humanities);
        }
    }

    public void endGameHighScore()
    {
        highScore.text = "L:" + PlayerPrefs.GetInt("LanguageHighScore",0) + "  M:" + PlayerPrefs.GetInt("MathHighScore",0) +
                         "\nS:" + PlayerPrefs.GetInt("ScienceHighScore",0) + "  H:" + PlayerPrefs.GetInt("HumanitiesHighScore",0);
    }



}
