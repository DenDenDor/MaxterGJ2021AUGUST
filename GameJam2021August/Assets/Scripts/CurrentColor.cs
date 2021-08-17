using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrentColor : MonoBehaviour
{
   private bool _isFree;

    public bool IsFree { get => _isFree; set => _isFree = value; }
    public Color Color { get => _color; set => _color = value; }

    [SerializeField] private Color _color;
}
