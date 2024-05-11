using System.Collections;
using TMPro;
using UnityEngine;

public class Counter : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _counter;

    private bool _isCounting = false;
    private int _count = 0;
    private float _timeInterval = 0.5f;

    private void OnEnable()
    {
        StartCoroutine(CounterRoutine());
    }

    private IEnumerator CounterRoutine()
    {
        var wait = new WaitForSeconds(_timeInterval);

        while(_count <= int.MaxValue)
        {
            if (_isCounting)
            {
                _counter.text = _count.ToString();

                yield return wait;

                _count++;
            }
            else
            {
                yield return null;
            }
        }
    }

    public void PressButton()
    {
        _isCounting = !_isCounting;
    }
}
