using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine.UI;
using UnityEngine;

public class ComparingFunctions : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private InputField ValueA;
    [SerializeField] private InputField ValueB;
    [SerializeField] private Text Result;

    public void Comparing()
    {
        if(ValueA.text != "" && ValueB.text != "")
        { 
            if (Convert.ToInt32(ValueA.text) > Convert.ToInt32(ValueB.text))
            {
                Result.text = ValueA.text;
            }
            else if (Convert.ToInt32(ValueA.text) < Convert.ToInt32(ValueB.text))
            {
                Result.text = ValueB.text;
            }
            else
            {
            Result.text = "Равны!";
            }
        }
        else
        {
            Result.text = "Введите значения переменных!";
        }
    }
}
