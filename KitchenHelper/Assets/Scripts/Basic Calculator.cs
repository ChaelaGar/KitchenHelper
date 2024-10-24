using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Runtime.CompilerServices;

public class BasicCalculator : MonoBehaviour
{
    public TextMeshProUGUI displayText;

    private string currentInput = "";

    private double result = 0.0;

    public void OnButtonClick(string buttonValue)
    {
        if (buttonValue == "=")
        {
            //calculate the result;
            CalculateResult();
        }
        else if (buttonValue == "C")
        {
             //Clear Input
             clearInput();
        }
        else
        {
             currentInput += buttonValue;
            UpdateDisplay();
        }
    }
    public void CalculateResult()
    {
        try
        {
            result = System.Convert.ToDouble(new System.Data.DataTable().Compute(currentInput, ""));

            currentInput = result.ToString();
            UpdateDisplay();
        }
        catch (System.Exception) {

            currentInput = "Error";
                UpdateDisplay();
                
                }
        
    }
    private void clearInput()
    {
        currentInput = "";
        result = 0.0;
        UpdateDisplay();
    }
    private void UpdateDisplay()
    {
        displayText.text = currentInput;
    }
}
