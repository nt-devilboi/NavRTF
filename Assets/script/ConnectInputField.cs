using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ConnectInputField : MonoBehaviour
{
    private TMP_InputField CurInputField;
    
    [Header("строка в которую будет идти текст")]
    public TMP_InputField ConnectInputF;
    
    void Start()
    {
        CurInputField = GetComponent<TMP_InputField>();
    }

    // Update is called once per frame
    void Update()
    {
        ConnectInputF.text = CurInputField.text;
    }
}
