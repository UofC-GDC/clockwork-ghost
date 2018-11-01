﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitQueue : MonoBehaviour
{
	[SerializeField] public List<UnitType> unitTypes = new List<UnitType>();
	[SerializeField] private int paper = 0;

	[SerializeField] private List<int> _queue = new List<int>();

	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{

	}

	public void queue(int i)
	{
		_queue.Add(i);
	}

	public void dequeue(int i)
	{
		_queue.Remove(i);
	}

	public void addPaper(int n)
	{
		paper += n;
	}

	public UnitType getNext()
	{
		for (var i = 0; i < _queue.Count; i++)
		{
			int t = _queue[i];
			if (unitTypes[_queue[i]].cost <= paper)
			{
				_queue.RemoveAt(i);
				paper -= unitTypes[t].cost;
				return unitTypes[t];
			}
		}
		return null;
	}

	[System.Serializable]
	public class UnitType
	{
		public GameObject UnitObject;
		public int cost;
		public float time;
	}
}