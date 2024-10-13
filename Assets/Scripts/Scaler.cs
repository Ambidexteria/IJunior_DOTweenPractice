using DG.Tweening;
using UnityEngine;

public class Scaler : MonoBehaviour
{
    [SerializeField] private float _targetScale;
    [SerializeField] private float _scalingSpeed;
    [SerializeField] private int _repeats;
    [SerializeField] private LoopType _loopType;
    [SerializeField] private Ease _easeType;

    private void Start()
    {
        transform.DOScale(_targetScale, _scalingSpeed).SetLoops(_repeats, _loopType).SetEase(_easeType);
    }
}
