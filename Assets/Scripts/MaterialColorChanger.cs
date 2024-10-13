using DG.Tweening;
using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]
public class MaterialColorChanger : MonoBehaviour
{
    [SerializeField] private Color[] _color;
    [SerializeField] private float _duration;
    [SerializeField] private bool _loop;
    [SerializeField] private int _repeats;
    [SerializeField] private LoopType _loopType;

    private Sequence _sequence;
    private Material _material;

    private void Awake()
    {
        _material = GetComponent<MeshRenderer>().material;

        InitializeColorChangingSequence();
    }

    private void Start()
    {
        _sequence.Play();
    }

    private void InitializeColorChangingSequence()
    {
        _sequence = DOTween.Sequence();
        _sequence.Pause();

        foreach (var color in _color)
            _sequence.Append(_material.DOColor(color, _duration));

        if (_loop)
            _sequence.SetLoops(_repeats, _loopType);
    }
}
