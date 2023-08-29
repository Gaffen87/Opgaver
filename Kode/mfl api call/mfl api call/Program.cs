using System.Net.Http.Json;
using System.Net.Http.Headers;
using System.Text.Json;

namespace mfl_api_call
{
	internal class Program
	{
		static async Task Main(string[] args)
		{
			using HttpClient client = new();
			client.DefaultRequestHeaders.Accept.Clear();
			client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
			client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");

			await ProcessRepositoriesAsync(client);

			static async Task<List<Repository>> ProcessRepositoriesAsync(HttpClient client)
			{
				await using Stream stream = await client.GetStreamAsync("https://api.github.com/orgs/dotnet/repos");

				var repositories = await JsonSerializer.DeserializeAsync<List<Repository>>(stream);

				return repositories ?? new();
            }

			var repositories = await ProcessRepositoriesAsync(client);

			foreach (var repository in repositories)
			{
				Console.WriteLine(repository.Name);
			}

			Console.ReadLine();
		}
	}
}