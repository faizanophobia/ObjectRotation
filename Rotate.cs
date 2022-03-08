using UnityEngine;

public class Rotate : MonoBehaviour
{
    float _minspeed;
    float _maxspeed;

    private void Start()
    {
        _minspeed = 1;
        _maxspeed = 10;
    }

    private void FixedUpdate()
    {
        if (_minspeed <= _maxspeed)
        {
            _minspeed++;
            
        }
        Debug.Log(_minspeed);
        gameObject.transform.Rotate(0, 0, _minspeed);
        
    }
}
