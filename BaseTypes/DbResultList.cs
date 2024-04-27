using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseTypes
{
	public class DbResultList<T> : DbResultBase
	{
		public DbResultList() : base()
		{ }
		public DbResultList(DbResultBase baseObj, List<T> data = default) : base(baseObj)
		{
			Data = data;
		}
		public DbResultList(SqlTransaction dbTran) : base(dbTran)
		{ }
		public DbResultList(Exception exp, SqlTransaction dbTran) : base(exp, dbTran)
		{ }
		private List<T> _data;
		public List<T> Data { get => _data; set { _data = value; } }
	}
}
