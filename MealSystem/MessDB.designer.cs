﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MealSystem
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="MealSystemDB")]
	public partial class MessDBDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertMemberInformation(MemberInformation instance);
    partial void UpdateMemberInformation(MemberInformation instance);
    partial void DeleteMemberInformation(MemberInformation instance);
    partial void InsertManager(Manager instance);
    partial void UpdateManager(Manager instance);
    partial void DeleteManager(Manager instance);
    partial void InsertMeal(Meal instance);
    partial void UpdateMeal(Meal instance);
    partial void DeleteMeal(Meal instance);
    #endregion
		
		public MessDBDataContext() : 
				base(global::MealSystem.Properties.Settings.Default.MealSystemDBConnectionString1, mappingSource)
		{
			OnCreated();
		}
		
		public MessDBDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MessDBDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MessDBDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MessDBDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<MemberInformation> MemberInformations
		{
			get
			{
				return this.GetTable<MemberInformation>();
			}
		}
		
		public System.Data.Linq.Table<Manager> Managers
		{
			get
			{
				return this.GetTable<Manager>();
			}
		}
		
		public System.Data.Linq.Table<Meal> Meals
		{
			get
			{
				return this.GetTable<Meal>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.MemberInfo")]
	public partial class MemberInformation : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _First_Name;
		
		private string _Phone;
		
		private string _Email;
		
		private string _UserName;
		
		private string _Password;
		
		private string _Last_Name;
		
		private System.Nullable<int> _Deposit;
		
		private System.Nullable<int> _Due;
		
		private System.Nullable<int> _Expense;
		
		private System.Nullable<int> _Pay_money;
		
		private System.Nullable<int> _Current_Balance;
		
		private EntitySet<Meal> _Meals;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnFirst_NameChanging(string value);
    partial void OnFirst_NameChanged();
    partial void OnPhoneChanging(string value);
    partial void OnPhoneChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnUserNameChanging(string value);
    partial void OnUserNameChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnLast_NameChanging(string value);
    partial void OnLast_NameChanged();
    partial void OnDepositChanging(System.Nullable<int> value);
    partial void OnDepositChanged();
    partial void OnDueChanging(System.Nullable<int> value);
    partial void OnDueChanged();
    partial void OnExpenseChanging(System.Nullable<int> value);
    partial void OnExpenseChanged();
    partial void OnPay_moneyChanging(System.Nullable<int> value);
    partial void OnPay_moneyChanged();
    partial void OnCurrent_BalanceChanging(System.Nullable<int> value);
    partial void OnCurrent_BalanceChanged();
    #endregion
		
		public MemberInformation()
		{
			this._Meals = new EntitySet<Meal>(new Action<Meal>(this.attach_Meals), new Action<Meal>(this.detach_Meals));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[First Name]", Storage="_First_Name", DbType="VarChar(MAX)")]
		public string First_Name
		{
			get
			{
				return this._First_Name;
			}
			set
			{
				if ((this._First_Name != value))
				{
					this.OnFirst_NameChanging(value);
					this.SendPropertyChanging();
					this._First_Name = value;
					this.SendPropertyChanged("First_Name");
					this.OnFirst_NameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Phone", DbType="VarChar(MAX)")]
		public string Phone
		{
			get
			{
				return this._Phone;
			}
			set
			{
				if ((this._Phone != value))
				{
					this.OnPhoneChanging(value);
					this.SendPropertyChanging();
					this._Phone = value;
					this.SendPropertyChanged("Phone");
					this.OnPhoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="VarChar(50)")]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserName", DbType="VarChar(50)")]
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
					this.OnUserNameChanging(value);
					this.SendPropertyChanging();
					this._UserName = value;
					this.SendPropertyChanged("UserName");
					this.OnUserNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="VarChar(50)")]
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
					this.OnPasswordChanging(value);
					this.SendPropertyChanging();
					this._Password = value;
					this.SendPropertyChanged("Password");
					this.OnPasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Last Name]", Storage="_Last_Name", DbType="VarChar(50)")]
		public string Last_Name
		{
			get
			{
				return this._Last_Name;
			}
			set
			{
				if ((this._Last_Name != value))
				{
					this.OnLast_NameChanging(value);
					this.SendPropertyChanging();
					this._Last_Name = value;
					this.SendPropertyChanged("Last_Name");
					this.OnLast_NameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Deposit", DbType="Int")]
		public System.Nullable<int> Deposit
		{
			get
			{
				return this._Deposit;
			}
			set
			{
				if ((this._Deposit != value))
				{
					this.OnDepositChanging(value);
					this.SendPropertyChanging();
					this._Deposit = value;
					this.SendPropertyChanged("Deposit");
					this.OnDepositChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Due", DbType="Int")]
		public System.Nullable<int> Due
		{
			get
			{
				return this._Due;
			}
			set
			{
				if ((this._Due != value))
				{
					this.OnDueChanging(value);
					this.SendPropertyChanging();
					this._Due = value;
					this.SendPropertyChanged("Due");
					this.OnDueChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Expense", DbType="Int")]
		public System.Nullable<int> Expense
		{
			get
			{
				return this._Expense;
			}
			set
			{
				if ((this._Expense != value))
				{
					this.OnExpenseChanging(value);
					this.SendPropertyChanging();
					this._Expense = value;
					this.SendPropertyChanged("Expense");
					this.OnExpenseChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Pay money]", Storage="_Pay_money", DbType="Int")]
		public System.Nullable<int> Pay_money
		{
			get
			{
				return this._Pay_money;
			}
			set
			{
				if ((this._Pay_money != value))
				{
					this.OnPay_moneyChanging(value);
					this.SendPropertyChanging();
					this._Pay_money = value;
					this.SendPropertyChanged("Pay_money");
					this.OnPay_moneyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Current Balance]", Storage="_Current_Balance", DbType="Int")]
		public System.Nullable<int> Current_Balance
		{
			get
			{
				return this._Current_Balance;
			}
			set
			{
				if ((this._Current_Balance != value))
				{
					this.OnCurrent_BalanceChanging(value);
					this.SendPropertyChanging();
					this._Current_Balance = value;
					this.SendPropertyChanged("Current_Balance");
					this.OnCurrent_BalanceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="MemberInformation_Meal", Storage="_Meals", ThisKey="Id", OtherKey="Id")]
		public EntitySet<Meal> Meals
		{
			get
			{
				return this._Meals;
			}
			set
			{
				this._Meals.Assign(value);
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
		
		private void attach_Meals(Meal entity)
		{
			this.SendPropertyChanging();
			entity.MemberInformation = this;
		}
		
		private void detach_Meals(Meal entity)
		{
			this.SendPropertyChanging();
			entity.MemberInformation = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Manager")]
	public partial class Manager : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _username;
		
		private string _password;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnusernameChanging(string value);
    partial void OnusernameChanged();
    partial void OnpasswordChanging(string value);
    partial void OnpasswordChanged();
    #endregion
		
		public Manager()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_username", DbType="NChar(50)")]
		public string username
		{
			get
			{
				return this._username;
			}
			set
			{
				if ((this._username != value))
				{
					this.OnusernameChanging(value);
					this.SendPropertyChanging();
					this._username = value;
					this.SendPropertyChanged("username");
					this.OnusernameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_password", DbType="NChar(50)")]
		public string password
		{
			get
			{
				return this._password;
			}
			set
			{
				if ((this._password != value))
				{
					this.OnpasswordChanging(value);
					this.SendPropertyChanging();
					this._password = value;
					this.SendPropertyChanged("password");
					this.OnpasswordChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Meal")]
	public partial class Meal : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private System.Nullable<int> _Total_Meal;
		
		private System.Nullable<int> @__1;
		
		private System.Nullable<int> @__2;
		
		private System.Nullable<int> @__3;
		
		private System.Nullable<int> @__4;
		
		private System.Nullable<int> @__5;
		
		private System.Nullable<int> @__6;
		
		private System.Nullable<int> @__7;
		
		private System.Nullable<int> @__8;
		
		private System.Nullable<int> @__9;
		
		private System.Nullable<int> @__10;
		
		private System.Nullable<int> @__11;
		
		private System.Nullable<int> @__12;
		
		private System.Nullable<int> @__13;
		
		private System.Nullable<int> @__14;
		
		private System.Nullable<int> @__15;
		
		private System.Nullable<int> @__16;
		
		private System.Nullable<int> @__17;
		
		private System.Nullable<int> @__18;
		
		private System.Nullable<int> @__19;
		
		private System.Nullable<int> @__20;
		
		private System.Nullable<int> @__21;
		
		private System.Nullable<int> @__22;
		
		private System.Nullable<int> @__23;
		
		private System.Nullable<int> @__24;
		
		private System.Nullable<int> @__25;
		
		private System.Nullable<int> @__26;
		
		private System.Nullable<int> @__27;
		
		private System.Nullable<int> @__28;
		
		private System.Nullable<int> @__29;
		
		private System.Nullable<int> @__30;
		
		private EntityRef<MemberInformation> _MemberInformation;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnTotal_MealChanging(System.Nullable<int> value);
    partial void OnTotal_MealChanged();
    partial void On_1Changing(System.Nullable<int> value);
    partial void On_1Changed();
    partial void On_2Changing(System.Nullable<int> value);
    partial void On_2Changed();
    partial void On_3Changing(System.Nullable<int> value);
    partial void On_3Changed();
    partial void On_4Changing(System.Nullable<int> value);
    partial void On_4Changed();
    partial void On_5Changing(System.Nullable<int> value);
    partial void On_5Changed();
    partial void On_6Changing(System.Nullable<int> value);
    partial void On_6Changed();
    partial void On_7Changing(System.Nullable<int> value);
    partial void On_7Changed();
    partial void On_8Changing(System.Nullable<int> value);
    partial void On_8Changed();
    partial void On_9Changing(System.Nullable<int> value);
    partial void On_9Changed();
    partial void On_10Changing(System.Nullable<int> value);
    partial void On_10Changed();
    partial void On_11Changing(System.Nullable<int> value);
    partial void On_11Changed();
    partial void On_12Changing(System.Nullable<int> value);
    partial void On_12Changed();
    partial void On_13Changing(System.Nullable<int> value);
    partial void On_13Changed();
    partial void On_14Changing(System.Nullable<int> value);
    partial void On_14Changed();
    partial void On_15Changing(System.Nullable<int> value);
    partial void On_15Changed();
    partial void On_16Changing(System.Nullable<int> value);
    partial void On_16Changed();
    partial void On_17Changing(System.Nullable<int> value);
    partial void On_17Changed();
    partial void On_18Changing(System.Nullable<int> value);
    partial void On_18Changed();
    partial void On_19Changing(System.Nullable<int> value);
    partial void On_19Changed();
    partial void On_20Changing(System.Nullable<int> value);
    partial void On_20Changed();
    partial void On_21Changing(System.Nullable<int> value);
    partial void On_21Changed();
    partial void On_22Changing(System.Nullable<int> value);
    partial void On_22Changed();
    partial void On_23Changing(System.Nullable<int> value);
    partial void On_23Changed();
    partial void On_24Changing(System.Nullable<int> value);
    partial void On_24Changed();
    partial void On_25Changing(System.Nullable<int> value);
    partial void On_25Changed();
    partial void On_26Changing(System.Nullable<int> value);
    partial void On_26Changed();
    partial void On_27Changing(System.Nullable<int> value);
    partial void On_27Changed();
    partial void On_28Changing(System.Nullable<int> value);
    partial void On_28Changed();
    partial void On_29Changing(System.Nullable<int> value);
    partial void On_29Changed();
    partial void On_30Changing(System.Nullable<int> value);
    partial void On_30Changed();
    #endregion
		
		public Meal()
		{
			this._MemberInformation = default(EntityRef<MemberInformation>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					if (this._MemberInformation.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Total Meal]", Storage="_Total_Meal", DbType="Int")]
		public System.Nullable<int> Total_Meal
		{
			get
			{
				return this._Total_Meal;
			}
			set
			{
				if ((this._Total_Meal != value))
				{
					this.OnTotal_MealChanging(value);
					this.SendPropertyChanging();
					this._Total_Meal = value;
					this.SendPropertyChanged("Total_Meal");
					this.OnTotal_MealChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[1]", Storage="__1", DbType="Int")]
		public System.Nullable<int> _1
		{
			get
			{
				return this.@__1;
			}
			set
			{
				if ((this.@__1 != value))
				{
					this.On_1Changing(value);
					this.SendPropertyChanging();
					this.@__1 = value;
					this.SendPropertyChanged("_1");
					this.On_1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[2]", Storage="__2", DbType="Int")]
		public System.Nullable<int> _2
		{
			get
			{
				return this.@__2;
			}
			set
			{
				if ((this.@__2 != value))
				{
					this.On_2Changing(value);
					this.SendPropertyChanging();
					this.@__2 = value;
					this.SendPropertyChanged("_2");
					this.On_2Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[3]", Storage="__3", DbType="Int")]
		public System.Nullable<int> _3
		{
			get
			{
				return this.@__3;
			}
			set
			{
				if ((this.@__3 != value))
				{
					this.On_3Changing(value);
					this.SendPropertyChanging();
					this.@__3 = value;
					this.SendPropertyChanged("_3");
					this.On_3Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[4]", Storage="__4", DbType="Int")]
		public System.Nullable<int> _4
		{
			get
			{
				return this.@__4;
			}
			set
			{
				if ((this.@__4 != value))
				{
					this.On_4Changing(value);
					this.SendPropertyChanging();
					this.@__4 = value;
					this.SendPropertyChanged("_4");
					this.On_4Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[5]", Storage="__5", DbType="Int")]
		public System.Nullable<int> _5
		{
			get
			{
				return this.@__5;
			}
			set
			{
				if ((this.@__5 != value))
				{
					this.On_5Changing(value);
					this.SendPropertyChanging();
					this.@__5 = value;
					this.SendPropertyChanged("_5");
					this.On_5Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[6]", Storage="__6", DbType="Int")]
		public System.Nullable<int> _6
		{
			get
			{
				return this.@__6;
			}
			set
			{
				if ((this.@__6 != value))
				{
					this.On_6Changing(value);
					this.SendPropertyChanging();
					this.@__6 = value;
					this.SendPropertyChanged("_6");
					this.On_6Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[7]", Storage="__7", DbType="Int")]
		public System.Nullable<int> _7
		{
			get
			{
				return this.@__7;
			}
			set
			{
				if ((this.@__7 != value))
				{
					this.On_7Changing(value);
					this.SendPropertyChanging();
					this.@__7 = value;
					this.SendPropertyChanged("_7");
					this.On_7Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[8]", Storage="__8", DbType="Int")]
		public System.Nullable<int> _8
		{
			get
			{
				return this.@__8;
			}
			set
			{
				if ((this.@__8 != value))
				{
					this.On_8Changing(value);
					this.SendPropertyChanging();
					this.@__8 = value;
					this.SendPropertyChanged("_8");
					this.On_8Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[9]", Storage="__9", DbType="Int")]
		public System.Nullable<int> _9
		{
			get
			{
				return this.@__9;
			}
			set
			{
				if ((this.@__9 != value))
				{
					this.On_9Changing(value);
					this.SendPropertyChanging();
					this.@__9 = value;
					this.SendPropertyChanged("_9");
					this.On_9Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[10]", Storage="__10", DbType="Int")]
		public System.Nullable<int> _10
		{
			get
			{
				return this.@__10;
			}
			set
			{
				if ((this.@__10 != value))
				{
					this.On_10Changing(value);
					this.SendPropertyChanging();
					this.@__10 = value;
					this.SendPropertyChanged("_10");
					this.On_10Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[11]", Storage="__11", DbType="Int")]
		public System.Nullable<int> _11
		{
			get
			{
				return this.@__11;
			}
			set
			{
				if ((this.@__11 != value))
				{
					this.On_11Changing(value);
					this.SendPropertyChanging();
					this.@__11 = value;
					this.SendPropertyChanged("_11");
					this.On_11Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[12]", Storage="__12", DbType="Int")]
		public System.Nullable<int> _12
		{
			get
			{
				return this.@__12;
			}
			set
			{
				if ((this.@__12 != value))
				{
					this.On_12Changing(value);
					this.SendPropertyChanging();
					this.@__12 = value;
					this.SendPropertyChanged("_12");
					this.On_12Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[13]", Storage="__13", DbType="Int")]
		public System.Nullable<int> _13
		{
			get
			{
				return this.@__13;
			}
			set
			{
				if ((this.@__13 != value))
				{
					this.On_13Changing(value);
					this.SendPropertyChanging();
					this.@__13 = value;
					this.SendPropertyChanged("_13");
					this.On_13Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[14]", Storage="__14", DbType="Int")]
		public System.Nullable<int> _14
		{
			get
			{
				return this.@__14;
			}
			set
			{
				if ((this.@__14 != value))
				{
					this.On_14Changing(value);
					this.SendPropertyChanging();
					this.@__14 = value;
					this.SendPropertyChanged("_14");
					this.On_14Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[15]", Storage="__15", DbType="Int")]
		public System.Nullable<int> _15
		{
			get
			{
				return this.@__15;
			}
			set
			{
				if ((this.@__15 != value))
				{
					this.On_15Changing(value);
					this.SendPropertyChanging();
					this.@__15 = value;
					this.SendPropertyChanged("_15");
					this.On_15Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[16]", Storage="__16", DbType="Int")]
		public System.Nullable<int> _16
		{
			get
			{
				return this.@__16;
			}
			set
			{
				if ((this.@__16 != value))
				{
					this.On_16Changing(value);
					this.SendPropertyChanging();
					this.@__16 = value;
					this.SendPropertyChanged("_16");
					this.On_16Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[17]", Storage="__17", DbType="Int")]
		public System.Nullable<int> _17
		{
			get
			{
				return this.@__17;
			}
			set
			{
				if ((this.@__17 != value))
				{
					this.On_17Changing(value);
					this.SendPropertyChanging();
					this.@__17 = value;
					this.SendPropertyChanged("_17");
					this.On_17Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[18]", Storage="__18", DbType="Int")]
		public System.Nullable<int> _18
		{
			get
			{
				return this.@__18;
			}
			set
			{
				if ((this.@__18 != value))
				{
					this.On_18Changing(value);
					this.SendPropertyChanging();
					this.@__18 = value;
					this.SendPropertyChanged("_18");
					this.On_18Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[19]", Storage="__19", DbType="Int")]
		public System.Nullable<int> _19
		{
			get
			{
				return this.@__19;
			}
			set
			{
				if ((this.@__19 != value))
				{
					this.On_19Changing(value);
					this.SendPropertyChanging();
					this.@__19 = value;
					this.SendPropertyChanged("_19");
					this.On_19Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[20]", Storage="__20", DbType="Int")]
		public System.Nullable<int> _20
		{
			get
			{
				return this.@__20;
			}
			set
			{
				if ((this.@__20 != value))
				{
					this.On_20Changing(value);
					this.SendPropertyChanging();
					this.@__20 = value;
					this.SendPropertyChanged("_20");
					this.On_20Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[21]", Storage="__21", DbType="Int")]
		public System.Nullable<int> _21
		{
			get
			{
				return this.@__21;
			}
			set
			{
				if ((this.@__21 != value))
				{
					this.On_21Changing(value);
					this.SendPropertyChanging();
					this.@__21 = value;
					this.SendPropertyChanged("_21");
					this.On_21Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[22]", Storage="__22", DbType="Int")]
		public System.Nullable<int> _22
		{
			get
			{
				return this.@__22;
			}
			set
			{
				if ((this.@__22 != value))
				{
					this.On_22Changing(value);
					this.SendPropertyChanging();
					this.@__22 = value;
					this.SendPropertyChanged("_22");
					this.On_22Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[23]", Storage="__23", DbType="Int")]
		public System.Nullable<int> _23
		{
			get
			{
				return this.@__23;
			}
			set
			{
				if ((this.@__23 != value))
				{
					this.On_23Changing(value);
					this.SendPropertyChanging();
					this.@__23 = value;
					this.SendPropertyChanged("_23");
					this.On_23Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[24]", Storage="__24", DbType="Int")]
		public System.Nullable<int> _24
		{
			get
			{
				return this.@__24;
			}
			set
			{
				if ((this.@__24 != value))
				{
					this.On_24Changing(value);
					this.SendPropertyChanging();
					this.@__24 = value;
					this.SendPropertyChanged("_24");
					this.On_24Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[25]", Storage="__25", DbType="Int")]
		public System.Nullable<int> _25
		{
			get
			{
				return this.@__25;
			}
			set
			{
				if ((this.@__25 != value))
				{
					this.On_25Changing(value);
					this.SendPropertyChanging();
					this.@__25 = value;
					this.SendPropertyChanged("_25");
					this.On_25Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[26]", Storage="__26", DbType="Int")]
		public System.Nullable<int> _26
		{
			get
			{
				return this.@__26;
			}
			set
			{
				if ((this.@__26 != value))
				{
					this.On_26Changing(value);
					this.SendPropertyChanging();
					this.@__26 = value;
					this.SendPropertyChanged("_26");
					this.On_26Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[27]", Storage="__27", DbType="Int")]
		public System.Nullable<int> _27
		{
			get
			{
				return this.@__27;
			}
			set
			{
				if ((this.@__27 != value))
				{
					this.On_27Changing(value);
					this.SendPropertyChanging();
					this.@__27 = value;
					this.SendPropertyChanged("_27");
					this.On_27Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[28]", Storage="__28", DbType="Int")]
		public System.Nullable<int> _28
		{
			get
			{
				return this.@__28;
			}
			set
			{
				if ((this.@__28 != value))
				{
					this.On_28Changing(value);
					this.SendPropertyChanging();
					this.@__28 = value;
					this.SendPropertyChanged("_28");
					this.On_28Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[29]", Storage="__29", DbType="Int")]
		public System.Nullable<int> _29
		{
			get
			{
				return this.@__29;
			}
			set
			{
				if ((this.@__29 != value))
				{
					this.On_29Changing(value);
					this.SendPropertyChanging();
					this.@__29 = value;
					this.SendPropertyChanged("_29");
					this.On_29Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[30]", Storage="__30", DbType="Int")]
		public System.Nullable<int> _30
		{
			get
			{
				return this.@__30;
			}
			set
			{
				if ((this.@__30 != value))
				{
					this.On_30Changing(value);
					this.SendPropertyChanging();
					this.@__30 = value;
					this.SendPropertyChanged("_30");
					this.On_30Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="MemberInformation_Meal", Storage="_MemberInformation", ThisKey="Id", OtherKey="Id", IsForeignKey=true)]
		public MemberInformation MemberInformation
		{
			get
			{
				return this._MemberInformation.Entity;
			}
			set
			{
				MemberInformation previousValue = this._MemberInformation.Entity;
				if (((previousValue != value) 
							|| (this._MemberInformation.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._MemberInformation.Entity = null;
						previousValue.Meals.Remove(this);
					}
					this._MemberInformation.Entity = value;
					if ((value != null))
					{
						value.Meals.Add(this);
						this._Id = value.Id;
					}
					else
					{
						this._Id = default(int);
					}
					this.SendPropertyChanged("MemberInformation");
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
