using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pushcs.Models
{
	public class PushResponse
	{
		public string status { get; set; }
		public string message { get; set; }
		public string @event { get; set; }
		public List<Channel> channels { get; set; }
		public string site { get; set; }
		public Timestamp timestamp { get; set; }
		public Payload payload { get; set; }
		public class Channel
		{
			public string id { get; set; }
			public string name { get; set; }
			public string @public { get; set; }
			public string refreshes { get; set; }
			public string max_connections { get; set; }
			public string active_users { get; set; }
			public int events_fired { get; set; }
			public string created_at { get; set; }
		}

		public class Timestamp
		{
			public string date { get; set; }
			public int timezone_type { get; set; }
			public string timezone { get; set; }
		}

		public class Payload
		{
			public string foo { get; set; }
		}
	}
}
