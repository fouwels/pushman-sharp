using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using pushcs.Api;

namespace pushcs
{
    public class Client
    {
		private ApiRoot ap;
		private string _key;
		public Client(string SitePrivateKey, string HostUrl = "http://live.pushman.dfl.mn", string UserAgent = "")
        {
			if (SitePrivateKey.Length != 60) {
				throw new ArgumentException("Private Key must be 60 characters");
			}
			_key = SitePrivateKey;
			var userAgent = UserAgent;
			var baseUrl = (HostUrl.ToArray().Last() != '/') ? HostUrl : HostUrl.Remove(HostUrl.Length - 1);
			ap = new ApiRoot(baseUrl, userAgent);

		}

		public async Task<Api.Responses.PushResponse> PushEvent(string Name, string Data, List<string> Channels = null)
		{
			return ap.Push(_key, Name, string.Join(",", Channels), Data);
		}
		public async Task<Api.Responses.ChannelsResponse> GetMyChannels()
		{
			return ap.Channels(_key);
		}
		public async Task<Api.Responses.ChannelResponseGet> GetChannelDetails(string Channel)
		{
			return ap.ChannelGet(_key, Channel);
		}
		public async Task<Api.Responses.ChannelResponsePost> CreateChannel(string Channel, int MaxConnections = 0, bool refreshTokenEvery60 = false)
		{
			return ap.ChannelPost(_key, Channel, MaxConnections, refreshTokenEvery60); 
		}
		public async Task<Api.Responses.ChannelResponseDelete> DropChannel(string Channel)
		{
			return ap.ChannelDelete(_key, Channel);
		}
		public async Task<Api.Responses.SubscribersResponse> GetSubscribers(string Channel)
		{
			return ap.Subscribers(_key, Channel);
		}
    }
}
