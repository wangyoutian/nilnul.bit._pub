using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.logic.proposition.op
{
	/// <summary>
	/// this is the class to generate an instance that:
	///  categories all the relations between two propostions.
	/// </summary>
	public partial class Relation
	{

		static private readonly Relation _Instance = new Relation();
		static public Relation Instance
		{
			get
			{
				return _Instance;
			}
		}
		private Relation()
		{
		}
				
	}
	/// <summary>
	/// this is the class to generate an instance that:
	///		is the relation between two propostions.
	/// </summary>
	public class RelationInstance
	{

		public RelationInstance()
		{
		}
					
		
	}

	public partial interface RelationI
	{
		
	}

}
