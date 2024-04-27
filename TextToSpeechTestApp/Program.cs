using RestSharp;

var options = new RestClientOptions("https://api.elevenlabs.io")
{
	MaxTimeout = -1,
};
var client = new RestClient(options);
var request = new RestRequest("/v1/text-to-speech/5mhPllwlaNXrGtsasu6t?output_format=mp3_44100_96", Method.Post);
request.AddHeader("xi-api-key", "1c291edad859d25ae5551cc9182d6aa0");
request.AddHeader("Content-Type", "application/json");
var body = @"{
" + "\n" +
@"    ""text"" : ""Hi, everyone be ready?"",
" + "\n" +
@"    ""voice_settings"": {
" + "\n" +
@"    ""stability"": 1,
" + "\n" +
@"    ""similarity_boost"": 1,
" + "\n" +
@"    ""style"": 1,
" + "\n" +
@"    ""use_speaker_boost"": true
" + "\n" +
@"  }
" + "\n" +
@"}";
request.AddStringBody(body, DataFormat.Json);
RestResponse response = await client.ExecuteAsync(request);

// Yanıtın içeriğini kontrol et
if (response.StatusCode == System.Net.HttpStatusCode.OK && response.ContentType == "audio/mpeg")
{
	// Masaüstünde dosya oluştur
	string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
	string filePath = Path.Combine(desktopPath, "audio.mp3");

	// Yanıtın içeriğini dosyaya yaz
	File.WriteAllBytes(filePath, response.RawBytes);

	Console.WriteLine("Dosya başarıyla kaydedildi: " + filePath);
}
else
{
	Console.WriteLine("İstek başarısız oldu veya yanıt beklenen formatta değil.");
}
Console.WriteLine(response.Content);