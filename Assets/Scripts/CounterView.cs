using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CounterView : MonoBehaviour
{
    [SerializeField] private Counter _counter;
    [SerializeField] private TextMeshProUGUI _countText;

    public void Refresh()
    {
        _countText.text = _counter.Count.ToString();
    }
}
