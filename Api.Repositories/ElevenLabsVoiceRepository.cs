using Api.Interfaces;
using BaseTypes.Enums;
using BaseTypes;
using Newtonsoft.Json;
using RequestHelper;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThirdPartyTypes.ElevenLabs;

namespace Api.Repositories
{
	public class ElevenLabsVoiceRepository : IElevenLabsVoice
	{
		public VoiceModel GetVoices(string apiKey)
		{
			try
			{
				BaseRequestType baseRequestType = new BaseRequestType();
				baseRequestType.Url = "https://api.elevenlabs.io/v1/voices";
				baseRequestType.RequestMethod = BaseRequestMethod.GET;

				Dictionary<string, string> headers = new Dictionary<string, string>();
				headers.Add("xi-api-key", apiKey);
				baseRequestType.RequestHeaders = headers;

				RestResponse response = Requestor.Request(baseRequestType);
				VoiceModel elevenLabsVoice = JsonConvert.DeserializeObject<VoiceModel>(response.Content);
				if (elevenLabsVoice != null)
				{
					return elevenLabsVoice;
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
		}
	}
}
