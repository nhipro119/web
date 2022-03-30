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

namespace CHBQA.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="CHBQA")]
	public partial class MyDataDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertCT_DDH(CT_DDH instance);
    partial void UpdateCT_DDH(CT_DDH instance);
    partial void DeleteCT_DDH(CT_DDH instance);
    partial void InsertDDH(DDH instance);
    partial void UpdateDDH(DDH instance);
    partial void DeleteDDH(DDH instance);
    partial void InsertKhachHang(KhachHang instance);
    partial void UpdateKhachHang(KhachHang instance);
    partial void DeleteKhachHang(KhachHang instance);
    partial void InsertLoaiHang(LoaiHang instance);
    partial void UpdateLoaiHang(LoaiHang instance);
    partial void DeleteLoaiHang(LoaiHang instance);
    partial void InsertQTV(QTV instance);
    partial void UpdateQTV(QTV instance);
    partial void DeleteQTV(QTV instance);
    partial void InsertSanPham(SanPham instance);
    partial void UpdateSanPham(SanPham instance);
    partial void DeleteSanPham(SanPham instance);
    #endregion
		
		public MyDataDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["CHBQAConnectionString1"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public MyDataDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MyDataDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MyDataDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MyDataDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<CT_DDH> CT_DDHs
		{
			get
			{
				return this.GetTable<CT_DDH>();
			}
		}
		
		public System.Data.Linq.Table<DDH> DDHs
		{
			get
			{
				return this.GetTable<DDH>();
			}
		}
		
		public System.Data.Linq.Table<KhachHang> KhachHangs
		{
			get
			{
				return this.GetTable<KhachHang>();
			}
		}
		
		public System.Data.Linq.Table<LoaiHang> LoaiHangs
		{
			get
			{
				return this.GetTable<LoaiHang>();
			}
		}
		
		public System.Data.Linq.Table<QTV> QTVs
		{
			get
			{
				return this.GetTable<QTV>();
			}
		}
		
		public System.Data.Linq.Table<SanPham> SanPhams
		{
			get
			{
				return this.GetTable<SanPham>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.CT_DDH")]
	public partial class CT_DDH : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id_ddh;
		
		private int _id_sp;
		
		private System.Nullable<int> _sl;
		
		private System.Nullable<int> _dongia;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onid_ddhChanging(int value);
    partial void Onid_ddhChanged();
    partial void Onid_spChanging(int value);
    partial void Onid_spChanged();
    partial void OnslChanging(System.Nullable<int> value);
    partial void OnslChanged();
    partial void OndongiaChanging(System.Nullable<int> value);
    partial void OndongiaChanged();
    #endregion
		
		public CT_DDH()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_ddh", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int id_ddh
		{
			get
			{
				return this._id_ddh;
			}
			set
			{
				if ((this._id_ddh != value))
				{
					this.Onid_ddhChanging(value);
					this.SendPropertyChanging();
					this._id_ddh = value;
					this.SendPropertyChanged("id_ddh");
					this.Onid_ddhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_sp", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int id_sp
		{
			get
			{
				return this._id_sp;
			}
			set
			{
				if ((this._id_sp != value))
				{
					this.Onid_spChanging(value);
					this.SendPropertyChanging();
					this._id_sp = value;
					this.SendPropertyChanged("id_sp");
					this.Onid_spChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sl", DbType="Int")]
		public System.Nullable<int> sl
		{
			get
			{
				return this._sl;
			}
			set
			{
				if ((this._sl != value))
				{
					this.OnslChanging(value);
					this.SendPropertyChanging();
					this._sl = value;
					this.SendPropertyChanged("sl");
					this.OnslChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_dongia", DbType="Int")]
		public System.Nullable<int> dongia
		{
			get
			{
				return this._dongia;
			}
			set
			{
				if ((this._dongia != value))
				{
					this.OndongiaChanging(value);
					this.SendPropertyChanging();
					this._dongia = value;
					this.SendPropertyChanged("dongia");
					this.OndongiaChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DDH")]
	public partial class DDH : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id_ddh;
		
		private System.Nullable<int> _trang_thai;
		
		private System.Nullable<int> _tong_tien;
		
		private System.Nullable<int> _id_kh;
		
		private string _sdt_kh;
		
		private string _email_kh;
		
		private string _diachi;
		
		private string _note;
		
		private System.Nullable<System.DateTime> _tg_tao;
		
		private System.Nullable<System.DateTime> _tg_giao;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onid_ddhChanging(int value);
    partial void Onid_ddhChanged();
    partial void Ontrang_thaiChanging(System.Nullable<int> value);
    partial void Ontrang_thaiChanged();
    partial void Ontong_tienChanging(System.Nullable<int> value);
    partial void Ontong_tienChanged();
    partial void Onid_khChanging(System.Nullable<int> value);
    partial void Onid_khChanged();
    partial void Onsdt_khChanging(string value);
    partial void Onsdt_khChanged();
    partial void Onemail_khChanging(string value);
    partial void Onemail_khChanged();
    partial void OndiachiChanging(string value);
    partial void OndiachiChanged();
    partial void OnnoteChanging(string value);
    partial void OnnoteChanged();
    partial void Ontg_taoChanging(System.Nullable<System.DateTime> value);
    partial void Ontg_taoChanged();
    partial void Ontg_giaoChanging(System.Nullable<System.DateTime> value);
    partial void Ontg_giaoChanged();
    #endregion
		
		public DDH()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_ddh", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id_ddh
		{
			get
			{
				return this._id_ddh;
			}
			set
			{
				if ((this._id_ddh != value))
				{
					this.Onid_ddhChanging(value);
					this.SendPropertyChanging();
					this._id_ddh = value;
					this.SendPropertyChanged("id_ddh");
					this.Onid_ddhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_trang_thai", DbType="Int")]
		public System.Nullable<int> trang_thai
		{
			get
			{
				return this._trang_thai;
			}
			set
			{
				if ((this._trang_thai != value))
				{
					this.Ontrang_thaiChanging(value);
					this.SendPropertyChanging();
					this._trang_thai = value;
					this.SendPropertyChanged("trang_thai");
					this.Ontrang_thaiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tong_tien", DbType="Int")]
		public System.Nullable<int> tong_tien
		{
			get
			{
				return this._tong_tien;
			}
			set
			{
				if ((this._tong_tien != value))
				{
					this.Ontong_tienChanging(value);
					this.SendPropertyChanging();
					this._tong_tien = value;
					this.SendPropertyChanged("tong_tien");
					this.Ontong_tienChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_kh", DbType="Int")]
		public System.Nullable<int> id_kh
		{
			get
			{
				return this._id_kh;
			}
			set
			{
				if ((this._id_kh != value))
				{
					this.Onid_khChanging(value);
					this.SendPropertyChanging();
					this._id_kh = value;
					this.SendPropertyChanged("id_kh");
					this.Onid_khChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sdt_kh", DbType="VarChar(15)")]
		public string sdt_kh
		{
			get
			{
				return this._sdt_kh;
			}
			set
			{
				if ((this._sdt_kh != value))
				{
					this.Onsdt_khChanging(value);
					this.SendPropertyChanging();
					this._sdt_kh = value;
					this.SendPropertyChanged("sdt_kh");
					this.Onsdt_khChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_email_kh", DbType="VarChar(50)")]
		public string email_kh
		{
			get
			{
				return this._email_kh;
			}
			set
			{
				if ((this._email_kh != value))
				{
					this.Onemail_khChanging(value);
					this.SendPropertyChanging();
					this._email_kh = value;
					this.SendPropertyChanged("email_kh");
					this.Onemail_khChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_diachi", DbType="NVarChar(50)")]
		public string diachi
		{
			get
			{
				return this._diachi;
			}
			set
			{
				if ((this._diachi != value))
				{
					this.OndiachiChanging(value);
					this.SendPropertyChanging();
					this._diachi = value;
					this.SendPropertyChanged("diachi");
					this.OndiachiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_note", DbType="NVarChar(200)")]
		public string note
		{
			get
			{
				return this._note;
			}
			set
			{
				if ((this._note != value))
				{
					this.OnnoteChanging(value);
					this.SendPropertyChanging();
					this._note = value;
					this.SendPropertyChanged("note");
					this.OnnoteChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tg_tao", DbType="Date")]
		public System.Nullable<System.DateTime> tg_tao
		{
			get
			{
				return this._tg_tao;
			}
			set
			{
				if ((this._tg_tao != value))
				{
					this.Ontg_taoChanging(value);
					this.SendPropertyChanging();
					this._tg_tao = value;
					this.SendPropertyChanged("tg_tao");
					this.Ontg_taoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tg_giao", DbType="Date")]
		public System.Nullable<System.DateTime> tg_giao
		{
			get
			{
				return this._tg_giao;
			}
			set
			{
				if ((this._tg_giao != value))
				{
					this.Ontg_giaoChanging(value);
					this.SendPropertyChanging();
					this._tg_giao = value;
					this.SendPropertyChanged("tg_giao");
					this.Ontg_giaoChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.KhachHang")]
	public partial class KhachHang : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id_kh;
		
		private string _ten;
		
		private string _sdt;
		
		private string _email;
		
		private string _taikhoan;
		
		private string _matkhau;
		
		private string _diachi;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onid_khChanging(int value);
    partial void Onid_khChanged();
    partial void OntenChanging(string value);
    partial void OntenChanged();
    partial void OnsdtChanging(string value);
    partial void OnsdtChanged();
    partial void OnemailChanging(string value);
    partial void OnemailChanged();
    partial void OntaikhoanChanging(string value);
    partial void OntaikhoanChanged();
    partial void OnmatkhauChanging(string value);
    partial void OnmatkhauChanged();
    partial void OndiachiChanging(string value);
    partial void OndiachiChanged();
    #endregion
		
		public KhachHang()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_kh", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id_kh
		{
			get
			{
				return this._id_kh;
			}
			set
			{
				if ((this._id_kh != value))
				{
					this.Onid_khChanging(value);
					this.SendPropertyChanging();
					this._id_kh = value;
					this.SendPropertyChanged("id_kh");
					this.Onid_khChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ten", DbType="NVarChar(50)")]
		public string ten
		{
			get
			{
				return this._ten;
			}
			set
			{
				if ((this._ten != value))
				{
					this.OntenChanging(value);
					this.SendPropertyChanging();
					this._ten = value;
					this.SendPropertyChanged("ten");
					this.OntenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sdt", DbType="VarChar(15)")]
		public string sdt
		{
			get
			{
				return this._sdt;
			}
			set
			{
				if ((this._sdt != value))
				{
					this.OnsdtChanging(value);
					this.SendPropertyChanging();
					this._sdt = value;
					this.SendPropertyChanged("sdt");
					this.OnsdtChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_email", DbType="VarChar(50)")]
		public string email
		{
			get
			{
				return this._email;
			}
			set
			{
				if ((this._email != value))
				{
					this.OnemailChanging(value);
					this.SendPropertyChanging();
					this._email = value;
					this.SendPropertyChanged("email");
					this.OnemailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_taikhoan", DbType="VarChar(50)")]
		public string taikhoan
		{
			get
			{
				return this._taikhoan;
			}
			set
			{
				if ((this._taikhoan != value))
				{
					this.OntaikhoanChanging(value);
					this.SendPropertyChanging();
					this._taikhoan = value;
					this.SendPropertyChanged("taikhoan");
					this.OntaikhoanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_matkhau", DbType="VarChar(50)")]
		public string matkhau
		{
			get
			{
				return this._matkhau;
			}
			set
			{
				if ((this._matkhau != value))
				{
					this.OnmatkhauChanging(value);
					this.SendPropertyChanging();
					this._matkhau = value;
					this.SendPropertyChanged("matkhau");
					this.OnmatkhauChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_diachi", DbType="NVarChar(50)")]
		public string diachi
		{
			get
			{
				return this._diachi;
			}
			set
			{
				if ((this._diachi != value))
				{
					this.OndiachiChanging(value);
					this.SendPropertyChanging();
					this._diachi = value;
					this.SendPropertyChanged("diachi");
					this.OndiachiChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.LoaiHang")]
	public partial class LoaiHang : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id_lh;
		
		private string _ten_lh;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onid_lhChanging(int value);
    partial void Onid_lhChanged();
    partial void Onten_lhChanging(string value);
    partial void Onten_lhChanged();
    #endregion
		
		public LoaiHang()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_lh", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id_lh
		{
			get
			{
				return this._id_lh;
			}
			set
			{
				if ((this._id_lh != value))
				{
					this.Onid_lhChanging(value);
					this.SendPropertyChanging();
					this._id_lh = value;
					this.SendPropertyChanged("id_lh");
					this.Onid_lhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ten_lh", DbType="NVarChar(50)")]
		public string ten_lh
		{
			get
			{
				return this._ten_lh;
			}
			set
			{
				if ((this._ten_lh != value))
				{
					this.Onten_lhChanging(value);
					this.SendPropertyChanging();
					this._ten_lh = value;
					this.SendPropertyChanged("ten_lh");
					this.Onten_lhChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.QTV")]
	public partial class QTV : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _taikhoan;
		
		private string _matkhau;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OntaikhoanChanging(string value);
    partial void OntaikhoanChanged();
    partial void OnmatkhauChanging(string value);
    partial void OnmatkhauChanged();
    #endregion
		
		public QTV()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_taikhoan", DbType="VarChar(10)")]
		public string taikhoan
		{
			get
			{
				return this._taikhoan;
			}
			set
			{
				if ((this._taikhoan != value))
				{
					this.OntaikhoanChanging(value);
					this.SendPropertyChanging();
					this._taikhoan = value;
					this.SendPropertyChanged("taikhoan");
					this.OntaikhoanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_matkhau", DbType="VarChar(20)")]
		public string matkhau
		{
			get
			{
				return this._matkhau;
			}
			set
			{
				if ((this._matkhau != value))
				{
					this.OnmatkhauChanging(value);
					this.SendPropertyChanging();
					this._matkhau = value;
					this.SendPropertyChanged("matkhau");
					this.OnmatkhauChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.SanPham")]
	public partial class SanPham : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id_sp;
		
		private System.Nullable<int> _id_lh;
		
		private System.Nullable<int> _giaban;
		
		private System.Nullable<int> _gianhap;
		
		private System.Nullable<int> _sl;
		
		private System.Nullable<System.DateTime> _tg_tao;
		
		private System.Nullable<bool> _isdelete;
		
		private string _ten_sp;
		
		private string _hinh1;
		
		private string _hinh2;
		
		private string _hinh3;
		
		private string _hinh4;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onid_spChanging(int value);
    partial void Onid_spChanged();
    partial void Onid_lhChanging(System.Nullable<int> value);
    partial void Onid_lhChanged();
    partial void OngiabanChanging(System.Nullable<int> value);
    partial void OngiabanChanged();
    partial void OngianhapChanging(System.Nullable<int> value);
    partial void OngianhapChanged();
    partial void OnslChanging(System.Nullable<int> value);
    partial void OnslChanged();
    partial void Ontg_taoChanging(System.Nullable<System.DateTime> value);
    partial void Ontg_taoChanged();
    partial void OnisdeleteChanging(System.Nullable<bool> value);
    partial void OnisdeleteChanged();
    partial void Onten_spChanging(string value);
    partial void Onten_spChanged();
    partial void Onhinh1Changing(string value);
    partial void Onhinh1Changed();
    partial void Onhinh2Changing(string value);
    partial void Onhinh2Changed();
    partial void Onhinh3Changing(string value);
    partial void Onhinh3Changed();
    partial void Onhinh4Changing(string value);
    partial void Onhinh4Changed();
    #endregion
		
		public SanPham()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_sp", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id_sp
		{
			get
			{
				return this._id_sp;
			}
			set
			{
				if ((this._id_sp != value))
				{
					this.Onid_spChanging(value);
					this.SendPropertyChanging();
					this._id_sp = value;
					this.SendPropertyChanged("id_sp");
					this.Onid_spChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_lh", DbType="Int")]
		public System.Nullable<int> id_lh
		{
			get
			{
				return this._id_lh;
			}
			set
			{
				if ((this._id_lh != value))
				{
					this.Onid_lhChanging(value);
					this.SendPropertyChanging();
					this._id_lh = value;
					this.SendPropertyChanged("id_lh");
					this.Onid_lhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_giaban", DbType="Int")]
		public System.Nullable<int> giaban
		{
			get
			{
				return this._giaban;
			}
			set
			{
				if ((this._giaban != value))
				{
					this.OngiabanChanging(value);
					this.SendPropertyChanging();
					this._giaban = value;
					this.SendPropertyChanged("giaban");
					this.OngiabanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_gianhap", DbType="Int")]
		public System.Nullable<int> gianhap
		{
			get
			{
				return this._gianhap;
			}
			set
			{
				if ((this._gianhap != value))
				{
					this.OngianhapChanging(value);
					this.SendPropertyChanging();
					this._gianhap = value;
					this.SendPropertyChanged("gianhap");
					this.OngianhapChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sl", DbType="Int")]
		public System.Nullable<int> sl
		{
			get
			{
				return this._sl;
			}
			set
			{
				if ((this._sl != value))
				{
					this.OnslChanging(value);
					this.SendPropertyChanging();
					this._sl = value;
					this.SendPropertyChanged("sl");
					this.OnslChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tg_tao", DbType="Date")]
		public System.Nullable<System.DateTime> tg_tao
		{
			get
			{
				return this._tg_tao;
			}
			set
			{
				if ((this._tg_tao != value))
				{
					this.Ontg_taoChanging(value);
					this.SendPropertyChanging();
					this._tg_tao = value;
					this.SendPropertyChanged("tg_tao");
					this.Ontg_taoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_isdelete", DbType="Bit")]
		public System.Nullable<bool> isdelete
		{
			get
			{
				return this._isdelete;
			}
			set
			{
				if ((this._isdelete != value))
				{
					this.OnisdeleteChanging(value);
					this.SendPropertyChanging();
					this._isdelete = value;
					this.SendPropertyChanged("isdelete");
					this.OnisdeleteChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ten_sp", DbType="NVarChar(50)")]
		public string ten_sp
		{
			get
			{
				return this._ten_sp;
			}
			set
			{
				if ((this._ten_sp != value))
				{
					this.Onten_spChanging(value);
					this.SendPropertyChanging();
					this._ten_sp = value;
					this.SendPropertyChanged("ten_sp");
					this.Onten_spChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_hinh1", DbType="VarChar(100)")]
		public string hinh1
		{
			get
			{
				return this._hinh1;
			}
			set
			{
				if ((this._hinh1 != value))
				{
					this.Onhinh1Changing(value);
					this.SendPropertyChanging();
					this._hinh1 = value;
					this.SendPropertyChanged("hinh1");
					this.Onhinh1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_hinh2", DbType="VarChar(100)")]
		public string hinh2
		{
			get
			{
				return this._hinh2;
			}
			set
			{
				if ((this._hinh2 != value))
				{
					this.Onhinh2Changing(value);
					this.SendPropertyChanging();
					this._hinh2 = value;
					this.SendPropertyChanged("hinh2");
					this.Onhinh2Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_hinh3", DbType="VarChar(100)")]
		public string hinh3
		{
			get
			{
				return this._hinh3;
			}
			set
			{
				if ((this._hinh3 != value))
				{
					this.Onhinh3Changing(value);
					this.SendPropertyChanging();
					this._hinh3 = value;
					this.SendPropertyChanged("hinh3");
					this.Onhinh3Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_hinh4", DbType="VarChar(100)")]
		public string hinh4
		{
			get
			{
				return this._hinh4;
			}
			set
			{
				if ((this._hinh4 != value))
				{
					this.Onhinh4Changing(value);
					this.SendPropertyChanging();
					this._hinh4 = value;
					this.SendPropertyChanged("hinh4");
					this.Onhinh4Changed();
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
