using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pushcs.Api.Responses
{
	public class ChannelsResponse
	{
		public string status { get; set; }
		public string message { get; set; }
		public string id { get; set; }
		public string name { get; set; }
		public string @public { get; set; }
		public string refreshes { get; set; }
		public string max_connections { get; set; }
		public string active_users { get; set; }
		public string events_fired { get; set; }
		public string created_at { get; set; }
	}
}
