using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChatLinesVisibility : MonoBehaviour
{
    [SerializeField] private GameObject _chatLines;

    public void NodeStarted()
    {
        _chatLines.SetActive(true);
    }
}
