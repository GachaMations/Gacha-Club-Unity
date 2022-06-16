using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AgePad : MonoBehaviour
{
//    AudioSource audioData0;
 //   AudioSource audioData1;
  //  AudioSource audioData2;
   // AudioSource audioData3;
//    AudioSource audioData4;
 //   AudioSource audioData5;
  //  AudioSource audioData6;
   // AudioSource audioData7;
    //AudioSource audioData8;
//    AudioSource audioData9;
    //AudioSource audioDataX;
    AudioSource audioDataEnter;
    public GameObject agetext;
    private Text agevalue;
    string Age = "";
    SpriteRenderer m_SpriteRenderer;
    public GameObject StartScreen;
    public Sprite undernine;
    public Sprite StartImg;
    public Sprite ElevenTwelve;
    public Sprite TOS;
    // Start is called before the first frame update
    void Start()
    {
        m_SpriteRenderer = StartScreen.GetComponent<SpriteRenderer>();
    }

    void Update() {
        agevalue = agetext.GetComponent<Text>();
        agevalue.text = Age;
    }
    public void input0()
    {
        if(Age.Length == 1 || Age.Length == 0)
        {
            //audioData0 = GetComponent<AudioSource>();
           // audioData0.Play(0);
            Age = Age.Insert(Age.Length, "0");
        }
    }
    public void input1()
    {
        if(Age.Length == 1 || Age.Length == 0)
        {
            //audioData1 = GetComponent<AudioSource>();
           // audioData1.Play(0);
            Age = Age.Insert(Age.Length, "1");
        }
    }
    public void input2()
    {
        if(Age.Length == 1 || Age.Length == 0)
        {
           // audioData2 = GetComponent<AudioSource>();
            //audioData2.Play(0);
            Age = Age.Insert(Age.Length, "2");
        }
    }
    public void input3()
    {
        if(Age.Length == 1 || Age.Length == 0)
        {
           // audioData3 = GetComponent<AudioSource>();
            //audioData3.Play(0);
            Age = Age.Insert(Age.Length, "3");
        }
    }
    public void input4()
    {
        if(Age.Length == 1 || Age.Length == 0)
        {
           // audioData4 = GetComponent<AudioSource>();
            //audioData4.Play(0);
            Age = Age.Insert(Age.Length, "4");
        }
    }
    public void input5()
    {
        if(Age.Length == 1 || Age.Length == 0)
        {
          //  audioData5 = GetComponent<AudioSource>();
           // audioData5.Play(0);
            Age = Age.Insert(Age.Length, "5");
        }
    }
    public void input6()
    {
        if(Age.Length == 1 || Age.Length == 0)
        {
           // audioData6 = GetComponent<AudioSource>();
           // audioData6.Play(0);
            Age = Age.Insert(Age.Length, "6");
        }
    }
    public void input7()
    {
        if(Age.Length == 1 || Age.Length == 0)
        {
           // audioData7 = GetComponent<AudioSource>();
           // audioData7.Play(0);
            Age = Age.Insert(Age.Length, "7");
        }
    }
    public void input8()
    {
        if(Age.Length == 1 || Age.Length == 0)
        {
           // audioData8 = GetComponent<AudioSource>();
            //audioData8.Play(0);
            Age = Age.Insert(Age.Length, "8");
        }
    }
    public void input9()
    {
        if(Age.Length == 1 || Age.Length == 0)
        {
           // audioData9 = GetComponent<AudioSource>();
           // audioData9.Play(0);
            Age = Age.Insert(Age.Length, "9");
        }
    }
    public void backspace()
    {
        if(Age.Length == 1 || Age.Length == 2)
        {
            //audioDataX = GetComponent<AudioSource>();
            //audioDataX.Play(0);
            Age = Age.Substring(0, Age.Length - 1);
        }
    }
    public void enter()
    {
        //audioDataEnter = GetComponent<AudioSource>();
        //audioDataEnter.Play(0);
        int AgeInt;
        int.TryParse(Age, out AgeInt);
        if(AgeInt < 10)
        {
            m_SpriteRenderer.sprite = undernine;
        }
        if(AgeInt == 11 || AgeInt == 12)
        {
            m_SpriteRenderer.sprite = ElevenTwelve;
        }
        if(AgeInt == 10 || AgeInt > 12)
        {
            m_SpriteRenderer.sprite = TOS;
        }
    }
    public void back()
    {
        m_SpriteRenderer.sprite = StartImg;
    }
}
