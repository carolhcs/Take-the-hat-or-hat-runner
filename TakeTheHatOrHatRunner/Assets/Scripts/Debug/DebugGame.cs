using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DebugGame : MonoBehaviour
{
    public Text debugTxt_1;
    public Text debugTxt_2;
    public Text debugTxt_3;
    public Text debugTxt_4;

    public void SetOnDebugText(string text, int id)
    {
        switch (id)
        {
            case 1:
                debugTxt_1.text = text;
                break;
            case 2:
                debugTxt_2.text = text;
                break;
            case 3:
                debugTxt_3.text = text;
                break;
            case 4:
                debugTxt_4.text = text;
                break;
            default:
                Debug.Log("ERROR: id");
                break;
        }
    }

}
