﻿using UnityEngine;

namespace SphericalCow.OldCode
{
	[System.Serializable]
	public class AbstractStatPercentagePair
	{
		[SerializeField] private OldAbstractStat stat;
		[Range(0,100)] [SerializeField] private int percentage;
		
		public OldAbstractStat Stat
		{
			get
			{
				return this.stat;
			}
		}
		
		public int Percentage
		{
			get
			{
				return this.percentage;
			}
		}
		
	}
}