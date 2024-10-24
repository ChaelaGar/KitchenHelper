using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InputGet : MonoBehaviour
{
    Button cal;
    [SerializeField]
    TMP_InputField i_1Amount;
    [SerializeField]
    TMP_InputField i_1Cost;
    [SerializeField]
    TMP_InputField i_1Total;
    [SerializeField]
    TMP_InputField i_2Amount;
    [SerializeField]
    TMP_InputField i_2Cost;
    [SerializeField]
    TMP_InputField i_2Total;
    [SerializeField]
    TMP_InputField i_3Amount;
    [SerializeField]
    TMP_InputField i_3Cost;
    [SerializeField]
    TMP_InputField i_3Total;
    [SerializeField]
    TMP_InputField i_4Amount;
    [SerializeField]
    TMP_InputField i_4Cost;
    [SerializeField]
    TMP_InputField i_4Total;
    [SerializeField]
    TMP_InputField i_5Amount;
    [SerializeField]
    TMP_InputField i_5Cost;
    [SerializeField]
    TMP_InputField i_5Total;
    [SerializeField]
    TMP_InputField i_6Amount;
    [SerializeField]
    TMP_InputField i_6Cost;
    [SerializeField]
    TMP_InputField i_6Total;
    [SerializeField]
    TMP_InputField i_7Amount;
    [SerializeField]
    TMP_InputField i_7Cost;
    [SerializeField]
    TMP_InputField i_7Total;
    [SerializeField]

    TMP_InputField i_FULLTOTAL;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
     /*  if ()
        {
           
        } */
    }
   public void calculate()
    {
        if (i_1Amount && i_1Cost == null)
        {
            i_1Total.text = string.Empty;
        }
        else if (i_1Amount && i_1Cost != null)
        {
            float cost1 = -1;
            Debug.Log(i_1Amount.text);
            Debug.Log(float.TryParse(i_1Cost.text, out cost1));
            float amount1 = -1;
            Debug.Log(float.TryParse(i_1Amount.text, out amount1));
            Debug.Log(i_1Total.text);
            Debug.Log(i_1Total);
            float total1 = amount1 * cost1;
            i_1Total.text = "$" + total1.ToString();
        }
        if (i_2Amount && i_2Cost == null)
        {
            i_2Total.text = string.Empty;
        }
        else if (i_2Amount && i_2Cost != null)
        {
            float cost2 = -1;
            Debug.Log(i_2Amount.text);
            Debug.Log(float.TryParse(i_2Cost.text, out cost2));
            float amount2 = -1;
            Debug.Log(float.TryParse(i_2Amount.text, out amount2));
            Debug.Log(i_2Total.text);
            Debug.Log(i_2Total);
            float total2 = amount2 * cost2;
            i_2Total.text = "$" + total2.ToString();
        }
        if (i_3Amount && i_3Cost == null)
        {
            i_3Total.text = string.Empty;
        }
        else if (i_3Amount && i_3Cost != null)
        {
            float cost3 = -1;
            Debug.Log(i_3Amount.text);
            Debug.Log(float.TryParse(i_3Cost.text, out cost3));
            float amount3 = -1;
            Debug.Log(float.TryParse(i_3Amount.text, out amount3));
            Debug.Log(i_3Total.text);
            Debug.Log(i_3Total);
            float total3 = amount3 * cost3;
            i_3Total.text = "$" + total3.ToString();
        }
        if (i_4Amount && i_4Cost == null)
        {
            i_4Total.text = string.Empty;
        }
        else if (i_4Amount && i_4Cost != null)
        {
            float cost4 = -1;
            Debug.Log(i_4Amount.text);
            Debug.Log(float.TryParse(i_4Cost.text, out cost4));
            float amount4 = -1;
            Debug.Log(float.TryParse(i_4Amount.text, out amount4));
            Debug.Log(i_4Total.text);
            Debug.Log(i_4Total);
            float total4 = amount4 * cost4;
            i_4Total.text = "$" + total4.ToString();
        }
        if (i_1Amount && i_1Cost == null)
        {
            i_1Total.text = string.Empty;
        }
        else if (i_5Amount && i_5Cost != null)
        {
            float cost5 = -1;
            Debug.Log(i_5Amount.text);
            Debug.Log(float.TryParse(i_5Cost.text, out cost5));
            float amount5 = -1;
            Debug.Log(float.TryParse(i_5Amount.text, out amount5));
            Debug.Log(i_5Total.text);
            Debug.Log(i_5Total);
            float total5 = amount5 * cost5;
            i_5Total.text = "$" + total5.ToString();
        }
        if (i_6Amount && i_6Cost == null)
        {
            i_6Total.text = string.Empty;
        }
        else if (i_6Amount && i_6Cost != null)
        {
            float cost6 = -1;
            Debug.Log(i_6Amount.text);
            Debug.Log(float.TryParse(i_6Cost.text, out cost6));
            float amount6 = -1;
            Debug.Log(float.TryParse(i_6Amount.text, out amount6));
            Debug.Log(i_6Total.text);
            Debug.Log(i_6Total);
            float total6 = amount6 * cost6;
            i_6Total.text = "$" + total6.ToString();
        }
        if (i_7Amount && i_7Cost == null)
        {
            i_7Total.text = string.Empty;
        }
        else if (i_7Amount && i_7Cost != null)
        {
            float cost7 = -1;
            Debug.Log(i_7Amount.text);
            Debug.Log(float.TryParse(i_7Cost.text, out cost7));
            float amount7 = -1;
            Debug.Log(float.TryParse(i_7Amount.text, out amount7));
            Debug.Log(i_7Total.text);
            Debug.Log(i_7Total);
            float total7 = amount7 * cost7;
            i_7Total.text = "$" + total7.ToString();
        }
        
    }
    }

