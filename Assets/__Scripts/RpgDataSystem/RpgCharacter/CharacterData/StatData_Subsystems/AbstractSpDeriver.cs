﻿using UnityEngine;
using Guid = System.Guid;
using System.Collections.Generic;

namespace SphericalCow
{
	/// <summary>
	/// 	Represents a collection of linked stats that contribute to the SP of the StatData holding this object
	/// </summary>
	public abstract class AbstractSpDeriver
	{
		private int derivedSpPool = 0;
		private SaveableGuid statId;
		
		
		/// <summary>
		/// 	Base constructor needs the Guid represented by the StatData holding this deriver
		/// </summary>
		public AbstractSpDeriver(Guid newStatId)
		{
			this.statId = new SaveableGuid(newStatId);
		}
		
		
		
		/// <summary>
		/// 	Aquire SP that derive from linked stats and their percentage of SP contribution.
		/// 	This method varies on the type of stat (Base, Secondary, Skill)
		/// </summary>
		public abstract void DeriveSp(List<StatData> appliedStats);
		
		
		
		/// <summary>
		/// 	The SP that derives from linked stats for this current stat referencing this deriver
		/// </summary>
		public int DerivedSpPool
		{
			get
			{
				return this.derivedSpPool;
			}
			
			protected set
			{
				this.derivedSpPool = value;
			}
		}
		
		
		/// <summary>
		/// 	The ID of the current stat referencing this deriver
		/// </summary>
		public Guid StatId
		{
			get
			{
				return this.statId.GuidData;
			}
		}
		
		
	}
}
