using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThirdPartyTypes.ElevenLabs;

namespace ThirdPartyTypes.ElevenLabs
{
	public class FinetuningProgress
	{
	}

	public class FineTuning
	{
		public bool is_allowed_to_fine_tune { get; set; }
		public string finetuning_state { get; set; }
		public List<object> verification_failures { get; set; }
		public int verification_attempts_count { get; set; }
		public bool manual_verification_requested { get; set; }
		public string language { get; set; }
		public FinetuningProgress finetuning_progress { get; set; }
		public object message { get; set; }
		public object dataset_duration_seconds { get; set; }
		public object verification_attempts { get; set; }
		public object slice_ids { get; set; }
		public object manual_verification { get; set; }
	}

	public class Labels
	{
		public string accent { get; set; }
		public string description { get; set; }
		public string age { get; set; }
		public string gender { get; set; }
		public string usecase { get; set; }
		public string featured { get; set; }
	}

	public class VoiceVerification
	{
		public bool requires_verification { get; set; }
		public bool is_verified { get; set; }
		public List<object> verification_failures { get; set; }
		public int verification_attempts_count { get; set; }
		public object language { get; set; }
		public object verification_attempts { get; set; }
	}

	public class Voice
	{
		public string voice_id { get; set; }
		public string name { get; set; }
		public object samples { get; set; }
		public string category { get; set; }
		public FineTuning fine_tuning { get; set; }
		public Labels labels { get; set; }
		public string description { get; set; }
		public string preview_url { get; set; }
		public List<object> available_for_tiers { get; set; }
		public object settings { get; set; }
		public object sharing { get; set; }
		public List<string> high_quality_base_model_ids { get; set; }
		public object safety_control { get; set; }
		public VoiceVerification voice_verification { get; set; }
		public string owner_id { get; set; }
		public string permission_on_resource { get; set; }
	}

	public class VoiceModel
	{
		public List<Voice> voices { get; set; }
	}


}
