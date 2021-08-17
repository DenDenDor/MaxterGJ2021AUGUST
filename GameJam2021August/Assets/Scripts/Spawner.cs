using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
   [SerializeField] private Color[] _colors;
   [SerializeField] private Player _player;
   private void Start() {
      Player player = Instantiate(_player, transform.position, Quaternion.identity);
      int random = Random.Range(0,_colors.Length);
      player.Current_color = _colors[random];
   }
}
