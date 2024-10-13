using System;
using UnityEngine;

public class Showcase : MonoBehaviour
{
    [SerializeField] private ShowcaseExample _example;
    [SerializeField] private ButtonClickHandler _clickHandler;

    public event Action<Showcase> Activated;

    private void OnEnable()
    {
        _clickHandler.Clicked += Show;
    }

    private void OnDisable()
    {
        _clickHandler.Clicked -= Show;
    }

    public void Show()
    {
        Activated?.Invoke(this);
        _example.gameObject.SetActive(true);
    }

    public void Hide()
    {
        _example.gameObject.SetActive(false);
    }
}
