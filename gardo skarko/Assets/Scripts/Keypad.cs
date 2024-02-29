using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Keypad : MonoBehaviour
{
    public TMP_InputField charHolder;
    public GameObject button1;
    public GameObject button2;
    public GameObject button3;
    public GameObject button4;
    public GameObject button5;
    public GameObject button6;
    public GameObject button7;
    public GameObject button8;
    public GameObject button9;
    public GameObject button0;
    public GameObject clearButton;
    public GameObject enterButton;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            charHolder.text = charHolder.text + "1";
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            charHolder.text = charHolder.text + "2";
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            charHolder.text = charHolder.text + "3";
        }

        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            charHolder.text = charHolder.text + "4";
        }

        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            charHolder.text = charHolder.text + "5";
        }

        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            charHolder.text = charHolder.text + "6";
        }

        if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            charHolder.text = charHolder.text + "7";
        }

        if (Input.GetKeyDown(KeyCode.Alpha8))
        {
            charHolder.text = charHolder.text + "8";
        }

        if (Input.GetKeyDown(KeyCode.Alpha9))
        {
            charHolder.text = charHolder.text + "9";
        }

        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            charHolder.text = charHolder.text + "0";
        }

        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            charHolder.text = null;
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (charHolder.text == "42")
            {
                Debug.Log("yarito");
            }
            else
            {
                Debug.Log("don larma");
            }
        }
    }
}
