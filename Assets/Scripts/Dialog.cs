using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Dialog : MonoBehaviour
{
    [TextArea(4,4)]
    public string[] dialogList;
    public int currentDialog;
    public TMP_Text currentText;

    // Update is called once per frame
    void Update()
    {
        currentText.text = dialogList[currentDialog];
    }

    public void PreviousDialogue() 
    {
        if (currentDialog - 1 >= 0 ) currentDialog--;
    }

    public void NextDialogue() 
    {
        if (currentDialog + 1 <= dialogList.Length - 1) currentDialog++;
    }
}
