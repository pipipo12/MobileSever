﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18051
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MobileSever.Models
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="DataSource")]
	public partial class MobileGameDataDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    #endregion
		
		public MobileGameDataDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["DataSourceConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public MobileGameDataDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MobileGameDataDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MobileGameDataDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MobileGameDataDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<tblUser> tblUsers
		{
			get
			{
				return this.GetTable<tblUser>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tblUser")]
	public partial class tblUser
	{
		
		private string _UserName;
		
		private string _Password;
		
		public tblUser()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserName", DbType="NChar(10)")]
		public string UserName
		{
			get
			{
				return this._UserName;
			}
			set
			{
				if ((this._UserName != value))
				{
					this._UserName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="NChar(10)")]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this._Password = value;
				}
			}
		}
	}
}
#pragma warning restore 1591