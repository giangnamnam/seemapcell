﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by LINQ to SQL template for T4 C#
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using Microsoft.SqlServer.Types;

namespace Linq2SqlGeography.LinqSql.FromMap
{
	[DatabaseAttribute(Name=@"SqlSpatialJiangmeng")]
	public partial class DataClasses1DataContext : DataContext
	{
		private static MappingSource mappingSource = new AttributeMappingSource();
		
		#region Extensibility Method Definitions
		partial void OnCreated();
		partial void Insert城市内部主要交通干道(Linq2SqlGeography.城市内部主要交通干道 instance);
		partial void Update城市内部主要交通干道(Linq2SqlGeography.城市内部主要交通干道 instance);
		partial void Delete城市内部主要交通干道(Linq2SqlGeography.城市内部主要交通干道 instance);
		partial void Insert城市内部主要交通干道abc(Linq2SqlGeography.城市内部主要交通干道abc instance);
		partial void Update城市内部主要交通干道abc(Linq2SqlGeography.城市内部主要交通干道abc instance);
		partial void Delete城市内部主要交通干道abc(Linq2SqlGeography.城市内部主要交通干道abc instance);
		#endregion
		
		#region Construction
		public DataClasses1DataContext() :
			base(global::Linq2SqlGeography.Properties.Settings.Default.SqlSpatialTestConnectionString, mappingSource)
		{
			OnCreated();
		}
	
		public DataClasses1DataContext(string connection) :
			base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) :
			base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, MappingSource mappingSource) :
			base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, MappingSource mappingSource) :
			base(connection, mappingSource)
		{
			OnCreated();
		}
		#endregion
		
		#region Tables
		public Table<Linq2SqlGeography.城市内部主要交通干道> 城市内部主要交通干道
		{
			get { return GetTable<Linq2SqlGeography.城市内部主要交通干道>(); }
		}
		
		public Table<Linq2SqlGeography.城市内部主要交通干道abc> 城市内部主要交通干道abc
		{
			get { return GetTable<Linq2SqlGeography.城市内部主要交通干道abc>(); }
		}
		
		#endregion
	}
}

namespace Linq2SqlGeography
{	
	[Table(Name=@"dbo.城市内部主要交通干道")]
	public partial class 城市内部主要交通干道 : INotifyPropertyChanging, INotifyPropertyChanged
	{
		#region Property Change Event Handling
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		public event PropertyChangingEventHandler PropertyChanging;
		public event PropertyChangedEventHandler PropertyChanged;
		
		public virtual void SendPropertyChanging()
		{
			if (PropertyChanging != null) {
				PropertyChanging(this, emptyChangingEventArgs);
			}
		}
			
