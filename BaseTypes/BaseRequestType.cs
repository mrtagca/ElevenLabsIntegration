using BaseTypes.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseTypes
{
	public class BaseRequestType
	{
        public string Url { get; set; }
        public BaseRequestMethod RequestMethod { get; set; }
        public Dictionary<string,string> RequestHeaders { get; set; }
        public string JsonBody { get; set; }
    }
}
