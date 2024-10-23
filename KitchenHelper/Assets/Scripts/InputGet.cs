using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InputGet : MonoBehaviour
{
    Button cal;
    [SerializeField]
    TMP_InputField i_eggamount;
    [SerializeField]
    TMP_InputField i_eggcost;
    [SerializeField]
    TMP_InputField i_eggtotal;
    [SerializeField]
    TMP_InputField i_flouramount;
    [SerializeField]
    TMP_InputField i_flourcost;
    [SerializeField]
    TMP_InputField i_flourtotal;
    [SerializeField]

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
        if (i_eggamount && i_eggcost == null)
        {
            i_eggtotal.text = string.Empty;
        }
        else if (i_eggamount && i_eggcost != null)
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
        if (i_flouramount && i_flourcost == null)
        {
            i_flourtotal.text = string.Empty;
        }
        else if (i_flourcost && i_flouramount != null)
        {
            float flourcost = -1;
            Debug.Log(i_flouramount.text);
            Debug.Log(float.TryParse(i_flourcost.text, out flourcost));
            float flouramount = -1;
            Debug.Log(float.TryParse(i_flouramount.text, out flouramount));
            Debug.Log(i_flourtotal.text);
            Debug.Log(i_flourtotal);
            float flourtotal = flouramount * flourcost;
            i_flourtotal.text = flourtotal.ToString();
        }
    }
}
