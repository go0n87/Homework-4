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
            Result.text = @"����������� ""a"" �� ����� ���� ����� 0";
        }
        else
        {
            //��������� ������������
            discriminant = Math.Pow(Convert.ToDouble(ValueB.text), 2) - (4d * Convert.ToDouble(ValueA.text) * Convert.ToDouble(ValueC.text));
            if (discriminant > 0.0)
            {
                //��������� �����
                root1 = (-Convert.ToDouble(ValueB.text) + Math.Sqrt(discriminant)) / (2d * Convert.ToDouble(ValueA.text));
                root2 = (-Convert.ToDouble(ValueB.text) - Math.Sqrt(discriminant)) / (2d * Convert.ToDouble(ValueA.text));

                Result.text = "����� ���������: �1= " + Convert.ToString(Math.Round(root1, 2)) + "; �2= " + Convert.ToString(Math.Round(root2, 2));                
            }
            else if(discriminant == 0.0)
            {
                // �������� ������, �.�. ������������ ����� 0
                root1 = -Convert.ToDouble(ValueB.text) / 2d * Convert.ToDouble(ValueA.text);
                Result.text = "������������ ����� 0, ��������� ����� ���� ������ X1 = " + Convert.ToString(Math.Round(root1,2));
            }
            else if (discriminant < 0.0)
            {
                // ������������ ������ 0, ������ ���
                Result.text = "������������ ������ 0, ������ ��� ";
            }
        }
    }

}
