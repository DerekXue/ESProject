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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;



[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="RDSICA")]
public partial class DataClassesDataContext : System.Data.Linq.DataContext
{
	
	private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
	
  #region Extensibility Method Definitions
  partial void OnCreated();
  partial void InsertTransaction(Transaction instance);
  partial void UpdateTransaction(Transaction instance);
  partial void DeleteTransaction(Transaction instance);
  partial void InsertBranch(Branch instance);
  partial void UpdateBranch(Branch instance);
  partial void DeleteBranch(Branch instance);
  partial void InsertCarModel(CarModel instance);
  partial void UpdateCarModel(CarModel instance);
  partial void DeleteCarModel(CarModel instance);
  partial void InsertCustomer(Customer instance);
  partial void UpdateCustomer(Customer instance);
  partial void DeleteCustomer(Customer instance);
  partial void InsertCarStock(CarStock instance);
  partial void UpdateCarStock(CarStock instance);
  partial void DeleteCarStock(CarStock instance);
  partial void InsertBooking(Booking instance);
  partial void UpdateBooking(Booking instance);
  partial void DeleteBooking(Booking instance);
  #endregion
	
	public DataClassesDataContext() : 
			base(global::System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString1"].ConnectionString, mappingSource)
	{
		OnCreated();
	}
	
	public DataClassesDataContext(string connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public DataClassesDataContext(System.Data.IDbConnection connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public DataClassesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public DataClassesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public System.Data.Linq.Table<Transaction> Transactions
	{
		get
		{
			return this.GetTable<Transaction>();
		}
	}
	
	public System.Data.Linq.Table<Branch> Branches
	{
		get
		{
			return this.GetTable<Branch>();
		}
	}
	
	public System.Data.Linq.Table<CarModel> CarModels
	{
		get
		{
			return this.GetTable<CarModel>();
		}
	}
	
	public System.Data.Linq.Table<Customer> Customers
	{
		get
		{
			return this.GetTable<Customer>();
		}
	}
	
	public System.Data.Linq.Table<CarStock> CarStocks
	{
		get
		{
			return this.GetTable<CarStock>();
		}
	}
	
	public System.Data.Linq.Table<Booking> Bookings
	{
		get
		{
			return this.GetTable<Booking>();
		}
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.[Transaction]")]
public partial class Transaction : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private string _TransactionID;
	
	private string _TransactionUniqueID;
	
	private string _Amount;
	
	private string _FromBank;
	
	private EntitySet<Booking> _Bookings;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnTransactionIDChanging(string value);
    partial void OnTransactionIDChanged();
    partial void OnTransactionUniqueIDChanging(string value);
    partial void OnTransactionUniqueIDChanged();
    partial void OnAmountChanging(string value);
    partial void OnAmountChanged();
    partial void OnFromBankChanging(string value);
    partial void OnFromBankChanged();
    #endregion
	
	public Transaction()
	{
		this._Bookings = new EntitySet<Booking>(new Action<Booking>(this.attach_Bookings), new Action<Booking>(this.detach_Bookings));
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TransactionID", DbType="VarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
	public string TransactionID
	{
		get
		{
			return this._TransactionID;
		}
		set
		{
			if ((this._TransactionID != value))
			{
				this.OnTransactionIDChanging(value);
				this.SendPropertyChanging();
				this._TransactionID = value;
				this.SendPropertyChanged("TransactionID");
				this.OnTransactionIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TransactionUniqueID", DbType="VarChar(50)")]
	public string TransactionUniqueID
	{
		get
		{
			return this._TransactionUniqueID;
		}
		set
		{
			if ((this._TransactionUniqueID != value))
			{
				this.OnTransactionUniqueIDChanging(value);
				this.SendPropertyChanging();
				this._TransactionUniqueID = value;
				this.SendPropertyChanged("TransactionUniqueID");
				this.OnTransactionUniqueIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Amount", DbType="VarChar(50)")]
	public string Amount
	{
		get
		{
			return this._Amount;
		}
		set
		{
			if ((this._Amount != value))
			{
				this.OnAmountChanging(value);
				this.SendPropertyChanging();
				this._Amount = value;
				this.SendPropertyChanged("Amount");
				this.OnAmountChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FromBank", DbType="VarChar(50)")]
	public string FromBank
	{
		get
		{
			return this._FromBank;
		}
		set
		{
			if ((this._FromBank != value))
			{
				this.OnFromBankChanging(value);
				this.SendPropertyChanging();
				this._FromBank = value;
				this.SendPropertyChanged("FromBank");
				this.OnFromBankChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Transaction_Booking", Storage="_Bookings", ThisKey="TransactionID", OtherKey="TransactionID")]
	public EntitySet<Booking> Bookings
	{
		get
		{
			return this._Bookings;
		}
		set
		{
			this._Bookings.Assign(value);
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
	
	private void attach_Bookings(Booking entity)
	{
		this.SendPropertyChanging();
		entity.Transaction = this;
	}
	
	private void detach_Bookings(Booking entity)
	{
		this.SendPropertyChanging();
		entity.Transaction = null;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Branch")]
public partial class Branch : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private string _BranchID;
	
	private string _BranchUniqueID;
	
	private string _ContackNumber;
	
	private string _Address;
	
	private string _PersonIncharge;
	
	private EntitySet<CarStock> _CarStocks;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnBranchIDChanging(string value);
    partial void OnBranchIDChanged();
    partial void OnBranchUniqueIDChanging(string value);
    partial void OnBranchUniqueIDChanged();
    partial void OnContackNumberChanging(string value);
    partial void OnContackNumberChanged();
    partial void OnAddressChanging(string value);
    partial void OnAddressChanged();
    partial void OnPersonInchargeChanging(string value);
    partial void OnPersonInchargeChanged();
    #endregion
	
	public Branch()
	{
		this._CarStocks = new EntitySet<CarStock>(new Action<CarStock>(this.attach_CarStocks), new Action<CarStock>(this.detach_CarStocks));
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BranchID", DbType="VarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
	public string BranchID
	{
		get
		{
			return this._BranchID;
		}
		set
		{
			if ((this._BranchID != value))
			{
				this.OnBranchIDChanging(value);
				this.SendPropertyChanging();
				this._BranchID = value;
				this.SendPropertyChanged("BranchID");
				this.OnBranchIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BranchUniqueID", DbType="VarChar(50)")]
	public string BranchUniqueID
	{
		get
		{
			return this._BranchUniqueID;
		}
		set
		{
			if ((this._BranchUniqueID != value))
			{
				this.OnBranchUniqueIDChanging(value);
				this.SendPropertyChanging();
				this._BranchUniqueID = value;
				this.SendPropertyChanged("BranchUniqueID");
				this.OnBranchUniqueIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ContackNumber", DbType="VarChar(50)")]
	public string ContackNumber
	{
		get
		{
			return this._ContackNumber;
		}
		set
		{
			if ((this._ContackNumber != value))
			{
				this.OnContackNumberChanging(value);
				this.SendPropertyChanging();
				this._ContackNumber = value;
				this.SendPropertyChanged("ContackNumber");
				this.OnContackNumberChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Address", DbType="VarChar(50)")]
	public string Address
	{
		get
		{
			return this._Address;
		}
		set
		{
			if ((this._Address != value))
			{
				this.OnAddressChanging(value);
				this.SendPropertyChanging();
				this._Address = value;
				this.SendPropertyChanged("Address");
				this.OnAddressChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PersonIncharge", DbType="VarChar(50)")]
	public string PersonIncharge
	{
		get
		{
			return this._PersonIncharge;
		}
		set
		{
			if ((this._PersonIncharge != value))
			{
				this.OnPersonInchargeChanging(value);
				this.SendPropertyChanging();
				this._PersonIncharge = value;
				this.SendPropertyChanged("PersonIncharge");
				this.OnPersonInchargeChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Branch_CarStock", Storage="_CarStocks", ThisKey="BranchID", OtherKey="BranchID")]
	public EntitySet<CarStock> CarStocks
	{
		get
		{
			return this._CarStocks;
		}
		set
		{
			this._CarStocks.Assign(value);
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
	
	private void attach_CarStocks(CarStock entity)
	{
		this.SendPropertyChanging();
		entity.Branch = this;
	}
	
	private void detach_CarStocks(CarStock entity)
	{
		this.SendPropertyChanging();
		entity.Branch = null;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.CarModel")]
public partial class CarModel : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private string _CarModelID;
	
	private string _CarModelUniqueID;
	
	private string _CarName;
	
	private string _CarPlate;
	
	private string _CarCapacity;
	
	private string _DailyRental;
	
	private string _Deposit;
	
	private EntitySet<CarStock> _CarStocks;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCarModelIDChanging(string value);
    partial void OnCarModelIDChanged();
    partial void OnCarModelUniqueIDChanging(string value);
    partial void OnCarModelUniqueIDChanged();
    partial void OnCarNameChanging(string value);
    partial void OnCarNameChanged();
    partial void OnCarPlateChanging(string value);
    partial void OnCarPlateChanged();
    partial void OnCarCapacityChanging(string value);
    partial void OnCarCapacityChanged();
    partial void OnDailyRentalChanging(string value);
    partial void OnDailyRentalChanged();
    partial void OnDepositChanging(string value);
    partial void OnDepositChanged();
    #endregion
	
	public CarModel()
	{
		this._CarStocks = new EntitySet<CarStock>(new Action<CarStock>(this.attach_CarStocks), new Action<CarStock>(this.detach_CarStocks));
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CarModelID", DbType="VarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
	public string CarModelID
	{
		get
		{
			return this._CarModelID;
		}
		set
		{
			if ((this._CarModelID != value))
			{
				this.OnCarModelIDChanging(value);
				this.SendPropertyChanging();
				this._CarModelID = value;
				this.SendPropertyChanged("CarModelID");
				this.OnCarModelIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CarModelUniqueID", DbType="VarChar(50)")]
	public string CarModelUniqueID
	{
		get
		{
			return this._CarModelUniqueID;
		}
		set
		{
			if ((this._CarModelUniqueID != value))
			{
				this.OnCarModelUniqueIDChanging(value);
				this.SendPropertyChanging();
				this._CarModelUniqueID = value;
				this.SendPropertyChanged("CarModelUniqueID");
				this.OnCarModelUniqueIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CarName", DbType="VarChar(50)")]
	public string CarName
	{
		get
		{
			return this._CarName;
		}
		set
		{
			if ((this._CarName != value))
			{
				this.OnCarNameChanging(value);
				this.SendPropertyChanging();
				this._CarName = value;
				this.SendPropertyChanged("CarName");
				this.OnCarNameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CarPlate", DbType="VarChar(50)")]
	public string CarPlate
	{
		get
		{
			return this._CarPlate;
		}
		set
		{
			if ((this._CarPlate != value))
			{
				this.OnCarPlateChanging(value);
				this.SendPropertyChanging();
				this._CarPlate = value;
				this.SendPropertyChanged("CarPlate");
				this.OnCarPlateChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CarCapacity", DbType="VarChar(50)")]
	public string CarCapacity
	{
		get
		{
			return this._CarCapacity;
		}
		set
		{
			if ((this._CarCapacity != value))
			{
				this.OnCarCapacityChanging(value);
				this.SendPropertyChanging();
				this._CarCapacity = value;
				this.SendPropertyChanged("CarCapacity");
				this.OnCarCapacityChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DailyRental", DbType="VarChar(50)")]
	public string DailyRental
	{
		get
		{
			return this._DailyRental;
		}
		set
		{
			if ((this._DailyRental != value))
			{
				this.OnDailyRentalChanging(value);
				this.SendPropertyChanging();
				this._DailyRental = value;
				this.SendPropertyChanged("DailyRental");
				this.OnDailyRentalChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Deposit", DbType="VarChar(50)")]
	public string Deposit
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
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="CarModel_CarStock", Storage="_CarStocks", ThisKey="CarModelID", OtherKey="CarModelID")]
	public EntitySet<CarStock> CarStocks
	{
		get
		{
			return this._CarStocks;
		}
		set
		{
			this._CarStocks.Assign(value);
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
	
	private void attach_CarStocks(CarStock entity)
	{
		this.SendPropertyChanging();
		entity.CarModel = this;
	}
	
	private void detach_CarStocks(CarStock entity)
	{
		this.SendPropertyChanging();
		entity.CarModel = null;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Customer")]
public partial class Customer : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private string _CustomerID;
	
	private string _CustomerUniqueID;
	
	private string _CustomerName;
	
	private string _NRIC;
	
	private string _ContactNumber;
	
	private EntitySet<Booking> _Bookings;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCustomerIDChanging(string value);
    partial void OnCustomerIDChanged();
    partial void OnCustomerUniqueIDChanging(string value);
    partial void OnCustomerUniqueIDChanged();
    partial void OnCustomerNameChanging(string value);
    partial void OnCustomerNameChanged();
    partial void OnNRICChanging(string value);
    partial void OnNRICChanged();
    partial void OnContactNumberChanging(string value);
    partial void OnContactNumberChanged();
    #endregion
	
	public Customer()
	{
		this._Bookings = new EntitySet<Booking>(new Action<Booking>(this.attach_Bookings), new Action<Booking>(this.detach_Bookings));
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CustomerID", DbType="VarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
	public string CustomerID
	{
		get
		{
			return this._CustomerID;
		}
		set
		{
			if ((this._CustomerID != value))
			{
				this.OnCustomerIDChanging(value);
				this.SendPropertyChanging();
				this._CustomerID = value;
				this.SendPropertyChanged("CustomerID");
				this.OnCustomerIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CustomerUniqueID", DbType="VarChar(50)")]
	public string CustomerUniqueID
	{
		get
		{
			return this._CustomerUniqueID;
		}
		set
		{
			if ((this._CustomerUniqueID != value))
			{
				this.OnCustomerUniqueIDChanging(value);
				this.SendPropertyChanging();
				this._CustomerUniqueID = value;
				this.SendPropertyChanged("CustomerUniqueID");
				this.OnCustomerUniqueIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CustomerName", DbType="VarChar(50)")]
	public string CustomerName
	{
		get
		{
			return this._CustomerName;
		}
		set
		{
			if ((this._CustomerName != value))
			{
				this.OnCustomerNameChanging(value);
				this.SendPropertyChanging();
				this._CustomerName = value;
				this.SendPropertyChanged("CustomerName");
				this.OnCustomerNameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NRIC", DbType="VarChar(50)")]
	public string NRIC
	{
		get
		{
			return this._NRIC;
		}
		set
		{
			if ((this._NRIC != value))
			{
				this.OnNRICChanging(value);
				this.SendPropertyChanging();
				this._NRIC = value;
				this.SendPropertyChanged("NRIC");
				this.OnNRICChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ContactNumber", DbType="VarChar(50)")]
	public string ContactNumber
	{
		get
		{
			return this._ContactNumber;
		}
		set
		{
			if ((this._ContactNumber != value))
			{
				this.OnContactNumberChanging(value);
				this.SendPropertyChanging();
				this._ContactNumber = value;
				this.SendPropertyChanged("ContactNumber");
				this.OnContactNumberChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Customer_Booking", Storage="_Bookings", ThisKey="CustomerID", OtherKey="CustomerID")]
	public EntitySet<Booking> Bookings
	{
		get
		{
			return this._Bookings;
		}
		set
		{
			this._Bookings.Assign(value);
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
	
	private void attach_Bookings(Booking entity)
	{
		this.SendPropertyChanging();
		entity.Customer = this;
	}
	
	private void detach_Bookings(Booking entity)
	{
		this.SendPropertyChanging();
		entity.Customer = null;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.CarStock")]
public partial class CarStock : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private string _CarStockID;
	
	private string _CarStockUniqueID;
	
	private string _BranchID;
	
	private string _CarModelID;
	
	private string _Avaliability;
	
	private EntitySet<Booking> _Bookings;
	
	private EntityRef<CarModel> _CarModel;
	
	private EntityRef<Branch> _Branch;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCarStockIDChanging(string value);
    partial void OnCarStockIDChanged();
    partial void OnCarStockUniqueIDChanging(string value);
    partial void OnCarStockUniqueIDChanged();
    partial void OnBranchIDChanging(string value);
    partial void OnBranchIDChanged();
    partial void OnCarModelIDChanging(string value);
    partial void OnCarModelIDChanged();
    partial void OnAvaliabilityChanging(string value);
    partial void OnAvaliabilityChanged();
    #endregion
	
	public CarStock()
	{
		this._Bookings = new EntitySet<Booking>(new Action<Booking>(this.attach_Bookings), new Action<Booking>(this.detach_Bookings));
		this._CarModel = default(EntityRef<CarModel>);
		this._Branch = default(EntityRef<Branch>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CarStockID", DbType="VarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
	public string CarStockID
	{
		get
		{
			return this._CarStockID;
		}
		set
		{
			if ((this._CarStockID != value))
			{
				this.OnCarStockIDChanging(value);
				this.SendPropertyChanging();
				this._CarStockID = value;
				this.SendPropertyChanged("CarStockID");
				this.OnCarStockIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CarStockUniqueID", DbType="VarChar(50)")]
	public string CarStockUniqueID
	{
		get
		{
			return this._CarStockUniqueID;
		}
		set
		{
			if ((this._CarStockUniqueID != value))
			{
				this.OnCarStockUniqueIDChanging(value);
				this.SendPropertyChanging();
				this._CarStockUniqueID = value;
				this.SendPropertyChanged("CarStockUniqueID");
				this.OnCarStockUniqueIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BranchID", DbType="VarChar(50)")]
	public string BranchID
	{
		get
		{
			return this._BranchID;
		}
		set
		{
			if ((this._BranchID != value))
			{
				if (this._Branch.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnBranchIDChanging(value);
				this.SendPropertyChanging();
				this._BranchID = value;
				this.SendPropertyChanged("BranchID");
				this.OnBranchIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CarModelID", DbType="VarChar(50)")]
	public string CarModelID
	{
		get
		{
			return this._CarModelID;
		}
		set
		{
			if ((this._CarModelID != value))
			{
				if (this._CarModel.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnCarModelIDChanging(value);
				this.SendPropertyChanging();
				this._CarModelID = value;
				this.SendPropertyChanged("CarModelID");
				this.OnCarModelIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Avaliability", DbType="VarChar(50)")]
	public string Avaliability
	{
		get
		{
			return this._Avaliability;
		}
		set
		{
			if ((this._Avaliability != value))
			{
				this.OnAvaliabilityChanging(value);
				this.SendPropertyChanging();
				this._Avaliability = value;
				this.SendPropertyChanged("Avaliability");
				this.OnAvaliabilityChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="CarStock_Booking", Storage="_Bookings", ThisKey="CarStockID", OtherKey="CarStockID")]
	public EntitySet<Booking> Bookings
	{
		get
		{
			return this._Bookings;
		}
		set
		{
			this._Bookings.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="CarModel_CarStock", Storage="_CarModel", ThisKey="CarModelID", OtherKey="CarModelID", IsForeignKey=true)]
	public CarModel CarModel
	{
		get
		{
			return this._CarModel.Entity;
		}
		set
		{
			CarModel previousValue = this._CarModel.Entity;
			if (((previousValue != value) 
						|| (this._CarModel.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._CarModel.Entity = null;
					previousValue.CarStocks.Remove(this);
				}
				this._CarModel.Entity = value;
				if ((value != null))
				{
					value.CarStocks.Add(this);
					this._CarModelID = value.CarModelID;
				}
				else
				{
					this._CarModelID = default(string);
				}
				this.SendPropertyChanged("CarModel");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Branch_CarStock", Storage="_Branch", ThisKey="BranchID", OtherKey="BranchID", IsForeignKey=true)]
	public Branch Branch
	{
		get
		{
			return this._Branch.Entity;
		}
		set
		{
			Branch previousValue = this._Branch.Entity;
			if (((previousValue != value) 
						|| (this._Branch.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Branch.Entity = null;
					previousValue.CarStocks.Remove(this);
				}
				this._Branch.Entity = value;
				if ((value != null))
				{
					value.CarStocks.Add(this);
					this._BranchID = value.BranchID;
				}
				else
				{
					this._BranchID = default(string);
				}
				this.SendPropertyChanged("Branch");
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
	
	private void attach_Bookings(Booking entity)
	{
		this.SendPropertyChanging();
		entity.CarStock = this;
	}
	
	private void detach_Bookings(Booking entity)
	{
		this.SendPropertyChanging();
		entity.CarStock = null;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Booking")]
public partial class Booking : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private string _BookingID;
	
	private string _BookingUniqueID;
	
	private string _CarStockID;
	
	private string _CustomerID;
	
	private string _TransactionID;
	
	private string _BorrowDate;
	
	private string _ReturnDate;
	
	private string _IfReturned;
	
	private EntityRef<Transaction> _Transaction;
	
	private EntityRef<Customer> _Customer;
	
	private EntityRef<CarStock> _CarStock;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnBookingIDChanging(string value);
    partial void OnBookingIDChanged();
    partial void OnBookingUniqueIDChanging(string value);
    partial void OnBookingUniqueIDChanged();
    partial void OnCarStockIDChanging(string value);
    partial void OnCarStockIDChanged();
    partial void OnCustomerIDChanging(string value);
    partial void OnCustomerIDChanged();
    partial void OnTransactionIDChanging(string value);
    partial void OnTransactionIDChanged();
    partial void OnBorrowDateChanging(string value);
    partial void OnBorrowDateChanged();
    partial void OnReturnDateChanging(string value);
    partial void OnReturnDateChanged();
    partial void OnIfReturnedChanging(string value);
    partial void OnIfReturnedChanged();
    #endregion
	
	public Booking()
	{
		this._Transaction = default(EntityRef<Transaction>);
		this._Customer = default(EntityRef<Customer>);
		this._CarStock = default(EntityRef<CarStock>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BookingID", DbType="VarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
	public string BookingID
	{
		get
		{
			return this._BookingID;
		}
		set
		{
			if ((this._BookingID != value))
			{
				this.OnBookingIDChanging(value);
				this.SendPropertyChanging();
				this._BookingID = value;
				this.SendPropertyChanged("BookingID");
				this.OnBookingIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BookingUniqueID", DbType="VarChar(50)")]
	public string BookingUniqueID
	{
		get
		{
			return this._BookingUniqueID;
		}
		set
		{
			if ((this._BookingUniqueID != value))
			{
				this.OnBookingUniqueIDChanging(value);
				this.SendPropertyChanging();
				this._BookingUniqueID = value;
				this.SendPropertyChanged("BookingUniqueID");
				this.OnBookingUniqueIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CarStockID", DbType="VarChar(50)")]
	public string CarStockID
	{
		get
		{
			return this._CarStockID;
		}
		set
		{
			if ((this._CarStockID != value))
			{
				if (this._CarStock.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnCarStockIDChanging(value);
				this.SendPropertyChanging();
				this._CarStockID = value;
				this.SendPropertyChanged("CarStockID");
				this.OnCarStockIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CustomerID", DbType="VarChar(50)")]
	public string CustomerID
	{
		get
		{
			return this._CustomerID;
		}
		set
		{
			if ((this._CustomerID != value))
			{
				if (this._Customer.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnCustomerIDChanging(value);
				this.SendPropertyChanging();
				this._CustomerID = value;
				this.SendPropertyChanged("CustomerID");
				this.OnCustomerIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TransactionID", DbType="VarChar(50)")]
	public string TransactionID
	{
		get
		{
			return this._TransactionID;
		}
		set
		{
			if ((this._TransactionID != value))
			{
				if (this._Transaction.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnTransactionIDChanging(value);
				this.SendPropertyChanging();
				this._TransactionID = value;
				this.SendPropertyChanged("TransactionID");
				this.OnTransactionIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BorrowDate", DbType="VarChar(50)")]
	public string BorrowDate
	{
		get
		{
			return this._BorrowDate;
		}
		set
		{
			if ((this._BorrowDate != value))
			{
				this.OnBorrowDateChanging(value);
				this.SendPropertyChanging();
				this._BorrowDate = value;
				this.SendPropertyChanged("BorrowDate");
				this.OnBorrowDateChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReturnDate", DbType="VarChar(50)")]
	public string ReturnDate
	{
		get
		{
			return this._ReturnDate;
		}
		set
		{
			if ((this._ReturnDate != value))
			{
				this.OnReturnDateChanging(value);
				this.SendPropertyChanging();
				this._ReturnDate = value;
				this.SendPropertyChanged("ReturnDate");
				this.OnReturnDateChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IfReturned", DbType="VarChar(50)")]
	public string IfReturned
	{
		get
		{
			return this._IfReturned;
		}
		set
		{
			if ((this._IfReturned != value))
			{
				this.OnIfReturnedChanging(value);
				this.SendPropertyChanging();
				this._IfReturned = value;
				this.SendPropertyChanged("IfReturned");
				this.OnIfReturnedChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Transaction_Booking", Storage="_Transaction", ThisKey="TransactionID", OtherKey="TransactionID", IsForeignKey=true)]
	public Transaction Transaction
	{
		get
		{
			return this._Transaction.Entity;
		}
		set
		{
			Transaction previousValue = this._Transaction.Entity;
			if (((previousValue != value) 
						|| (this._Transaction.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Transaction.Entity = null;
					previousValue.Bookings.Remove(this);
				}
				this._Transaction.Entity = value;
				if ((value != null))
				{
					value.Bookings.Add(this);
					this._TransactionID = value.TransactionID;
				}
				else
				{
					this._TransactionID = default(string);
				}
				this.SendPropertyChanged("Transaction");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Customer_Booking", Storage="_Customer", ThisKey="CustomerID", OtherKey="CustomerID", IsForeignKey=true)]
	public Customer Customer
	{
		get
		{
			return this._Customer.Entity;
		}
		set
		{
			Customer previousValue = this._Customer.Entity;
			if (((previousValue != value) 
						|| (this._Customer.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Customer.Entity = null;
					previousValue.Bookings.Remove(this);
				}
				this._Customer.Entity = value;
				if ((value != null))
				{
					value.Bookings.Add(this);
					this._CustomerID = value.CustomerID;
				}
				else
				{
					this._CustomerID = default(string);
				}
				this.SendPropertyChanged("Customer");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="CarStock_Booking", Storage="_CarStock", ThisKey="CarStockID", OtherKey="CarStockID", IsForeignKey=true)]
	public CarStock CarStock
	{
		get
		{
			return this._CarStock.Entity;
		}
		set
		{
			CarStock previousValue = this._CarStock.Entity;
			if (((previousValue != value) 
						|| (this._CarStock.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._CarStock.Entity = null;
					previousValue.Bookings.Remove(this);
				}
				this._CarStock.Entity = value;
				if ((value != null))
				{
					value.Bookings.Add(this);
					this._CarStockID = value.CarStockID;
				}
				else
				{
					this._CarStockID = default(string);
				}
				this.SendPropertyChanged("CarStock");
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
#pragma warning restore 1591
