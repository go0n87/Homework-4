using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine.UI;
using UnityEngine;

public class QuadraticEquation : MonoBehaviour
{
    [SerializeField] private InputField ValueA;
    [SerializeField] private InputField ValueB;
    [SerializeField] private InputField ValueC;
    [SerializeField] private Text Result;

    private double discriminant;
    private double root1;
    private double root2;
    public void CalculateQuadraticEquation()
    {
        if (Convert.ToInt32(ValueA.text) == 0)
        {
            Result.text = @"Коэффициент ""a"" не может быть равен 0";
        }
        else
        {
            //посчитаем дискриминант
            discriminant = Math.Pow(Convert.ToDouble(ValueB.text), 2) - (4d * Convert.ToDouble(ValueA.text) * Convert.ToDouble(ValueC.text));
            if (discriminant > 0.0)
            {
                //посчитаем корни
                root1 = (-Convert.ToDouble(ValueB.text) + Math.Sqrt(discriminant)) / (2d * Convert.ToDouble(ValueA.text));
                root2 = (-Convert.ToDouble(ValueB.text) - Math.Sqrt(discriminant)) / (2d * Convert.ToDouble(ValueA.text));

                Result.text = "Корни уравнения: Х1= " + Convert.ToString(Math.Round(root1, 2)) + "; Х2= " + Convert.ToString(Math.Round(root2, 2));                
            }
            else if(discriminant == 0.0)
            {
                // вычислим корень, т.к. дискриминант равен 0
                root1 = -Convert.ToDouble(ValueB.text) / 2d * Convert.ToDouble(ValueA.text);
                Result.text = "Дискриминант равен 0, уравнение имеет один корень X1 = " + Convert.ToString(Math.Round(root1,2));
            }
            else if (discriminant < 0.0)
            {
                // дискриминант меньше 0, корней нет
                Result.text = "Дискриминант меньше 0, корней нет ";
            }
        }
    }

}
