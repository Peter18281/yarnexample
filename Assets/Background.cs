using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Yarn.Unity;

public class Background : MonoBehaviour
{
    public SpriteRenderer bg;

    void Start()
    {
        bg = GameObject.Find("Background").GetComponent<SpriteRenderer>();
    }

    [YarnCommand("bg_Red")]
    public void bgRed(){
        bg.color = Color.red;
    }

    [YarnCommand("bg_Green")]
    public void bgGreen(){
        bg.color = Color.green;
    }

    [YarnCommand("bg_Blue")]
    public void bgBlue(){
        bg.color = Color.blue;
    }
}
