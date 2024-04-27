using Contracts.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThirdPartyTypes.ElevenLabs;

namespace Api.Interfaces
{
	public interface IElevenLabsModel
	{
		public List<ElevenLabsModel> GetModel(string apiKey);
	}
}
