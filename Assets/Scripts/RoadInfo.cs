using System;
using UnityEngine;

[RequireComponent(typeof(Renderer))]
public class RoadInfo : MonoBehaviour
{
    private Renderer _renderer;
    private float _width;
    private float _length;
    
    public float Width => _width;
    public float Length => _length;

    private void Awake()
    {
        _renderer = GetComponent<Renderer>();
        SetSize();
    }

    private void SetSize()
    {
        _width = _renderer.bounds.size.x;
        _length = _renderer.bounds.size.z;
    }
}
