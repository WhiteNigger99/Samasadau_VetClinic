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

namespace VetClinic.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="VetClinicDB")]
	public partial class VetDBDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Определения метода расширяемости
    partial void OnCreated();
    partial void InsertDoctorRole(DoctorRole instance);
    partial void UpdateDoctorRole(DoctorRole instance);
    partial void DeleteDoctorRole(DoctorRole instance);
    partial void InsertPet(Pet instance);
    partial void UpdatePet(Pet instance);
    partial void DeletePet(Pet instance);
    partial void InsertRole(Role instance);
    partial void UpdateRole(Role instance);
    partial void DeleteRole(Role instance);
    partial void InsertClient(Client instance);
    partial void UpdateClient(Client instance);
    partial void DeleteClient(Client instance);
    partial void InsertDoctor(Doctor instance);
    partial void UpdateDoctor(Doctor instance);
    partial void DeleteDoctor(Doctor instance);
    partial void InsertRecall(Recall instance);
    partial void UpdateRecall(Recall instance);
    partial void DeleteRecall(Recall instance);
    partial void InsertCard(Card instance);
    partial void UpdateCard(Card instance);
    partial void DeleteCard(Card instance);
    partial void InsertSchedule(Schedule instance);
    partial void UpdateSchedule(Schedule instance);
    partial void DeleteSchedule(Schedule instance);
    #endregion
		
		public VetDBDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["VetClinicDBConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public VetDBDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public VetDBDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public VetDBDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public VetDBDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<DoctorRole> DoctorRole
		{
			get
			{
				return this.GetTable<DoctorRole>();
			}
		}
		
		public System.Data.Linq.Table<Pet> Pet
		{
			get
			{
				return this.GetTable<Pet>();
			}
		}
		
		public System.Data.Linq.Table<Role> Role
		{
			get
			{
				return this.GetTable<Role>();
			}
		}
		
		public System.Data.Linq.Table<Client> Client
		{
			get
			{
				return this.GetTable<Client>();
			}
		}
		
		public System.Data.Linq.Table<Doctor> Doctor
		{
			get
			{
				return this.GetTable<Doctor>();
			}
		}
		
		public System.Data.Linq.Table<Recall> Recall
		{
			get
			{
				return this.GetTable<Recall>();
			}
		}
		
		public System.Data.Linq.Table<Card> Card
		{
			get
			{
				return this.GetTable<Card>();
			}
		}
		
		public System.Data.Linq.Table<Schedule> Schedule
		{
			get
			{
				return this.GetTable<Schedule>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DoctorRole")]
	public partial class DoctorRole : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private int _DoctorID;
		
		private int _RoleID;
		
		private EntityRef<Role> _Role;
		
		private EntityRef<Doctor> _Doctor;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnDoctorIDChanging(int value);
    partial void OnDoctorIDChanged();
    partial void OnRoleIDChanging(int value);
    partial void OnRoleIDChanged();
    #endregion
		
		public DoctorRole()
		{
			this._Role = default(EntityRef<Role>);
			this._Doctor = default(EntityRef<Doctor>);
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DoctorID", DbType="Int NOT NULL")]
		public int DoctorID
		{
			get
			{
				return this._DoctorID;
			}
			set
			{
				if ((this._DoctorID != value))
				{
					if (this._Doctor.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnDoctorIDChanging(value);
					this.SendPropertyChanging();
					this._DoctorID = value;
					this.SendPropertyChanged("DoctorID");
					this.OnDoctorIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RoleID", DbType="Int NOT NULL")]
		public int RoleID
		{
			get
			{
				return this._RoleID;
			}
			set
			{
				if ((this._RoleID != value))
				{
					if (this._Role.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnRoleIDChanging(value);
					this.SendPropertyChanging();
					this._RoleID = value;
					this.SendPropertyChanged("RoleID");
					this.OnRoleIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Role_DoctorRole", Storage="_Role", ThisKey="RoleID", OtherKey="ID", IsForeignKey=true)]
		public Role Role
		{
			get
			{
				return this._Role.Entity;
			}
			set
			{
				Role previousValue = this._Role.Entity;
				if (((previousValue != value) 
							|| (this._Role.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Role.Entity = null;
						previousValue.DoctorRole.Remove(this);
					}
					this._Role.Entity = value;
					if ((value != null))
					{
						value.DoctorRole.Add(this);
						this._RoleID = value.ID;
					}
					else
					{
						this._RoleID = default(int);
					}
					this.SendPropertyChanged("Role");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Doctor_DoctorRole", Storage="_Doctor", ThisKey="DoctorID", OtherKey="ID", IsForeignKey=true)]
		public Doctor Doctor
		{
			get
			{
				return this._Doctor.Entity;
			}
			set
			{
				Doctor previousValue = this._Doctor.Entity;
				if (((previousValue != value) 
							|| (this._Doctor.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Doctor.Entity = null;
						previousValue.DoctorRole.Remove(this);
					}
					this._Doctor.Entity = value;
					if ((value != null))
					{
						value.DoctorRole.Add(this);
						this._DoctorID = value.ID;
					}
					else
					{
						this._DoctorID = default(int);
					}
					this.SendPropertyChanged("Doctor");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Pet")]
	public partial class Pet : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Name;
		
		private int _Master;
		
		private string _Kind;
		
		private EntitySet<Card> _Card;
		
		private EntityRef<Client> _Client;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnMasterChanging(int value);
    partial void OnMasterChanged();
    partial void OnKindChanging(string value);
    partial void OnKindChanged();
    #endregion
		
		public Pet()
		{
			this._Card = new EntitySet<Card>(new Action<Card>(this.attach_Card), new Action<Card>(this.detach_Card));
			this._Client = default(EntityRef<Client>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Master", DbType="Int NOT NULL")]
		public int Master
		{
			get
			{
				return this._Master;
			}
			set
			{
				if ((this._Master != value))
				{
					if (this._Client.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMasterChanging(value);
					this.SendPropertyChanging();
					this._Master = value;
					this.SendPropertyChanged("Master");
					this.OnMasterChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Kind", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Kind
		{
			get
			{
				return this._Kind;
			}
			set
			{
				if ((this._Kind != value))
				{
					this.OnKindChanging(value);
					this.SendPropertyChanging();
					this._Kind = value;
					this.SendPropertyChanged("Kind");
					this.OnKindChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Pet_Card", Storage="_Card", ThisKey="ID", OtherKey="Pet")]
		public EntitySet<Card> Card
		{
			get
			{
				return this._Card;
			}
			set
			{
				this._Card.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Client_Pet", Storage="_Client", ThisKey="Master", OtherKey="ID", IsForeignKey=true)]
		public Client Client
		{
			get
			{
				return this._Client.Entity;
			}
			set
			{
				Client previousValue = this._Client.Entity;
				if (((previousValue != value) 
							|| (this._Client.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Client.Entity = null;
						previousValue.Pet.Remove(this);
					}
					this._Client.Entity = value;
					if ((value != null))
					{
						value.Pet.Add(this);
						this._Master = value.ID;
					}
					else
					{
						this._Master = default(int);
					}
					this.SendPropertyChanged("Client");
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
		
		private void attach_Card(Card entity)
		{
			this.SendPropertyChanging();
			entity.Pet1 = this;
		}
		
		private void detach_Card(Card entity)
		{
			this.SendPropertyChanging();
			entity.Pet1 = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Role")]
	public partial class Role : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Code;
		
		private string _Name;
		
		private EntitySet<DoctorRole> _DoctorRole;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnCodeChanging(string value);
    partial void OnCodeChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    #endregion
		
		public Role()
		{
			this._DoctorRole = new EntitySet<DoctorRole>(new Action<DoctorRole>(this.attach_DoctorRole), new Action<DoctorRole>(this.detach_DoctorRole));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Code", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Code
		{
			get
			{
				return this._Code;
			}
			set
			{
				if ((this._Code != value))
				{
					this.OnCodeChanging(value);
					this.SendPropertyChanging();
					this._Code = value;
					this.SendPropertyChanged("Code");
					this.OnCodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Role_DoctorRole", Storage="_DoctorRole", ThisKey="ID", OtherKey="RoleID")]
		public EntitySet<DoctorRole> DoctorRole
		{
			get
			{
				return this._DoctorRole;
			}
			set
			{
				this._DoctorRole.Assign(value);
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
		
		private void attach_DoctorRole(DoctorRole entity)
		{
			this.SendPropertyChanging();
			entity.Role = this;
		}
		
		private void detach_DoctorRole(DoctorRole entity)
		{
			this.SendPropertyChanging();
			entity.Role = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Client")]
	public partial class Client : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Name;
		
		private string _Email;
		
		private string _Password;
		
		private EntitySet<Pet> _Pet;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    #endregion
		
		public Client()
		{
			this._Pet = new EntitySet<Pet>(new Action<Pet>(this.attach_Pet), new Action<Pet>(this.detach_Pet));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Client_Pet", Storage="_Pet", ThisKey="ID", OtherKey="Master")]
		public EntitySet<Pet> Pet
		{
			get
			{
				return this._Pet;
			}
			set
			{
				this._Pet.Assign(value);
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
		
		private void attach_Pet(Pet entity)
		{
			this.SendPropertyChanging();
			entity.Client = this;
		}
		
		private void detach_Pet(Pet entity)
		{
			this.SendPropertyChanging();
			entity.Client = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Doctor")]
	public partial class Doctor : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Name;
		
		private string _Email;
		
		private string _Password;
		
		private System.Nullable<bool> _ConfirmEmail;
		
		private EntitySet<DoctorRole> _DoctorRole;
		
		private EntitySet<Recall> _Recall;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnConfirmEmailChanging(System.Nullable<bool> value);
    partial void OnConfirmEmailChanged();
    #endregion
		
		public Doctor()
		{
			this._DoctorRole = new EntitySet<DoctorRole>(new Action<DoctorRole>(this.attach_DoctorRole), new Action<DoctorRole>(this.detach_DoctorRole));
			this._Recall = new EntitySet<Recall>(new Action<Recall>(this.attach_Recall), new Action<Recall>(this.detach_Recall));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ConfirmEmail", DbType="Bit")]
		public System.Nullable<bool> ConfirmEmail
		{
			get
			{
				return this._ConfirmEmail;
			}
			set
			{
				if ((this._ConfirmEmail != value))
				{
					this.OnConfirmEmailChanging(value);
					this.SendPropertyChanging();
					this._ConfirmEmail = value;
					this.SendPropertyChanged("ConfirmEmail");
					this.OnConfirmEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Doctor_DoctorRole", Storage="_DoctorRole", ThisKey="ID", OtherKey="DoctorID")]
		public EntitySet<DoctorRole> DoctorRole
		{
			get
			{
				return this._DoctorRole;
			}
			set
			{
				this._DoctorRole.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Doctor_Recall", Storage="_Recall", ThisKey="ID", OtherKey="DoctorID")]
		public EntitySet<Recall> Recall
		{
			get
			{
				return this._Recall;
			}
			set
			{
				this._Recall.Assign(value);
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
		
		private void attach_DoctorRole(DoctorRole entity)
		{
			this.SendPropertyChanging();
			entity.Doctor = this;
		}
		
		private void detach_DoctorRole(DoctorRole entity)
		{
			this.SendPropertyChanging();
			entity.Doctor = null;
		}
		
		private void attach_Recall(Recall entity)
		{
			this.SendPropertyChanging();
			entity.Doctor = this;
		}
		
		private void detach_Recall(Recall entity)
		{
			this.SendPropertyChanging();
			entity.Doctor = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Recall")]
	public partial class Recall : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private int _DoctorID;
		
		private string _Text;
		
		private System.DateTime _Date;
		
		private EntityRef<Doctor> _Doctor;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnDoctorIDChanging(int value);
    partial void OnDoctorIDChanged();
    partial void OnTextChanging(string value);
    partial void OnTextChanged();
    partial void OnDateChanging(System.DateTime value);
    partial void OnDateChanged();
    #endregion
		
		public Recall()
		{
			this._Doctor = default(EntityRef<Doctor>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DoctorID", DbType="Int NOT NULL")]
		public int DoctorID
		{
			get
			{
				return this._DoctorID;
			}
			set
			{
				if ((this._DoctorID != value))
				{
					if (this._Doctor.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnDoctorIDChanging(value);
					this.SendPropertyChanging();
					this._DoctorID = value;
					this.SendPropertyChanged("DoctorID");
					this.OnDoctorIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Text", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Text
		{
			get
			{
				return this._Text;
			}
			set
			{
				if ((this._Text != value))
				{
					this.OnTextChanging(value);
					this.SendPropertyChanging();
					this._Text = value;
					this.SendPropertyChanged("Text");
					this.OnTextChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Date", DbType="Date NOT NULL")]
		public System.DateTime Date
		{
			get
			{
				return this._Date;
			}
			set
			{
				if ((this._Date != value))
				{
					this.OnDateChanging(value);
					this.SendPropertyChanging();
					this._Date = value;
					this.SendPropertyChanged("Date");
					this.OnDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Doctor_Recall", Storage="_Doctor", ThisKey="DoctorID", OtherKey="ID", IsForeignKey=true)]
		public Doctor Doctor
		{
			get
			{
				return this._Doctor.Entity;
			}
			set
			{
				Doctor previousValue = this._Doctor.Entity;
				if (((previousValue != value) 
							|| (this._Doctor.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Doctor.Entity = null;
						previousValue.Recall.Remove(this);
					}
					this._Doctor.Entity = value;
					if ((value != null))
					{
						value.Recall.Add(this);
						this._DoctorID = value.ID;
					}
					else
					{
						this._DoctorID = default(int);
					}
					this.SendPropertyChanged("Doctor");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Card")]
	public partial class Card : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Pet;
		
		private string _Disease;
		
		private System.DateTime _Date;
		
		private int _ID;
		
		private EntityRef<Pet> _Pet1;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnPetChanging(int value);
    partial void OnPetChanged();
    partial void OnDiseaseChanging(string value);
    partial void OnDiseaseChanged();
    partial void OnDateChanging(System.DateTime value);
    partial void OnDateChanged();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    #endregion
		
		public Card()
		{
			this._Pet1 = default(EntityRef<Pet>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Pet", DbType="Int NOT NULL")]
		public int Pet
		{
			get
			{
				return this._Pet;
			}
			set
			{
				if ((this._Pet != value))
				{
					if (this._Pet1.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnPetChanging(value);
					this.SendPropertyChanging();
					this._Pet = value;
					this.SendPropertyChanged("Pet");
					this.OnPetChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Disease", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Disease
		{
			get
			{
				return this._Disease;
			}
			set
			{
				if ((this._Disease != value))
				{
					this.OnDiseaseChanging(value);
					this.SendPropertyChanging();
					this._Disease = value;
					this.SendPropertyChanged("Disease");
					this.OnDiseaseChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Date", DbType="Date NOT NULL")]
		public System.DateTime Date
		{
			get
			{
				return this._Date;
			}
			set
			{
				if ((this._Date != value))
				{
					this.OnDateChanging(value);
					this.SendPropertyChanging();
					this._Date = value;
					this.SendPropertyChanged("Date");
					this.OnDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
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
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Pet_Card", Storage="_Pet1", ThisKey="Pet", OtherKey="ID", IsForeignKey=true)]
		public Pet Pet1
		{
			get
			{
				return this._Pet1.Entity;
			}
			set
			{
				Pet previousValue = this._Pet1.Entity;
				if (((previousValue != value) 
							|| (this._Pet1.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Pet1.Entity = null;
						previousValue.Card.Remove(this);
					}
					this._Pet1.Entity = value;
					if ((value != null))
					{
						value.Card.Add(this);
						this._Pet = value.ID;
					}
					else
					{
						this._Pet = default(int);
					}
					this.SendPropertyChanged("Pet1");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Schedule")]
	public partial class Schedule : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private int _Doctor;
		
		private int _Pet;
		
		private System.DateTime _Date;
		
		private string _Title;
		
		private string _Text;
		
		private string _Time;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnDoctorChanging(int value);
    partial void OnDoctorChanged();
    partial void OnPetChanging(int value);
    partial void OnPetChanged();
    partial void OnDateChanging(System.DateTime value);
    partial void OnDateChanged();
    partial void OnTitleChanging(string value);
    partial void OnTitleChanged();
    partial void OnTextChanging(string value);
    partial void OnTextChanged();
    partial void OnTimeChanging(string value);
    partial void OnTimeChanged();
    #endregion
		
		public Schedule()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Doctor", DbType="Int NOT NULL")]
		public int Doctor
		{
			get
			{
				return this._Doctor;
			}
			set
			{
				if ((this._Doctor != value))
				{
					this.OnDoctorChanging(value);
					this.SendPropertyChanging();
					this._Doctor = value;
					this.SendPropertyChanged("Doctor");
					this.OnDoctorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Pet", DbType="Int NOT NULL")]
		public int Pet
		{
			get
			{
				return this._Pet;
			}
			set
			{
				if ((this._Pet != value))
				{
					this.OnPetChanging(value);
					this.SendPropertyChanging();
					this._Pet = value;
					this.SendPropertyChanged("Pet");
					this.OnPetChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Date", DbType="Date NOT NULL")]
		public System.DateTime Date
		{
			get
			{
				return this._Date;
			}
			set
			{
				if ((this._Date != value))
				{
					this.OnDateChanging(value);
					this.SendPropertyChanging();
					this._Date = value;
					this.SendPropertyChanged("Date");
					this.OnDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Title", DbType="VarChar(50)")]
		public string Title
		{
			get
			{
				return this._Title;
			}
			set
			{
				if ((this._Title != value))
				{
					this.OnTitleChanging(value);
					this.SendPropertyChanging();
					this._Title = value;
					this.SendPropertyChanged("Title");
					this.OnTitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Text", DbType="VarChar(150)")]
		public string Text
		{
			get
			{
				return this._Text;
			}
			set
			{
				if ((this._Text != value))
				{
					this.OnTextChanging(value);
					this.SendPropertyChanging();
					this._Text = value;
					this.SendPropertyChanged("Text");
					this.OnTextChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Time", DbType="VarChar(5)")]
		public string Time
		{
			get
			{
				return this._Time;
			}
			set
			{
				if ((this._Time != value))
				{
					this.OnTimeChanging(value);
					this.SendPropertyChanging();
					this._Time = value;
					this.SendPropertyChanged("Time");
					this.OnTimeChanged();
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
