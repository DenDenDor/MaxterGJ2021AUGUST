using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Item : ScriptableObject
{
	[SerializeField] protected string _name;
	[SerializeField] protected Sprite _sprite;


	[SerializeField] private Vector2 _treasureFactor;
	[SerializeField] protected Vector2 _protectionFactor;
	[SerializeField] private Vector2 _treatFactor;
	[SerializeField] private Vector2 _attackFactor;



	public Vector2 AttackFactor => _attackFactor;
	public Vector2 TreatFactor => _treatFactor;
	public Vector2 TreasureFactor => TreasureFactor;
	public Vector2 ProtectionFactor => _protectionFactor;



	public string Name => _name;
	public Sprite Sprite => _sprite;

	protected void ShowInfo() {
		Debug.Log($"I am {_name}");
	}
}
