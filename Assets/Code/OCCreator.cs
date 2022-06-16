using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OCCreator : MonoBehaviour
{
    // Start is called before the first frame update#
    IEnumerator WaitASecond() {
        yield return new WaitForSeconds(1);
    }
    void Start()
    {
        string path = Path.Combine(Environment.GetFolderPath( Environment.SpecialFolder.ApplicationData), "GachaUnity");
        string path2 = Path.Combine(Path.Combine(Environment.GetFolderPath( Environment.SpecialFolder.ApplicationData), "GachaUnity"), "Characters");
        string path3 = Path.Combine(Path.Combine(Environment.GetFolderPath( Environment.SpecialFolder.ApplicationData), "GachaUnity"), "StudioSaves");
        string path4 = Path.Combine(Path.Combine(Environment.GetFolderPath( Environment.SpecialFolder.ApplicationData), "GachaUnity"), "HardCodedCharacters");
        string LuniPath = Path.Combine(Path.Combine(Path.Combine(Environment.GetFolderPath( Environment.SpecialFolder.ApplicationData), "GachaUnity"), "HardCodedCharacters"), "Luni.oc");
        string CurCharPath = Path.Combine(Path.Combine(Path.Combine(Environment.GetFolderPath( Environment.SpecialFolder.ApplicationData), "GachaUnity"), "HardCodedCharacters"), "CurrentCharacter.char");
        StartCoroutine(WaitASecond());
        if(!Directory.Exists(path))
        {
            Debug.Log("Gacha Unity Saves Dont Exist. Creating");
            Directory.CreateDirectory(path);
            Directory.CreateDirectory(path2);
            Directory.CreateDirectory(path3);
            using (StreamWriter sw = File.CreateText(LuniPath))
            {
                sw.WriteLine("Icon = 6");
                sw.WriteLine("RearHair = 213");
                sw.WriteLine("FrontHair = 300");
                sw.WriteLine("BackHair = 0");
                sw.WriteLine("PonyTail = 0");
                sw.WriteLine("Ahoge = 13");
                sw.WriteLine("Eyes = 4");
                sw.WriteLine("RightEyes = 4");
                sw.WriteLine("Pupil = 17");
                sw.WriteLine("RightPupil = 17");
                sw.WriteLine("Eyebrow = 24");
                sw.WriteLine("RightEyebrow = 24");
                sw.WriteLine("Nose = 1");
                sw.WriteLine("Mouth = 3");
                sw.WriteLine("Blush = 0");
            }
            using (StreamWriter sw2 = File.CreateText(CurCharPath))
            {
                sw2.WriteLine("TemplateTextNumber2");
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
