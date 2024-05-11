using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class Counter : MonoBehaviour
{
    [SerializeField] private float _timeInterval = 0.5f;

    public UnityEvent CountChanged;

    public int Count { get; private set; }

    private bool _isCounting = false;

    private void OnEnable()
    {
        StartCoroutine(CounterRoutine());
    }

    private IEnumerator CounterRoutine()
    {
        var wait = new WaitForSeconds(_timeInterval);

        while (Count <= int.MaxValue)
        {
            if (_isCounting)
            {
                Count++;

                CountChanged?.Invoke();

                yield return wait;
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
