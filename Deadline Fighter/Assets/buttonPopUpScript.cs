using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 

public class buttonPopUpScript : MonoBehaviour
{
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

    public bool gameActive = true;

    public Text statDescription;

    public logicScript logic;

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
        }
    }

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

    public void disneyGoBack()
    {
        disneyMenu.SetActive(false);
        buttonEnable();
    }

    public void studyGoBack()
    {
        studyMenu.SetActive(false);
        buttonEnable();
    }

    public void studyGroupGoBack()
    {
        studyGroupMenu.SetActive(false);
        buttonEnable();
    }

    public void bowlingGoBack()
    {
        bowlingMenu.SetActive(false);
        buttonEnable();
    }

    public void cashierGoBack()
    {
        cashierMenu.SetActive(false);
        buttonEnable();
    }

    public void tutorGoBack()
    {
        tutorMenu.SetActive(false);
        buttonEnable();
    }

    public void hikingGoBack()
    {
        hikingMenu.SetActive(false);
        buttonEnable();
    }

    public void statGoBack()
    {
        statMenu.SetActive(false);
        buttonEnable();
    }

    public void statLoadIn(){
        statDescription.text = "Disney:" + logic.disneyCount + "\nStudy:" + logic.studyCount + "\nStudyGroup:" + logic.studyGroupCount
                            + "\nBowling:" + logic.bowlingCount + "\nCashier:" + logic.cashierCount + "\nTutor:" + logic.tutorCount + "\nHiking:" + logic.hikingCount;
                                
    }

    public void endGame()
    {
        gameActive = false;
    }

}
