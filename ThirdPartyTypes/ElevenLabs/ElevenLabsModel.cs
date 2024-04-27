using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdPartyTypes.ElevenLabs
{
	public class ElevenLabsModel
	{
		public string model_id { get; set; }
		public string name { get; set; }
		public bool can_be_finetuned { get; set; }
		public bool can_do_text_to_speech { get; set; }
		public bool can_do_voice_conversion { get; set; }
		public bool can_use_style { get; set; }
		public bool can_use_speaker_boost { get; set; }
		public bool serves_pro_voices { get; set; }
		public double token_cost_factor { get; set; }
		public string description { get; set; }
		public bool requires_alpha_access { get; set; }
		public int max_characters_request_free_user { get; set; }
		public int max_characters_request_subscribed_user { get; set; }
		public List<Language> languages { get; set; }
	}
}
