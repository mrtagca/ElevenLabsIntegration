using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseTypes
{
	public class DbResultBase
	{
		public DbResultBase()
		{
		}

		public DbResultBase(DbResultBase clone)
		{
			AffectedRows = clone.AffectedRows;
			RecordId = clone.RecordId;
			DbTran = clone.DbTran;
			Error = clone.Error;
			Success = clone.Success;
		}
		public DbResultBase(SqlTransaction dbTran)
		{
			DbTran = dbTran;
		}
		public DbResultBase(Exception exp, SqlTransaction dbTran) : this(dbTran)
		{
			Error = new ErrorModel(exp);
		}

		public DbResultBase(bool success, string errMessage) : this()
		{
			_success = success;
			if (!success && !string.IsNullOrWhiteSpace(errMessage))
				_error = new ErrorModel(errMessage);
		}
		private bool _success = true;
		public bool Success { get => _success; set => _success = value; }
		public int? AffectedRows { get; set; }
		public long RecordId { get; set; }
		private ErrorModel _error = null;
		public ErrorModel Error { get => _error; set { _error = value; _success = value == null; } }
		public SqlTransaction DbTran { get; set; }
		public void CommitTransaction()
		{
			if (DbTran != null)
			{
				DbTran.Commit();

			}
		}
	}
}
