using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class TextChanger : MonoBehaviour
{
    [SerializeField] private float _textChangingDuration = 2f;
    [SerializeField] private float _delay = 1f;
    [SerializeField] private string _replacingText;
    [SerializeField] private string _appendingText;
    [SerializeField] private string _hackingText;
    [SerializeField] private Color _hackingTextColor;
    [SerializeField] private float _colorChangingDuration = 2f;
    [SerializeField] private ScrambleMode _scrambleMode;
    [SerializeField] private int _repeats;
    [SerializeField] private LoopType _loopType;

    private Text _textChanging;
    private Sequence _sequence;

    private void Awake()
    {
        _textChanging = GetComponent<Text>();

        InitializeTextChangingSequence();
    }

    private void Start()
    {
        _sequence.Play();
    }

    private void InitializeTextChangingSequence()
    {
        _sequence = DOTween.Sequence();
        _sequence.Pause();

        _sequence.Append(_textChanging.DOText(_replacingText, _textChangingDuration).SetDelay(_delay));
        _sequence.Append(_textChanging.DOText(_appendingText, _textChangingDuration).SetRelative(true).SetDelay(_delay));
        _sequence.Append(_textChanging.DOColor(_hackingTextColor, _colorChangingDuration));
        _sequence.Append(_textChanging.DOText(_hackingText, _textChangingDuration, true, _scrambleMode).SetRelative(false).SetDelay(_delay));
        _sequence.SetLoops(_repeats, _loopType);
    }
}
