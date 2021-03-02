using AllShowMVC.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllShowMVC.Dao.sql
{
    public class BaseSqlDao
    {
        protected readonly string connectionString;
        public BaseSqlDao()
        {
            this.connectionString = ConfigTool.GetDBConnectionString("DefaultConnection");
        }
    }
}
