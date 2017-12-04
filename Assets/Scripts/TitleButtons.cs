﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleButtons : MonoBehaviour {

    public GameObject button;
    public GameObject button1;
    public GameObject button2;
    public GameObject button3;
    public GameObject button4;
    public GameObject button5;
    public GameObject title;
    public GameObject text1;
    public GameObject text2;
    public GameObject text3;
    public GameObject text4;
    public GameObject text5;
    public GameObject controls;

    // Use this for initialization
    void Start () { 

        button.SetActive(false);
    }

    // Update is called once per frame
    void Update () {
		
	}

    public void OnClickPlay()
    {

        SceneManager.LoadSceneAsync("GamePlay");

    }

    public void OnClickOptions()
    {
            
            button.SetActive(true);
            button1.SetActive(false);
            button3.SetActive(false);
            button4.SetActive(false);
            title.SetActive(false);
            text1.SetActive(false);
            text2.SetActive(false);
            text3.SetActive(false);
            text4.SetActive(false);
        controls.SetActive(false);

        button.GetComponent<TitleBackButton>().options = true;

            button2.SetActive(false);

    }

    public void OnClickCredits()
    {

        button.SetActive(true);
        button1.SetActive(false);
        button2.SetActive(false);
        button4.SetActive(false);
        title.SetActive(false);
        text1.SetActive(false);
        text2.SetActive(false);
        text3.SetActive(false);
        text4.SetActive(false);
        controls.SetActive(false);

        button.GetComponent<TitleBackButton>().credits = true;

        button3.SetActive(false);

    }

    public void OnClickExit()
    {

        Application.Quit();

    }

}