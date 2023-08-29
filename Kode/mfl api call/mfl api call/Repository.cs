using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace mfl_api_call
{
	public record class Repository(
		[property: JsonPropertyName("name")] string Name);
}
