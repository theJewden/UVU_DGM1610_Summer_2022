using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextBehavior : MonoBehaviour
{
    public Text theText;
    public FloatData objData;

    private void Start()
    {
        theText = GetComponent<Text>();
        UpdateLabel();
    }

    public void UpdateLabel()
    {
        theText.text = objData.value.ToString();
    }
}