﻿using Api.Interfaces;
using BaseTypes;
using Contracts.Request;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ThirdPartyTypes.ElevenLabs;

namespace WebApi.Controllers
{
	[Route("[controller]/[action]")]
	[ApiController]
	public class ModelsController : ControllerBase
	{
		IElevenLabsModel _elevenLabsModelRepo;
		public ModelsController(IElevenLabsModel elevenLabsModelRepo)
		{
			_elevenLabsModelRepo = elevenLabsModelRepo;
		}
		[HttpGet]
		public ResponseData<List<ElevenLabsModel>> GetModels(string apiKey)
		{
			ResponseData<List<ElevenLabsModel>> response = new ResponseData<List<ElevenLabsModel>>();
			try
			{
				List<ElevenLabsModel> result = _elevenLabsModelRepo.GetModel(apiKey);
				if (result!=null)
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
