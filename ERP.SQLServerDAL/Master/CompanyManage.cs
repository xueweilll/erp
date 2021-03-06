﻿using System;
using System.Collections.Generic;
using System.Text;
using CZZD.ERP.Common;
using System.Data;
using CZZD.ERP.DBUtility;
using CZZD.ERP.Model;
using System.Data.SqlClient;
using CZZD.ERP.IDAL;
using CZZD.ERP.CacheData;

namespace CZZD.ERP.SQLServerDAL
{
    public class CompanyManage:ICompany
    {

        public CompanyManage()
		{}
		#region  Method

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string CODE)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from BASE_COMPANY");
			strSql.Append(" where CODE=@CODE ");
			SqlParameter[] parameters = {
					new SqlParameter("@CODE", SqlDbType.VarChar,50)};
			parameters[0].Value = CODE;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
        public bool Add(CZZD.ERP.Model.BaseCompanyTable model)
		{
            StringBuilder strSql = null;
            int rows = 0;
            if (Exists(model.CODE))
            {
                #region 更新
                strSql = new StringBuilder();
                strSql.Append("update BASE_COMPANY set ");
                strSql.Append("NAME=@NAME,");
                strSql.Append("NAME_SHORT=@NAME_SHORT,");
                strSql.Append("NAME_ENGLISH=@NAME_ENGLISH,");
                strSql.Append("ZIP_CODE=@ZIP_CODE,");
                strSql.Append("ADDRESS_FIRST=@ADDRESS_FIRST,");
                strSql.Append("ADDRESS_MIDDLE=@ADDRESS_MIDDLE,");
                strSql.Append("ADDRESS_LAST=@ADDRESS_LAST,");
                strSql.Append("PHONE_NUMBER=@PHONE_NUMBER,");
                strSql.Append("FAX_NUMBER=@FAX_NUMBER,");
                strSql.Append("EMAIL=@EMAIL,");
                strSql.Append("URL=@URL,");
                strSql.Append("MEMO=@MEMO,");
                strSql.Append("STATUS_FLAG=@STATUS_FLAG,");
                strSql.Append("CREATE_USER=@CREATE_USER,");
                strSql.Append("CREATE_DATE_TIME=GETDATE(),");
                strSql.Append("LAST_UPDATE_USER=@LAST_UPDATE_USER,");
                strSql.Append("LAST_UPDATE_TIME=GETDATE()");
                strSql.Append(" where CODE=@CODE ");
                SqlParameter[] parameters = {
					new SqlParameter("@CODE", SqlDbType.VarChar,20),
					new SqlParameter("@NAME", SqlDbType.NVarChar,100),
					new SqlParameter("@NAME_SHORT", SqlDbType.NVarChar,50),
					new SqlParameter("@NAME_ENGLISH", SqlDbType.VarChar,50),
					new SqlParameter("@ZIP_CODE", SqlDbType.VarChar,8),
					new SqlParameter("@ADDRESS_FIRST", SqlDbType.NVarChar,100),
					new SqlParameter("@ADDRESS_MIDDLE", SqlDbType.NVarChar,100),
					new SqlParameter("@ADDRESS_LAST", SqlDbType.NVarChar,100),
					new SqlParameter("@PHONE_NUMBER", SqlDbType.VarChar,20),
					new SqlParameter("@FAX_NUMBER", SqlDbType.VarChar,20),
					new SqlParameter("@EMAIL", SqlDbType.VarChar,50),
					new SqlParameter("@URL", SqlDbType.VarChar,50),
					new SqlParameter("@MEMO", SqlDbType.NVarChar,255),
					new SqlParameter("@STATUS_FLAG", SqlDbType.Int,4),
                    new SqlParameter("@CREATE_USER", SqlDbType.VarChar,20),
					new SqlParameter("@LAST_UPDATE_USER", SqlDbType.VarChar,20)};
                parameters[0].Value = model.CODE;
                parameters[1].Value = model.NAME;
                parameters[2].Value = model.NAME_SHORT;
                parameters[3].Value = model.NAME_ENGLISH;
                parameters[4].Value = model.ZIP_CODE;
                parameters[5].Value = model.ADDRESS_FIRST;
                parameters[6].Value = model.ADDRESS_MIDDLE;
                parameters[7].Value = model.ADDRESS_LAST;
                parameters[8].Value = model.PHONE_NUMBER;
                parameters[9].Value = model.FAX_NUMBER;
                parameters[10].Value = model.EMAIL;
                parameters[11].Value = model.URL;
                parameters[12].Value = model.MEMO;
                parameters[13].Value = CConstant.NORMAL_STATUS;
                parameters[14].Value = model.CREATE_USER;
                parameters[15].Value = model.LAST_UPDATE_USER;
                rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
                #endregion
            }
            else
            {
                #region 增加
                strSql = new StringBuilder();
                strSql.Append("insert into BASE_COMPANY(");
                strSql.Append("CODE,NAME,NAME_SHORT,NAME_ENGLISH,ZIP_CODE,ADDRESS_FIRST,ADDRESS_MIDDLE,ADDRESS_LAST,PHONE_NUMBER,FAX_NUMBER,EMAIL,URL,MEMO,STATUS_FLAG,CREATE_USER,CREATE_DATE_TIME,LAST_UPDATE_USER,LAST_UPDATE_TIME)");
                strSql.Append(" values (");
                strSql.Append("@CODE,@NAME,@NAME_SHORT,@NAME_ENGLISH,@ZIP_CODE,@ADDRESS_FIRST,@ADDRESS_MIDDLE,@ADDRESS_LAST,@PHONE_NUMBER,@FAX_NUMBER,@EMAIL,@URL,@MEMO,@STATUS_FLAG,@CREATE_USER,GETDATE(),@LAST_UPDATE_USER,GETDATE())");
                SqlParameter[] parameters = {
					new SqlParameter("@CODE", SqlDbType.VarChar,20),
					new SqlParameter("@NAME", SqlDbType.NVarChar,100),
					new SqlParameter("@NAME_SHORT", SqlDbType.NVarChar,50),
					new SqlParameter("@NAME_ENGLISH", SqlDbType.VarChar,50),
					new SqlParameter("@ZIP_CODE", SqlDbType.VarChar,8),
					new SqlParameter("@ADDRESS_FIRST", SqlDbType.NVarChar,100),
					new SqlParameter("@ADDRESS_MIDDLE", SqlDbType.NVarChar,100),
					new SqlParameter("@ADDRESS_LAST", SqlDbType.NVarChar,100),
					new SqlParameter("@PHONE_NUMBER", SqlDbType.VarChar,20),
					new SqlParameter("@FAX_NUMBER", SqlDbType.VarChar,20),
					new SqlParameter("@EMAIL", SqlDbType.VarChar,50),
					new SqlParameter("@URL", SqlDbType.VarChar,50),
					new SqlParameter("@MEMO", SqlDbType.NVarChar,255),
					new SqlParameter("@STATUS_FLAG", SqlDbType.Int,4),
					new SqlParameter("@CREATE_USER", SqlDbType.VarChar,20),
					new SqlParameter("@LAST_UPDATE_USER", SqlDbType.VarChar,20)};
                parameters[0].Value = model.CODE;
                parameters[1].Value = model.NAME;
                parameters[2].Value = model.NAME_SHORT;
                parameters[3].Value = model.NAME_ENGLISH;
                parameters[4].Value = model.ZIP_CODE;
                parameters[5].Value = model.ADDRESS_FIRST;
                parameters[6].Value = model.ADDRESS_MIDDLE;
                parameters[7].Value = model.ADDRESS_LAST;
                parameters[8].Value = model.PHONE_NUMBER;
                parameters[9].Value = model.FAX_NUMBER;
                parameters[10].Value = model.EMAIL;
                parameters[11].Value = model.URL;
                parameters[12].Value = model.MEMO;
                parameters[13].Value = CConstant.INIT_STATUS;
                parameters[14].Value = model.CREATE_USER;
                parameters[15].Value = model.LAST_UPDATE_USER;
                rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
                #endregion
            }
            if (rows > 0)
            {
                CCacheData.Company = null;
                return true;
            }
            else
            {
                return false;
            }
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
        public bool Update(CZZD.ERP.Model.BaseCompanyTable model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update BASE_COMPANY set ");
			strSql.Append("NAME=@NAME,");
			strSql.Append("NAME_SHORT=@NAME_SHORT,");
			strSql.Append("NAME_ENGLISH=@NAME_ENGLISH,");
			strSql.Append("ZIP_CODE=@ZIP_CODE,");
			strSql.Append("ADDRESS_FIRST=@ADDRESS_FIRST,");
			strSql.Append("ADDRESS_MIDDLE=@ADDRESS_MIDDLE,");
			strSql.Append("ADDRESS_LAST=@ADDRESS_LAST,");
			strSql.Append("PHONE_NUMBER=@PHONE_NUMBER,");
			strSql.Append("FAX_NUMBER=@FAX_NUMBER,");
			strSql.Append("EMAIL=@EMAIL,");
			strSql.Append("URL=@URL,");
			strSql.Append("MEMO=@MEMO,");
            strSql.Append("STATUS_FLAG=@STATUS_FLAG,");
            strSql.Append("LAST_UPDATE_USER=@LAST_UPDATE_USER,");
            strSql.Append("LAST_UPDATE_TIME=GETDATE()");
			strSql.Append(" where CODE=@CODE ");
			SqlParameter[] parameters = {
					new SqlParameter("@CODE", SqlDbType.VarChar,20),
					new SqlParameter("@NAME", SqlDbType.NVarChar,100),
					new SqlParameter("@NAME_SHORT", SqlDbType.NVarChar,50),
					new SqlParameter("@NAME_ENGLISH", SqlDbType.VarChar,50),
					new SqlParameter("@ZIP_CODE", SqlDbType.VarChar,8),
					new SqlParameter("@ADDRESS_FIRST", SqlDbType.NVarChar,100),
					new SqlParameter("@ADDRESS_MIDDLE", SqlDbType.NVarChar,100),
					new SqlParameter("@ADDRESS_LAST", SqlDbType.NVarChar,100),
					new SqlParameter("@PHONE_NUMBER", SqlDbType.VarChar,20),
					new SqlParameter("@FAX_NUMBER", SqlDbType.VarChar,20),
					new SqlParameter("@EMAIL", SqlDbType.VarChar,50),
					new SqlParameter("@URL", SqlDbType.VarChar,50),
					new SqlParameter("@MEMO", SqlDbType.NVarChar,255),
					new SqlParameter("@STATUS_FLAG", SqlDbType.Int,4),
					new SqlParameter("@LAST_UPDATE_USER", SqlDbType.VarChar,20)};
			parameters[0].Value = model.CODE;
			parameters[1].Value = model.NAME;
			parameters[2].Value = model.NAME_SHORT;
			parameters[3].Value = model.NAME_ENGLISH;
			parameters[4].Value = model.ZIP_CODE;
			parameters[5].Value = model.ADDRESS_FIRST;
			parameters[6].Value = model.ADDRESS_MIDDLE;
			parameters[7].Value = model.ADDRESS_LAST;
			parameters[8].Value = model.PHONE_NUMBER;
			parameters[9].Value = model.FAX_NUMBER;
			parameters[10].Value = model.EMAIL;
			parameters[11].Value = model.URL;
			parameters[12].Value = model.MEMO;
			parameters[13].Value = model.STATUS_FLAG;
			parameters[14].Value = model.LAST_UPDATE_USER;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
                CCacheData.Company = null;
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string CODE)
		{
			
			StringBuilder strSql=new StringBuilder();
			
            strSql.AppendFormat("update BASE_COMPANY  set STATUS_FLAG = {0}", CConstant.DELETE_STATUS);
            strSql.Append(" where CODE=@CODE ");
			SqlParameter[] parameters = {
					new SqlParameter("@CODE", SqlDbType.VarChar,50)};
			parameters[0].Value = CODE;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
                CCacheData.Company = null;
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
        public CZZD.ERP.Model.BaseCompanyTable GetModel(string CODE)
		{			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 CODE,NAME,NAME_SHORT,NAME_ENGLISH,ZIP_CODE,ADDRESS_FIRST,ADDRESS_MIDDLE,ADDRESS_LAST,PHONE_NUMBER,FAX_NUMBER,EMAIL,URL,MEMO,STATUS_FLAG,CREATE_USER,CREATE_DATE_TIME,LAST_UPDATE_USER,LAST_UPDATE_TIME from BASE_COMPANY ");
			strSql.Append(" where CODE=@CODE ");
            strSql.AppendFormat(" and STATUS_FLAG <> {0}", CConstant.DELETE_STATUS);
			SqlParameter[] parameters = {
					new SqlParameter("@CODE", SqlDbType.VarChar,50)};
			parameters[0].Value = CODE;

            BaseCompanyTable model = new BaseCompanyTable();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				model.CODE=ds.Tables[0].Rows[0]["CODE"].ToString();
				model.NAME=ds.Tables[0].Rows[0]["NAME"].ToString();
				model.NAME_SHORT=ds.Tables[0].Rows[0]["NAME_SHORT"].ToString();
				model.NAME_ENGLISH=ds.Tables[0].Rows[0]["NAME_ENGLISH"].ToString();
				model.ZIP_CODE=ds.Tables[0].Rows[0]["ZIP_CODE"].ToString();
				model.ADDRESS_FIRST=ds.Tables[0].Rows[0]["ADDRESS_FIRST"].ToString();
				model.ADDRESS_MIDDLE=ds.Tables[0].Rows[0]["ADDRESS_MIDDLE"].ToString();
				model.ADDRESS_LAST=ds.Tables[0].Rows[0]["ADDRESS_LAST"].ToString();
				model.PHONE_NUMBER=ds.Tables[0].Rows[0]["PHONE_NUMBER"].ToString();
				model.FAX_NUMBER=ds.Tables[0].Rows[0]["FAX_NUMBER"].ToString();
				model.EMAIL=ds.Tables[0].Rows[0]["EMAIL"].ToString();
				model.URL=ds.Tables[0].Rows[0]["URL"].ToString();
				model.MEMO=ds.Tables[0].Rows[0]["MEMO"].ToString();
				if(ds.Tables[0].Rows[0]["STATUS_FLAG"].ToString()!="")
				{
					model.STATUS_FLAG=int.Parse(ds.Tables[0].Rows[0]["STATUS_FLAG"].ToString());
				}
				model.CREATE_USER=ds.Tables[0].Rows[0]["CREATE_USER"].ToString();
				if(ds.Tables[0].Rows[0]["CREATE_DATE_TIME"].ToString()!="")
				{
					model.CREATE_DATE_TIME=DateTime.Parse(ds.Tables[0].Rows[0]["CREATE_DATE_TIME"].ToString());
				}
				model.LAST_UPDATE_USER=ds.Tables[0].Rows[0]["LAST_UPDATE_USER"].ToString();
				if(ds.Tables[0].Rows[0]["LAST_UPDATE_TIME"].ToString()!="")
				{
					model.LAST_UPDATE_TIME=DateTime.Parse(ds.Tables[0].Rows[0]["LAST_UPDATE_TIME"].ToString());
				}
				return model;
			}
			else
			{
				return null;
			}
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select CODE,NAME,NAME_SHORT,NAME_ENGLISH,ZIP_CODE,ADDRESS_FIRST,ADDRESS_MIDDLE,ADDRESS_LAST,PHONE_NUMBER,FAX_NUMBER,EMAIL,URL,MEMO,STATUS_FLAG,CREATE_USER,CREATE_DATE_TIME,LAST_UPDATE_USER,LAST_UPDATE_TIME ");
			strSql.Append(" FROM BASE_COMPANY ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

        /// <summary>
        /// 获得分页数据总的记录条数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from BASE_COMPANY");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            object obj = DbHelperSQL.GetSingle(strSql.ToString());
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }

        /// <summary>
        /// 获得分页数据列表
        /// </summary>
        public DataSet GetList(string strWhere, string orderby, int startIndex, int endIndex)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM ( ");
            strSql.Append(" SELECT ROW_NUMBER() OVER (");
            if (!string.IsNullOrEmpty(orderby.Trim()))
            {
                strSql.Append("order by T." + orderby);
            }
            else
            {
                strSql.Append("order by T.CODE asc");
            }
            strSql.Append(")AS Row, T.* from BASE_COMPANY T");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperSQL.Query(strSql.ToString());
        }
		#endregion  Method
    }
}
       