using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgePad : MonoBehaviour
{
    AudioSource audioData0;
    AudioSource audioData1;
    AudioSource audioData2;
    AudioSource audioData3;
    AudioSource audioData4;
    AudioSource audioData5;
    AudioSource audioData6;
    AudioSource audioData7;
    AudioSource audioData8;
    AudioSource audioData9;
    // Start is called before the first frame update
    void Start()
    {
    }
    public void input0()
    {
        audioData0 = GetComponent<AudioSource>();
        audioData0.Play(0);
    }
    public void input1()
    {
        audioData1 = GetComponent<AudioSource>();
        audioData1.Play(0);
    }
    public void input2()
    {
        audioData2 = GetComponent<AudioSource>();
        audioData2.Play(0);
    }
    public void input3()
    {
        audioData3 = GetComponent<AudioSource>();
        audioData3.Play(0);
    }
    public void input4()
    {
        audioData4 = GetComponent<AudioSource>();
        audioData4.Play(0);
    }
    public void input5()
    {
        audioData5 = GetComponent<AudioSource>();
        audioData5.Play(0);
    }
    public void input6()
    {
        audioData6 = GetComponent<AudioSource>();
        audioData6.Play(0);
    }
    public void input7()
    {
        audioData7 = GetComponent<AudioSource>();
        audioData7.Play(0);
    }
    public void input8()
    {
        audioData8 = GetComponent<AudioSource>();
        audioData8.Play(0);
    }
    public void input9()
    {
        audioData9 = GetComponent<AudioSource>();
        audioData9.Play(0);
    }
}
