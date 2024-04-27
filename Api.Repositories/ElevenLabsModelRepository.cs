using Api.Interfaces;
using BaseTypes;
using BaseTypes.Enums;
using Contracts.Request;
using Newtonsoft.Json;
using RequestHelper;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using ThirdPartyTypes.ElevenLabs;

namespace Api.Repositories
{
	public class ElevenLabsModelRepository : IElevenLabsModel
	{
		public List<ElevenLabsModel> GetModel(string apiKey)
		{
			try
			{
				BaseRequestType baseRequestType = new BaseRequestType();
				baseRequestType.Url = "https://api.elevenlabs.io/v1/models";
				baseRequestType.RequestMethod = BaseRequestMethod.GET;

				Dictionary<string, string> headers = new Dictionary<string, string>();
				headers.Add("xi-api-key", apiKey);
				baseRequestType.RequestHeaders = headers;

				RestResponse response = Requestor.Request(baseRequestType);
				List<ElevenLabsModel> elevenLabsModel = JsonConvert.DeserializeObject<List<ElevenLabsModel>>(response.Content);
				if (elevenLabsModel !=null)
				{
					return elevenLabsModel;
				}
				else
				{
					return null;
				}
			}
			catch (Exception ex)
			{
				return null;
			}


			throw new NotImplementedException();
		}
	}
}
