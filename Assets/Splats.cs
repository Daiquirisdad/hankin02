using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Splats : MonoBehaviour
{
    public static int CurrentSplats = 0;

    public Text splatsText;

    void Start()
    {
        splatsText.text = CurrentSplats.ToString();
    }

}