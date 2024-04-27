using Api.Interfaces;
using BaseTypes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ThirdPartyTypes.ElevenLabs;

namespace WebApi.Controllers
{
	[Route("[controller]/[action]")]
	[ApiController]
	public class VoiceController : ControllerBase
	{
        public IElevenLabsVoice _elevenLabsVoiceRepo;
        public VoiceController(IElevenLabsVoice elevenLabsVoiceRepo)
        {
			_elevenLabsVoiceRepo = elevenLabsVoiceRepo;
		}
		[HttpGet]
		public ResponseData<VoiceModel> GetVoices(string apiKey)
		{
			ResponseData<VoiceModel> response = new ResponseData<VoiceModel>();
			try
			{
				VoiceModel result = _elevenLabsVoiceRepo.GetVoices(apiKey);
				if (result != null)
				{
					response.Success = true;
					response.Data = result;
				}
				else
				{
					response.Success = false;
					response.Error = new Error("Model bulunamadı!");
				}
			}
			catch (Exception ex)
			{
				response.Success = false;
				response.Error = new Error(ex);
			}
			return response;
		}
	}
}
