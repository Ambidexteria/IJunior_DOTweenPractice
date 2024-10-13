using UnityEngine;
using DG.Tweening;

public class Mover : MonoBehaviour
{
    [SerializeField] private Vector3 _position;
    [SerializeField] private float _duration;
    [SerializeField] private int _repeats;
    [SerializeField] private LoopType _looptype;
    [SerializeField] private Ease _easeType;

    private void Start()
    {
        transform.DOMove(_position, _duration).SetLoops(_repeats, _looptype).SetEase(_easeType);
    }
}
