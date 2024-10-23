using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InputGet : MonoBehaviour
{
    
    Button cal;
    [SerializeField]
    TMP_InputField field;
    [SerializeField]
    TMP_InputField i_eggamount;
    [SerializeField]
    TMP_InputField i_eggcost;
    [SerializeField]
    TMP_InputField i_eggtotal;
    // Start is called before the first frame update
    void Start()
    {
        i_eggcost = GetComponent<TMP_InputField>();
        i_eggamount = GetComponent<TMP_InputField>();
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
        float eggcost = -1;
        Debug.Log(i_eggamount.text);
        Debug.Log(float.TryParse(i_eggcost.text, out eggcost));
        float eggamount = -1;
        Debug.Log(float.TryParse(i_eggamount.text, out eggamount));
        Debug.Log(i_eggtotal.text);
        Debug.Log(i_eggtotal);
        float eggtotal = eggamount * eggcost;
        i_eggtotal.text = eggtotal.ToString();
    }
}
