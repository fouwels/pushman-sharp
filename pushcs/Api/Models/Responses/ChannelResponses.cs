using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pushcs.Api.Models.Responses
{
	public class ChannelResponseGet
	{
		public string id { get; set; }
		public string name { get; set; }
		public string @public { get; set; }
		public string refreshes { get; set; }
		public string max_connections { get; set; }
		public string active_users { get; set; }
		public string events_fired { get; set; }
		public string created_at { get; set; }
		public TokenExpires token_expires { get; set; }
		public class TokenExpires
		{
			public string date { get; set; }
			public int timezone_type { get; set; }
			public string timezone { get; set; }
		}
	}
	public class ChannelResponsePost
	{
		public string name { get; set; }
		public string refreshes { get; set; }
		public int max_connections { get; set; }
		public string @public { get; set; }
		public string created_at { get; set; }
		public int id { get; set; }
	}
	public class ChannelResponseDelete
	{
		public string status { get; set; }
		public string message { get; set; }
		public string deleted { get; set; }
		public string failed_on { get; set; }
	}
}
