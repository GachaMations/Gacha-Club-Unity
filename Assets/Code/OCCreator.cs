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
        string path5 = Path.Combine(Path.Combine(Environment.GetFolderPath( Environment.SpecialFolder.ApplicationData), "GachaUnity"), "ListCharacters");
        string LuniPath = Path.Combine(Path.Combine(Path.Combine(Environment.GetFolderPath( Environment.SpecialFolder.ApplicationData), "GachaUnity"), "HardCodedCharacters"), "Luni.oc");
        string CurCharPath = Path.Combine(Path.Combine(Path.Combine(Environment.GetFolderPath( Environment.SpecialFolder.ApplicationData), "GachaUnity"), "HardCodedCharacters"), "CurrentCharacter.oc");
        StartCoroutine(WaitASecond());
        if(!Directory.Exists(path))
        {
            Debug.Log("Gacha Unity Saves Dont Exist. Creating");
            Directory.CreateDirectory(path);
            Directory.CreateDirectory(path2);
            Directory.CreateDirectory(path3);
            Directory.CreateDirectory(path4);
            Directory.CreateDirectory(path5);
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
                sw.WriteLine("Hat = 112");
                sw.WriteLine("Glasses = 1");
                sw.WriteLine("AccessoryTop = 177");
                sw.WriteLine("AccessoryMiddle = 0");
                sw.WriteLine("AccessoryBottom = 0");
                sw.WriteLine("FaceAccessoryTop = 0");
                sw.WriteLine("ScarfTop = 101");
                sw.WriteLine("FaceAccessoryMiddle = 0");
                sw.WriteLine("ScarfBottom = 0");
                sw.WriteLine("FaceAccessoryBottom = 0");
                sw.WriteLine("ShirtLogo = 1");
                sw.WriteLine("Shirt = 7");
                sw.WriteLine("Jacket = 2");
                sw.WriteLine("Sleeve = 26");
                sw.WriteLine("RightSleeve = 26");
                sw.WriteLine("BeltSkirtTop = 94");
                sw.WriteLine("BeltSkirtBottom = 0");
                sw.WriteLine("Pants = 31");
                sw.WriteLine("RightPants = 31");
                sw.WriteLine("Sock = 3");
                sw.WriteLine("RightSock = 3");
                sw.WriteLine("Shoe = 68");
                sw.WriteLine("RightShoe = 68");
                sw.WriteLine("Cape = 0");
                sw.WriteLine("Tail = 0");
                sw.WriteLine("Wing = 0");
                sw.WriteLine("RightWing = 0");
                sw.WriteLine("Glove = 2");
                sw.WriteLine("RightGlove = 2");
                sw.WriteLine("Shoulder = 0");
                sw.WriteLine("RightShoulder = 0");
                sw.WriteLine("Wrist = 1");
                sw.WriteLine("RightWrist = 1");
                sw.WriteLine("Knee = 0");
                sw.WriteLine("RightKnee = 0");
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
