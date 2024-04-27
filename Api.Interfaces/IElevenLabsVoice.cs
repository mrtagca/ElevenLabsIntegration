using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThirdPartyTypes.ElevenLabs;

namespace Api.Interfaces
{
	public interface IElevenLabsVoice
	{
		public VoiceModel GetVoices(string apiKey);
	}
}
