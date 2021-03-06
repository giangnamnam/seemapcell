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

namespace Linq2SqlGeography.LinqSql.ToMap
{
	[DatabaseAttribute(Name=@"SqlSpatialJiangmeng")]
	public partial class DataClasses1DataContext : DataContext
	{
		private static MappingSource mappingSource = new AttributeMappingSource();
		
		#region Extensibility Method Definitions
		partial void OnCreated();
		partial void InsertEventLocating(Linq2SqlGeography.EventLocating instance);
		partial void UpdateEventLocating(Linq2SqlGeography.EventLocating instance);
		partial void DeleteEventLocating(Linq2SqlGeography.EventLocating instance);
		partial void InsertCellTracing(Linq2SqlGeography.CellTracing instance);
		partial void UpdateCellTracing(Linq2SqlGeography.CellTracing instance);
		partial void DeleteCellTracing(Linq2SqlGeography.CellTracing instance);
		partial void InsertCELLTRACINGqq(Linq2SqlGeography.CELLTRACINGqq instance);
		partial void UpdateCELLTRACINGqq(Linq2SqlGeography.CELLTRACINGqq instance);
		partial void DeleteCELLTRACINGqq(Linq2SqlGeography.CELLTRACINGqq instance);
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
		public Table<Linq2SqlGeography.EventLocating> EventLocating
		{
			get { return GetTable<Linq2SqlGeography.EventLocating>(); }
		}
		
		public Table<Linq2SqlGeography.CellTracing> CellTracing
		{
			get { return GetTable<Linq2SqlGeography.CellTracing>(); }
		}
		
		public Table<Linq2SqlGeography.CELLTRACINGqq> CELLTRACINGqq
		{
			get { return GetTable<Linq2SqlGeography.CELLTRACINGqq>(); }
		}
		
		#endregion
	}
}

namespace Linq2SqlGeography
{	
	[Table(Name=@"dbo.EventLocating")]
	public partial class EventLocating : INotifyPropertyChanging, INotifyPropertyChanged
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
		#endregion

		#region Construction
		public EventLocating()
		{
		}
		#endregion

		#region Column Mappings
		partial void OneventsChanging(string value);
		partial void OneventsChanged();
		private string _SiteName;
		[Column(Storage=@"_SiteName", DbType=@"VarChar(30)")]
		public string events
		{
			get { return _SiteName; }
			set {
				if (_SiteName != value) {
					OneventsChanging(value);
					SendPropertyChanging();
					_SiteName = value;
					SendPropertyChanged("events");
					OneventsChanged();
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
		[Column(Storage=@"_MI_PRINX", AutoSync=AutoSync.Always, DbType=@"Int NOT NULL IDENTITY", IsDbGenerated=true, CanBeNull=false)]
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
	[Table(Name=@"dbo.CellTracing")]
	public partial class CellTracing : INotifyPropertyChanging, INotifyPropertyChanged
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
		#endregion

		#region Construction
		public CellTracing()
		{
		}
		#endregion

		#region Column Mappings
		partial void OncellChanging(string value);
		partial void OncellChanged();
		private string _SiteName;
		[Column(Storage=@"_SiteName", DbType=@"VarChar(30)")]
		public string cell
		{
			get { return _SiteName; }
			set {
				if (_SiteName != value) {
					OncellChanging(value);
					SendPropertyChanging();
					_SiteName = value;
					SendPropertyChanged("cell");
					OncellChanged();
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
		[Column(Storage=@"_MI_PRINX", AutoSync=AutoSync.Always, DbType=@"Int NOT NULL IDENTITY", IsDbGenerated=true, CanBeNull=false)]
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
	[Table(Name=@"dbo.CELLTRACINGqq")]
	public partial class CELLTRACINGqq : INotifyPropertyChanging, INotifyPropertyChanged
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
		#endregion

		#region Construction
		public CELLTRACINGqq()
		{
		}
		#endregion

		#region Column Mappings
		partial void OnSiteNameChanging(string value);
		partial void OnSiteNameChanged();
		private string _SiteName;
		[Column(Storage=@"_SiteName", DbType=@"VarChar(30)")]
		public string SiteName
		{
			get { return _SiteName; }
			set {
				if (_SiteName != value) {
					OnSiteNameChanging(value);
					SendPropertyChanging();
					_SiteName = value;
					SendPropertyChanged("SiteName");
					OnSiteNameChanged();
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
		[Column(Storage=@"_MI_PRINX", AutoSync=AutoSync.Always, DbType=@"Int NOT NULL IDENTITY", IsDbGenerated=true, CanBeNull=false)]
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