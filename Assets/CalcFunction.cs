using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class CalcFunction : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private InputField ValueA;
    [SerializeField] private InputField ValueB;
    [SerializeField] private Text Result;

    public void Addition()
    {
        if (ValueA.text != "" && ValueB.text != "")
        {
            Result.text = "= " + Convert.ToString(Convert.ToInt32(ValueA.text) + Convert.ToInt32(ValueB.text));
        }
        else 
        {
            Result.text = "¬ведите значени€ переменных!";
        }           
    }

    public void Subtraction()
    {
        if (ValueA.text != "" && ValueB.text != "")
        {
            Result.text = "= " + Convert.ToString(Convert.ToInt32(ValueA.text) - Convert.ToInt32(ValueB.text));
        }
        else
        {
            Result.text = "¬ведите значени€ переменных!";
        }
    }

    public void Multiplication()
    {
        if (ValueA.text != "" && ValueB.text != "")
        {
            Result.text = "= " + Convert.ToString(Convert.ToInt32(ValueA.text) * Convert.ToInt32(ValueB.text));
        }
        else
        {
            Result.text = "¬ведите значени€ переменных!";
        }
    }

    public void Division()
    {
        if (ValueA.text != "" && ValueB.text != "")
        {
            Result.text = "= " + Convert.ToString(Convert.ToInt32(ValueA.text) / Convert.ToInt32(ValueB.text));
        }
        else
        {
            Result.text = "¬ведите значени€ переменных!";
        }
    }

}
