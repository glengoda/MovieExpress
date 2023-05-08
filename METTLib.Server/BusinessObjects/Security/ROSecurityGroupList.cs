﻿// Generated 27 Jul 2018 08:06 - Singular Systems Object Generator Version 2.2.693
//<auto-generated/>
using System;
using Csla;
using Csla.Serialization;
using Csla.Data;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Singular;
using System.Data;
using System.Data.SqlClient;


namespace MELib.Security
{
	[Serializable]
	public class ROSecurityGroupList
	 : MEReadOnlyListBase<ROSecurityGroupList, ROSecurityGroup>
	{
		#region " Business Methods "

		public ROSecurityGroup GetItem(int SecurityGroupID)
		{
			foreach (ROSecurityGroup child in this)
			{
				if (child.SecurityGroupID == SecurityGroupID)
				{
					return child;
				}
			}
			return null;
		}

		public override string ToString()
		{
			return "RO Securitygroups";
		}

		#endregion

		#region " Data Access "

		[Serializable]
		public class Criteria
			: CriteriaBase<Criteria>
		{
			public bool? FilterList = null;
			public Criteria()
			{
				FilterList = null;
			}

		}

		public static ROSecurityGroupList NewROSecurityGroupList()
		{
			return new ROSecurityGroupList();
		}

		public ROSecurityGroupList()
		{
			// must have parameter-less constructor
		}

		public static ROSecurityGroupList GetROSecurityGroupList()
		{
			return DataPortal.Fetch<ROSecurityGroupList>(new Criteria());
		}

		public static ROSecurityGroupList GetROSecurityGroupList(bool? FilterList)
		{
			return DataPortal.Fetch<ROSecurityGroupList>(new Criteria { FilterList = FilterList });
		}

		protected void Fetch(SafeDataReader sdr)
		{
			this.RaiseListChangedEvents = false;
			this.IsReadOnly = false;
			while (sdr.Read())
			{
				this.Add(ROSecurityGroup.GetROSecurityGroup(sdr));
			}
			this.IsReadOnly = true;
			this.RaiseListChangedEvents = true;
		}

		protected override void DataPortal_Fetch(Object criteria)
		{
			Criteria crit = (Criteria)criteria;
			using (SqlConnection cn = new SqlConnection(Singular.Settings.ConnectionString))
			{
				cn.Open();
				try
				{
					using (SqlCommand cm = cn.CreateCommand())
					{
						cm.CommandType = CommandType.StoredProcedure;
						cm.CommandText = "GetProcs.getROSecurityGroupList";
						cm.Parameters.AddWithValue("@FilterList", crit.FilterList);
						using (SafeDataReader sdr = new SafeDataReader(cm.ExecuteReader()))
						{
							Fetch(sdr);
						}
					}
				}
				finally
				{
					cn.Close();
				}
			}
		}

		#endregion

	}

}