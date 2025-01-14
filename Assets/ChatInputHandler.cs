﻿using Fumbbl;
using TMPro;
using UnityEngine;

public class ChatInputHandler : MonoBehaviour
{
    private TMP_InputField field;

    private void Start()
    {
        field = GetComponent<TMP_InputField>();
        field.placeholder.GetComponent<TMP_Text>().text = "Type here to chat.";
    }
    public void OnChatEntered()
    {
        MainHandler.Instance.AddChatEntry(field.text);
        field.text = "";
    }
}
