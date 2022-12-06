using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Letter : MonoBehaviour
{

    [SerializeField] private Image Background;
    [SerializeField] private TextMeshProUGUI textMeshPro;
    
    public StateButton State { get; set; }

    public enum StateButton
    {
        NonSelected,
        Miss,
        Guess
    }

     
    // Start is called before the first frame update
    void Start()
    {
        State = StateButton.NonSelected;
    }

    // Update is called once per frame
    void Update()
    {
           
    }

       

}
