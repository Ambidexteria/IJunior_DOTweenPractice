using DG.Tweening;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private bool _xAxis;
    [SerializeField] private bool _yAxis;
    [SerializeField] private bool _zAxis;

    [SerializeField] private float _xRotationSpeed;
    [SerializeField] private float _yRotationSpeed;
    [SerializeField] private float _zRotationSpeed;

    [SerializeField] private int _repeats = -1;
    [SerializeField] private LoopType _loopType = LoopType.Incremental;

    private Sequence _rotationSequence;
    private Vector3 _endRotationValue;
    private float _rotationTime = 1f;

    private void Awake()
    {
        _rotationSequence = DOTween.Sequence();
        _endRotationValue = new Vector3();

        if (_xAxis)
            _endRotationValue.x = _xRotationSpeed;

        if (_yAxis)
            _endRotationValue.y = _yRotationSpeed;

        if (_zAxis)
            _endRotationValue.z = _zRotationSpeed;
    }

    private void Start()
    {
        transform.DORotate(_endRotationValue, _rotationTime).SetLoops(_repeats, _loopType).SetEase(Ease.Linear);
    }
}
