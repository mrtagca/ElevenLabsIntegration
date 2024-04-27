using BaseTypes;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestHelper
{
	public static class Requestor
	{
		public static RestResponse Request(BaseRequestType baseRequestType)
		{
			try
			{
				if (baseRequestType == null)
				{
					var options = new RestClientOptions()
					{
						MaxTimeout = -1,
					};
					var client = new RestClient(options);
					RestRequest request = new RestRequest();

					switch (baseRequestType.RequestMethod)
					{
						case BaseTypes.Enums.BaseRequestMethod.GET:
							request = new RestRequest(baseRequestType.Url, Method.Get);
							break;
						case BaseTypes.Enums.BaseRequestMethod.POST:
							request = new RestRequest(baseRequestType.Url, Method.Post);
							break;
						case BaseTypes.Enums.BaseRequestMethod.PUT:
							request = new RestRequest(baseRequestType.Url, Method.Put);
							break;
						case BaseTypes.Enums.BaseRequestMethod.DELETE:
							request = new RestRequest(baseRequestType.Url, Method.Delete);
							break;
						case BaseTypes.Enums.BaseRequestMethod.HEAD:
							request = new RestRequest(baseRequestType.Url, Method.Head);
							break;
						case BaseTypes.Enums.BaseRequestMethod.PATCH:
							request = new RestRequest(baseRequestType.Url, Method.Patch);
							break;
						case BaseTypes.Enums.BaseRequestMethod.COPY:
							request = new RestRequest(baseRequestType.Url, Method.Copy);
							break;
						default:
							break;
					}

					if (baseRequestType.RequestHeaders != null)
					{
						foreach (var item in baseRequestType.RequestHeaders)
						{
							request.AddHeader(item.Key, item.Value);
						}
					}

					if (string.IsNullOrWhiteSpace(baseRequestType.JsonBody))
					{
						request.AddStringBody(baseRequestType.JsonBody, DataFormat.Json);
					}

					RestResponse response = client.ExecuteAsync(request).Result;
					return response;
				}
				else
					return null;
			}
			catch (Exception ex)
			{
				return null;
			}
		}
	}
}
