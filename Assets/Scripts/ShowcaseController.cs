using UnityEngine;

public class ShowcaseController : MonoBehaviour
{
    [SerializeField] private Showcase[] _showcases;

    private Showcase _currentShowcase;

    private void OnEnable()
    {
        foreach (var showcase in _showcases)
        {
            showcase.Activated += ChangeShowcase;
        }
    }

    private void OnDisable()
    {
        foreach (var showcase in _showcases)
        {
            showcase.Activated -= ChangeShowcase;
        }
    }

    private void ChangeShowcase(Showcase showcase)
    {
        if (_currentShowcase == null)
        {
            _currentShowcase = showcase;
            return;
        }
        else
        {
            if (_currentShowcase == showcase)
            {
                return;
            }
            else
            {
                if (_currentShowcase != null)
                {
                    _currentShowcase.Hide();
                }

                _currentShowcase = showcase;
            }
        }
    }
}
