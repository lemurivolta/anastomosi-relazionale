using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Assertions;

public class ChatLineManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _tmPro;
    [SerializeField] private TextMeshProUGUI _nameTmPro;
    [SerializeField] private GameObject _avatar;

    private void Start()
    {
        Assert.IsNotNull(_tmPro);
        Assert.IsNotNull(_nameTmPro);
        Assert.IsNotNull(_avatar);
    }

    public void SetText(string text)
    {
        _tmPro.text = text;

        Destroy(_avatar);
        Destroy(_nameTmPro);
        var textRectTransform = _tmPro.GetComponent<RectTransform>();
        textRectTransform.offsetMax = new Vector2(
            textRectTransform.offsetMax.x, 0);
        textRectTransform.offsetMin = new Vector2(0,
            textRectTransform.offsetMin.y);
    }

    public float TotalHeight 
    {
        get => /*_nameTmPro.preferredHeight + _tmPro.preferredHeight;*/ _tmPro.preferredHeight;
    }
}
