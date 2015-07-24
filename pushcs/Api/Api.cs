using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using pushcs.Api;

namespace pushcs.Api
{
	public class Api
	{
		public Responses.PushResponse push(string Private, string Event, string Channels = "", string Payload = "")
		{
			throw new NotImplementedException();
		}
		public Responses.ChannelsResponse channels(string Private)
		{
			throw new NotImplementedException();
		}
		public Responses.ChannelResponseGet channelGet(string Private, string Channel)
		{
			throw new NotImplementedException();
		}
		public Responses.ChannelResponsePost channelPost(string Private, string Channel, int max = 0, bool refreshes = false)
		{
			throw new NotImplementedException();
		}
		public Responses.ChannelResponseDelete channelDelete(string Private, string Channel)
		{
			throw new NotImplementedException();
		}
		public Responses.SubscribersResponse subscribers(string Private, string Channel)
		{
			throw new NotImplementedException();
		}
	}
}
