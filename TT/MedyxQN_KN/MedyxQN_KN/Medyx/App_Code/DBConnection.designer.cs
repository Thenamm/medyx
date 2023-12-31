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



[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="MedYX_Hue_2104")]
public partial class DBConnectionDataContext : System.Data.Linq.DataContext
{
	
	private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
	
  #region Extensibility Method Definitions
  partial void OnCreated();
  #endregion
	
	public DBConnectionDataContext() : 
			base(global::System.Configuration.ConfigurationManager.ConnectionStrings["Medyx_YHCTTWConnectionString"].ConnectionString, mappingSource)
	{
		OnCreated();
	}
	
	public DBConnectionDataContext(string connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public DBConnectionDataContext(System.Data.IDbConnection connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public DBConnectionDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public DBConnectionDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_ViewMapping")]
	public ISingleResult<sp_ViewMappingResult> sp_ViewMapping([global::System.Data.Linq.Mapping.ParameterAttribute(Name="MaBa", DbType="NVarChar(12)")] string maBa)
	{
		IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), maBa);
		return ((ISingleResult<sp_ViewMappingResult>)(result.ReturnValue));
	}
	
	[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_GetAllDetailMappingByHTKeyAndDMKey")]
	public ISingleResult<sp_GetAllDetailMappingByHTKeyAndDMKeyResult> sp_GetAllDetailMappingByHTKeyAndDMKey([global::System.Data.Linq.Mapping.ParameterAttribute(Name="HaThangKey", DbType="NVarChar(100)")] string haThangKey, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="DMKey", DbType="NVarChar(100)")] string dMKey)
	{
		IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), haThangKey, dMKey);
		return ((ISingleResult<sp_GetAllDetailMappingByHTKeyAndDMKeyResult>)(result.ReturnValue));
	}
}

public partial class sp_ViewMappingResult
{
	
	private System.Nullable<int> _ID;
	
	private string _MaDTT;
	
	private string _TenDTT;
	
	private string _DanhMucName;
	
	private string _MaDanhMuc;
	
	private string _HTTableName;
	
	private string _HaThangCategoryItemMa;
	
	private string _TenHT;
	
	public sp_ViewMappingResult()
	{
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int")]
	public System.Nullable<int> ID
	{
		get
		{
			return this._ID;
		}
		set
		{
			if ((this._ID != value))
			{
				this._ID = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaDTT", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
	public string MaDTT
	{
		get
		{
			return this._MaDTT;
		}
		set
		{
			if ((this._MaDTT != value))
			{
				this._MaDTT = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenDTT", DbType="NVarChar(200)")]
	public string TenDTT
	{
		get
		{
			return this._TenDTT;
		}
		set
		{
			if ((this._TenDTT != value))
			{
				this._TenDTT = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DanhMucName", DbType="NVarChar(100)")]
	public string DanhMucName
	{
		get
		{
			return this._DanhMucName;
		}
		set
		{
			if ((this._DanhMucName != value))
			{
				this._DanhMucName = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaDanhMuc", DbType="NVarChar(10)")]
	public string MaDanhMuc
	{
		get
		{
			return this._MaDanhMuc;
		}
		set
		{
			if ((this._MaDanhMuc != value))
			{
				this._MaDanhMuc = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HTTableName", DbType="NVarChar(100)")]
	public string HTTableName
	{
		get
		{
			return this._HTTableName;
		}
		set
		{
			if ((this._HTTableName != value))
			{
				this._HTTableName = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HaThangCategoryItemMa", DbType="NVarChar(20)")]
	public string HaThangCategoryItemMa
	{
		get
		{
			return this._HaThangCategoryItemMa;
		}
		set
		{
			if ((this._HaThangCategoryItemMa != value))
			{
				this._HaThangCategoryItemMa = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenHT", DbType="NVarChar(100)")]
	public string TenHT
	{
		get
		{
			return this._TenHT;
		}
		set
		{
			if ((this._TenHT != value))
			{
				this._TenHT = value;
			}
		}
	}
}

public partial class sp_GetAllDetailMappingByHTKeyAndDMKeyResult
{
	
	private string _DanhMucName;
	
	private string _TableHaThang;
	
	private string _MaKeyDTT;
	
	private System.Nullable<int> _ID;
	
	private string _TenDTT;
	
	private string _KeyHT;
	
	private string _TenHT;
	
	public sp_GetAllDetailMappingByHTKeyAndDMKeyResult()
	{
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DanhMucName", DbType="NVarChar(100)")]
	public string DanhMucName
	{
		get
		{
			return this._DanhMucName;
		}
		set
		{
			if ((this._DanhMucName != value))
			{
				this._DanhMucName = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TableHaThang", DbType="NVarChar(100)")]
	public string TableHaThang
	{
		get
		{
			return this._TableHaThang;
		}
		set
		{
			if ((this._TableHaThang != value))
			{
				this._TableHaThang = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaKeyDTT", DbType="NVarChar(20)")]
	public string MaKeyDTT
	{
		get
		{
			return this._MaKeyDTT;
		}
		set
		{
			if ((this._MaKeyDTT != value))
			{
				this._MaKeyDTT = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int")]
	public System.Nullable<int> ID
	{
		get
		{
			return this._ID;
		}
		set
		{
			if ((this._ID != value))
			{
				this._ID = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenDTT", DbType="NVarChar(200)")]
	public string TenDTT
	{
		get
		{
			return this._TenDTT;
		}
		set
		{
			if ((this._TenDTT != value))
			{
				this._TenDTT = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_KeyHT", DbType="NVarChar(20)")]
	public string KeyHT
	{
		get
		{
			return this._KeyHT;
		}
		set
		{
			if ((this._KeyHT != value))
			{
				this._KeyHT = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenHT", DbType="NVarChar(100)")]
	public string TenHT
	{
		get
		{
			return this._TenHT;
		}
		set
		{
			if ((this._TenHT != value))
			{
				this._TenHT = value;
			}
		}
	}
}
#pragma warning restore 1591
