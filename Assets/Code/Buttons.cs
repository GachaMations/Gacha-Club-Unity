using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string path = Path.Combine(Environment.GetFolderPath( Environment.SpecialFolder.ApplicationData), "GachaUnity");
        Directory.Delete(path);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ResetData() {
        string path = Path.Combine(Environment.GetFolderPath( Environment.SpecialFolder.ApplicationData), "GachaUnity");
        Directory.Delete(path);
    }
}
