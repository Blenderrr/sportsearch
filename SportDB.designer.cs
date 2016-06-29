﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplicationSportSearch
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="SportSearch")]
	public partial class SportDBDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Определения метода расширяемости
    partial void OnCreated();
    partial void InsertMainSport(MainSport instance);
    partial void UpdateMainSport(MainSport instance);
    partial void DeleteMainSport(MainSport instance);
    #endregion
		
		public SportDBDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["SportSearchConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public SportDBDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SportDBDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SportDBDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SportDBDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<MainSport> MainSport
		{
			get
			{
				return this.GetTable<MainSport>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.MainSport")]
	public partial class MainSport : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Имя;
		
		private string _Фамилия;
		
		private System.Nullable<int> _Возраст;
		
		private System.Nullable<int> _Вес;
		
		private System.Nullable<int> _КолТравм;
		
		private string _Соревнование;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnИмяChanging(string value);
    partial void OnИмяChanged();
    partial void OnФамилияChanging(string value);
    partial void OnФамилияChanged();
    partial void OnВозрастChanging(System.Nullable<int> value);
    partial void OnВозрастChanged();
    partial void OnВесChanging(System.Nullable<int> value);
    partial void OnВесChanged();
    partial void OnКолТравмChanging(System.Nullable<int> value);
    partial void OnКолТравмChanged();
    partial void OnСоревнованиеChanging(string value);
    partial void OnСоревнованиеChanged();
    #endregion
		
		public MainSport()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Имя", DbType="NVarChar(50)")]
		public string Имя
		{
			get
			{
				return this._Имя;
			}
			set
			{
				if ((this._Имя != value))
				{
					this.OnИмяChanging(value);
					this.SendPropertyChanging();
					this._Имя = value;
					this.SendPropertyChanged("Имя");
					this.OnИмяChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Фамилия", DbType="NVarChar(50)")]
		public string Фамилия
		{
			get
			{
				return this._Фамилия;
			}
			set
			{
				if ((this._Фамилия != value))
				{
					this.OnФамилияChanging(value);
					this.SendPropertyChanging();
					this._Фамилия = value;
					this.SendPropertyChanged("Фамилия");
					this.OnФамилияChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Возраст", DbType="Int")]
		public System.Nullable<int> Возраст
		{
			get
			{
				return this._Возраст;
			}
			set
			{
				if ((this._Возраст != value))
				{
					this.OnВозрастChanging(value);
					this.SendPropertyChanging();
					this._Возраст = value;
					this.SendPropertyChanged("Возраст");
					this.OnВозрастChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Вес", DbType="Int")]
		public System.Nullable<int> Вес
		{
			get
			{
				return this._Вес;
			}
			set
			{
				if ((this._Вес != value))
				{
					this.OnВесChanging(value);
					this.SendPropertyChanging();
					this._Вес = value;
					this.SendPropertyChanged("Вес");
					this.OnВесChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_КолТравм", DbType="Int")]
		public System.Nullable<int> КолТравм
		{
			get
			{
				return this._КолТравм;
			}
			set
			{
				if ((this._КолТравм != value))
				{
					this.OnКолТравмChanging(value);
					this.SendPropertyChanging();
					this._КолТравм = value;
					this.SendPropertyChanged("КолТравм");
					this.OnКолТравмChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Соревнование", DbType="NVarChar(50)")]
		public string Соревнование
		{
			get
			{
				return this._Соревнование;
			}
			set
			{
				if ((this._Соревнование != value))
				{
					this.OnСоревнованиеChanging(value);
					this.SendPropertyChanging();
					this._Соревнование = value;
					this.SendPropertyChanged("Соревнование");
					this.OnСоревнованиеChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
