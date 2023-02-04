using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateChatLines : MonoBehaviour
{
    [SerializeField] private GameObject _chatLinePrefab;
    [SerializeField] private GameObject _linesContainer;
    [SerializeField] private float _padding;
    [SerializeField] private float _maxLinesHeight;

    public void OnChatLine(string line)
    {
        Debug.Log(line);
        var h = 0f;
        for (var i = 0; i < _linesContainer.transform.childCount; i++)
        {
            h += _linesContainer.transform.GetChild(i).gameObject.GetComponent<ChatLineManager>().TotalHeight +
                    _padding;
        }

        var newChatLine = Instantiate(_chatLinePrefab, _linesContainer.transform);
        var chatLineManager = newChatLine.GetComponent<ChatLineManager>();
        chatLineManager.SetText(line);

        var rt = newChatLine.GetComponent<RectTransform>();
        rt.anchoredPosition -= new Vector2(0, h);

        h += chatLineManager.TotalHeight;
        if (h > _maxLinesHeight)
        {
            var lrt = _linesContainer.GetComponent<RectTransform>();
            lrt.offsetMax = new Vector2(lrt.offsetMax.x, h - _maxLinesHeight);
        }
    }
}
