using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
     [SerializeField] private List< SpriteRenderer> _partsOfBody = new List<SpriteRenderer>();
    private Color _current_color;

    public Color Current_color { get => _current_color; set => _current_color = value; }

    private void Start() {
       foreach (SpriteRenderer partOfBody in _partsOfBody)
       {
           partOfBody.color = Current_color;
       }
   }
}
