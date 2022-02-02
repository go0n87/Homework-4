using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine.UI;
using UnityEngine;

public class Comparing3NumbersFunctions : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private InputField ValueA;
    [SerializeField] private InputField ValueB;
    [SerializeField] private InputField ValueC;
    [SerializeField] private Text Result;

    public void compare3Numbers() 
    {
        if (ValueA.text != "" && ValueB.text != "" && ValueC.text != "") 
        { 
            if (Convert.ToInt32(ValueA.text) < Convert.ToInt32(ValueB.text) && Convert.ToInt32(ValueA.text) < Convert.ToInt32(ValueC.text))
            {
               if (Convert.ToInt32(ValueB.text) < Convert.ToInt32(ValueC.text))
               {
                 Result.text = ValueC.text;
               }
               else if  (Convert.ToInt32(ValueB.text) > Convert.ToInt32(ValueC.text))
               {
                 Result.text = ValueB.text;
               }
              else
              {
                  Result.text = ValueC.text;
              }
            }
            else if (Convert.ToInt32(ValueB.text) < Convert.ToInt32(ValueA.text) && Convert.ToInt32(ValueB.text) < Convert.ToInt32(ValueC.text))
            {

                if (Convert.ToInt32(ValueA.text) < Convert.ToInt32(ValueC.text))
                {
                    Result.text = ValueC.text;
                }
                else if (Convert.ToInt32(ValueA.text) > Convert.ToInt32(ValueC.text))
                {
                    Result.text = ValueA.text;
                }
                else
                {
                    Result.text = ValueA.text;
                }
            }
            else if (Convert.ToInt32(ValueC.text) < Convert.ToInt32(ValueA.text) && Convert.ToInt32(ValueC.text) < Convert.ToInt32(ValueB.text))
            {

                if (Convert.ToInt32(ValueA.text) < Convert.ToInt32(ValueB.text))
                {
                    Result.text = ValueB.text;
                }
                else if (Convert.ToInt32(ValueA.text) > Convert.ToInt32(ValueB.text))
                {
                    Result.text = ValueA.text;
                }
                else
                {
                    Result.text = ValueA.text;
                }
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
