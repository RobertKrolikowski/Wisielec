using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ButtonHandler : MonoBehaviour
{
    public void Test(TextMeshProUGUI pass)
    {
        TextMeshProUGUI letter = transform.Find("Text").GetComponent<TextMeshProUGUI>();
        Debug.Log(letter.text);
        pass.text = letter.text;
        Debug.Log(pass.text);
    }

    public void Check(GameObject passObj)
    {
        passObj.GetComponent<PasswordHandler>().CheckLetter(transform.Find("Text").GetComponent<TextMeshProUGUI>().text);
    }
}
