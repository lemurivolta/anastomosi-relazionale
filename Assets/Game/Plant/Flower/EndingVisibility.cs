using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndingVisibility : MonoBehaviour
{
    [SerializeField] private GameObject _ending;

    public void OnAllNodesExplored()
    {
        _ending.SetActive(true);
    }
}
