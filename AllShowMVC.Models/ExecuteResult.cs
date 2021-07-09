using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllShowMVC.Models
{
    public class ExecuteResult
    {
        public ExecuteResult()
        {
            DataList = new List<Object>();
            Success = false;
            Code = "";
        }

        public bool Success { get; set; }

        public string Message { get; set; }

        /// <summary>
        /// 回應代碼
        /// </summary>
        public string Code { get; set; }

        public Object Data { get; set; }
        public List<Object> DataList { get; set; }
    }
}
