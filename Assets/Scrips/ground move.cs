using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class groundmove : MonoBehaviour
{
    [SerializeField] private float _speed = 1.3f;
    [SerializeField] private float _width = 6f;
    private SpriteRenderer _renderer;
    private Vector2 _startsize;
  
    void Start()
    {
        _renderer = GetComponent<SpriteRenderer>();
        _startsize = new Vector2(
            x:_renderer.size.x,
            y:_renderer.size.y
            );
    }

   
    void Update()
    {
        _renderer.size = new Vector2(
            x: _renderer.size.x + _speed * Time.deltaTime,
            y: _renderer.size.y
            );
        if ( _renderer.size.x > _width )
        {
            _renderer.size = _startsize; 
        }
    }
}
