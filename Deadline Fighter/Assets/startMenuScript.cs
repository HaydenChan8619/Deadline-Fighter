using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 

public class startMenuScript : MonoBehaviour
{

    public GameObject ui;
    public GameObject buttons;
    public GameObject box1;
    public GameObject box2;
    public GameObject startMenu;

    public saveScript save;

    // Start is called before the first frame update
    void Start()
    {
        startMenu.SetActive(true);
        ui.SetActive(false);
        buttons.SetActive(false);
        box1.SetActive(false);
        box2.SetActive(false);

        //animation["DeadlineFighterTitle"].wrapMode = WrapMode.Once;
        //animation.Play("AnimationName");
    }

    public void startLoadGame()
    {
        ui.SetActive(true);
        buttons.SetActive(true);
        box1.SetActive(true);
        box2.SetActive(true);
        startMenu.SetActive(false);
        save.loadButton();
    }

    public void startNewGame()
    {
        startMenu.SetActive(false);

    }
}
