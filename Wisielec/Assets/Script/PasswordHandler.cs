using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using TMPro;
using System;
using System.Net;
using Unity.VisualScripting;
using System.Text;

public class PasswordHandler : MonoBehaviour
{
    string hiddenPassword;
    public string password { get; set; }
    
    // Start is called before the first frame update
    void Start()
    {
        hiddenPassword = "TEST PASS?";
        password = String.Join ("", hiddenPassword.Select(x => x == ' ' ? ' ' : '_'));
        Debug.Log(hiddenPassword);
        Debug.Log(password);
        Debug.Log(GetComponent<TextMeshProUGUI>().text);
        GetComponent<TextMeshProUGUI>().text = password;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CheckLetter(string letter)
    {
        //List<int> indices = new List<int>();
        //for (int i = 0; i < hiddenPassword.Length; i++)
        //{

        //}

        var indices = hiddenPassword.AllIndexesOf(letter);
        StringBuilder sb = new StringBuilder(password);
        foreach (var index in indices)
        {
            sb[index] = letter.ToCharArray().FirstOrDefault();
        }
        password = sb.ToString();
        GetComponent<TextMeshProUGUI>().text = password;
        Debug.Log(indices.Count());

    }

    private bool IsPasswordGuessed()
    {
        return password.Any(x => x == '_');
    }

}
