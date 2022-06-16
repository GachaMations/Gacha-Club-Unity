using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PadEnableDisable : MonoBehaviour
{
    public GameObject StartScreen;
    public GameObject b0;
    public GameObject b1;
    public GameObject b2;
    public GameObject b3;
    public GameObject b4;
    public GameObject b5;
    public GameObject b6;
    public GameObject b7;
    public GameObject b8;
    public GameObject b9;
    public GameObject bBack;
    public GameObject bEnter;
    public GameObject AgeTextObj;
    public GameObject backbutton;
    public Sprite ThirteenPlus;
    public Sprite UnderNine;
    public Sprite AgeMenu;
    public Sprite StartImg;
    private Text AgeText;
    SpriteRenderer m_SpriteRenderer;
    private Button b0b;
    private Button b1b;
    private Button b2b;
    private Button b3b;
    private Button b4b;
    private Button b5b;
    private Button b6b;
    private Button b7b;
    private Button b8b;
    private Button b9b;
    private Button bbackb;
    private Button benterb;
    private Button bbackbutton;
    // Start is called before the first frame update
    void Start()
    {
        AgeText = AgeTextObj.GetComponent<Text>();
        m_SpriteRenderer = StartScreen.GetComponent<SpriteRenderer>();
        b0b = b0.GetComponent<Button>();
        b1b = b1.GetComponent<Button>();
        b2b = b2.GetComponent<Button>();
        b3b = b3.GetComponent<Button>();
        b4b = b4.GetComponent<Button>();
        b5b = b5.GetComponent<Button>();
        b6b = b6.GetComponent<Button>();
        b7b = b7.GetComponent<Button>();
        b8b = b8.GetComponent<Button>();
        b9b = b9.GetComponent<Button>();
        bbackb = bBack.GetComponent<Button>();
        benterb = bEnter.GetComponent<Button>();
        bbackbutton = backbutton.GetComponent<Button>();
    }

    // Update is called once per frameb1
    void Update()
    {
        if(m_SpriteRenderer.sprite != AgeMenu)
        {
            b1b.interactable = false;
            b2b.interactable = false;
            b3b.interactable = false;
            b4b.interactable = false;
            b5b.interactable = false;
            b6b.interactable = false;
            b7b.interactable = false;
            b8b.interactable = false;
            b9b.interactable = false;
            b0b.interactable = false;
            bbackb.interactable = false;
            benterb.interactable = false;
            bbackbutton.interactable = false;
        }
        else {
            b1b.interactable = true;
            b2b.interactable = true;
            b3b.interactable = true;
            b4b.interactable = true;
            b5b.interactable = true;
            b6b.interactable = true;
            b7b.interactable = true;
            b8b.interactable = true;
            b9b.interactable = true;
            b0b.interactable = true;
            bbackb.interactable = true;
            benterb.interactable = true;
            bbackbutton.interactable = true;
        }

        if(m_SpriteRenderer.sprite == StartImg)
        {
            AgeText.enabled = false;
        }
        else {
            AgeText.enabled = true;
        }
        if(m_SpriteRenderer.sprite == UnderNine)
        {
            if (Input.GetMouseButtonDown(0))
            {
                m_SpriteRenderer.sprite = AgeMenu;
            }
        }
    }
}