		public virtual void SendPropertyChanged(String propertyName)
		{
			if (PropertyChanged != null) {
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		#endregion
		
		#region Extensibility Method Definitions
		partial void OnLoaded();
		partial void OnValidate(ChangeAction action);
		partial void OnCreated();
		#endregion

		#region Construction
		public 城市内部主要交通干道()
		{
			OnCreated();
		}
		#endregion

		#region Column Mappings
		partial void On编码Changing(string value);
		partial void On编码Changed();
		private string _编码;
		[Column(Storage=@"_编码", DbType=@"VarChar(4)")]
		public string 编码
		{
			get { return _编码; }
			set {
				if (_编码 != value) {
					On编码Changing(value);
					SendPropertyChanging();
					_编码 = value;
					SendPropertyChanged("编码");
					On编码Changed();
				}
			}
		}
		
		partial void OnMI_STYLEChanging(string value);
		partial void OnMI_STYLEChanged();
		private string _MI_STYLE;
		[Column(Storage=@"_MI_STYLE", DbType=@"VarChar(254)")]
		public string MI_STYLE
		{
			get { return _MI_STYLE; }
			set {
				if (_MI_STYLE != value) {
					OnMI_STYLEChanging(value);
					SendPropertyChanging();
					_MI_STYLE = value;
					SendPropertyChanged("MI_STYLE");
					OnMI_STYLEChanged();
				}
			}
		}
		
		partial void OnMI_PRINXChanging(int value);
		partial void OnMI_PRINXChanged();
		private int _MI_PRINX;
		[Column(Storage=@"_MI_PRINX", AutoSync=AutoSync.OnInsert, DbType=@"Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true, UpdateCheck=UpdateCheck.Never)]
		public int MI_PRINX
		{
			get { return _MI_PRINX; }
			set {
				if (_MI_PRINX != value) {
					OnMI_PRINXChanging(value);
					SendPropertyChanging();
					_MI_PRINX = value;
					SendPropertyChanged("MI_PRINX");
					OnMI_PRINXChanged();
				}
			}
		}
		
		partial void OnSP_GEOMETRYChanging(Microsoft.SqlServer.Types.SqlGeometry value);
		partial void OnSP_GEOMETRYChanged();
		private Microsoft.SqlServer.Types.SqlGeometry _SP_GEOMETRY;
		[Column(Storage=@"_SP_GEOMETRY", UpdateCheck=UpdateCheck.Never)]
		public Microsoft.SqlServer.Types.SqlGeometry SP_GEOMETRY
		{
			get { return _SP_GEOMETRY; }
			set {
				if (_SP_GEOMETRY != value) {
					OnSP_GEOMETRYChanging(value);
					SendPropertyChanging();
					_SP_GEOMETRY = value;
					SendPropertyChanged("SP_GEOMETRY");
					OnSP_GEOMETRYChanged();
				}
			}
		}
		
		#endregion
	}
}

namespace Linq2SqlGeography
{	
	[Table(Name=@"dbo.城市内部主要交通干道abc")]
	public partial class 城市内部主要交通干道abc : INotifyPropertyChanging, INotifyPropertyChanged
	{
		#region Property Change Event Handling
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		public event PropertyChangingEventHandler PropertyChanging;
		public event PropertyChangedEventHandler PropertyChanged;
		
		public virtual void SendPropertyChanging()
		{
			if (PropertyChanging != null) {
				PropertyChanging(this, emptyChangingEventArgs);
			}
		}
			
		public virtual void SendPropertyChanged(String propertyName)
		{
			if (PropertyChanged != null) {
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		#endregion
		
		#region Extensibility Method Definitions
		partial void OnLoaded();
		partial void OnValidate(ChangeAction action);
		partial void OnCreated();
		#endregion

		#region Construction
		public 城市内部主要交通干道abc()
		{
			OnCreated();
		}
		#endregion

		#region Column Mappings
		partial void On编码Changing(string value);
		partial void On编码Changed();
		private string _编码;
		[Column(Storage=@"_编码", DbType=@"VarChar(4)")]
		public string 编码
		{
			get { return _编码; }
			set {
				if (_编码 != value) {
					On编码Changing(value);
					SendPropertyChanging();
					_编码 = value;
					SendPropertyChanged("编码");
					On编码Changed();
				}
			}
		}
		
		partial void OnMI_STYLEChanging(string value);
		partial void OnMI_STYLEChanged();
		private string _MI_STYLE;
		[Column(Storage=@"_MI_STYLE", DbType=@"VarChar(254)")]
		public string MI_STYLE
		{
			get { return _MI_STYLE; }
			set {
				if (_MI_STYLE != value) {
					OnMI_STYLEChanging(value);
					SendPropertyChanging();
					_MI_STYLE = value;
					SendPropertyChanged("MI_STYLE");
					OnMI_STYLEChanged();
				}
			}
		}
		
		partial void OnMI_PRINXChanging(int value);
		partial void OnMI_PRINXChanged();
		private int _MI_PRINX;
		[Column(Storage=@"_MI_PRINX", AutoSync=AutoSync.OnInsert, DbType=@"Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true, UpdateCheck=UpdateCheck.Never)]
		public int MI_PRINX
		{
			get { return _MI_PRINX; }
			set {
				if (_MI_PRINX != value) {
					OnMI_PRINXChanging(value);
					SendPropertyChanging();
					_MI_PRINX = value;
					SendPropertyChanged("MI_PRINX");
					OnMI_PRINXChanged();
				}
			}
		}
		
		partial void OnSP_GEOMETRYChanging(Binary value);
		partial void OnSP_GEOMETRYChanged();
		private Binary _SP_GEOMETRY;
		[Column(Storage=@"_SP_GEOMETRY", DbType=@"VarBinary(1)", UpdateCheck=UpdateCheck.Never)]
		public Binary SP_GEOMETRY
		{
			get { return _SP_GEOMETRY; }
			set {
				if (_SP_GEOMETRY != value) {
					OnSP_GEOMETRYChanging(value);
					SendPropertyChanging();
					_SP_GEOMETRY = value;
					SendPropertyChanged("SP_GEOMETRY");
					OnSP_GEOMETRYChanged();
				}
			}
		}
		
		#endregion
	}
}
#pragma warning restore 1591