﻿//Comments stolen from http://pushman.dfl.mn/documentation. Thanks @duffleman

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using pushcs.Api;

namespace pushcs.Api
{
	public class ApiRoot
	{
		/// <summary>
		/// This endpoint pushes an event to all listening clients on a single site.
		/// </summary>
		/// <param name="Private">The private key of a site you manage.</param>
		/// <param name="Event">The event name, EG. "blog_post".</param>
		/// <param name="Channels">a set of channel names your site has.</param>
		/// <param name="Payload">The set of data you may want the client to use.</param>
		/// <returns></returns>
		public Responses.PushResponse Push(string Private, string Event, string Channels = "", string Payload = "")
		{
			throw new NotImplementedException();
		}
		/// <summary>
		/// This method returns a list of all channels associated with your site. (including internal channels and the public chanel)
		/// </summary>
		/// <param name="Private">The private key of a site you manage.</param>
		/// <returns></returns>
		public Responses.ChannelsResponse Channels(string Private)
		{
			throw new NotImplementedException();
		}
		/// <summary>
		/// This method returns information on a channel.
		/// </summary>
		/// <param name="Private">The private key of a site you manage.</param>
		/// <param name="Channel">a name of a channel your site has.</param>
		/// <returns></returns>
		public Responses.ChannelResponseGet ChannelGet(string Private, string Channel)
		{
			throw new NotImplementedException();
		}
		/// <summary>
		/// This method builds a set of channels or single channel.
		/// </summary>
		/// <param name="Private">The private key of a site you manage.</param>
		/// <param name="Channel">A single string or JSON string representing an array.</param>
		/// <param name="max">The maximum amount of concurrent connections to the channel.</param>
		/// <param name="refreshes">Should the channels public token refresh every 60 minutes?</param>
		/// <returns></returns>
		public Responses.ChannelResponsePost ChannelPost(string Private, string Channel, int max = 0, bool refreshes = false)
		{
			throw new NotImplementedException();
		}
		/// <summary>
		/// This method destroys a set of channels or single channel.
		/// </summary>
		/// <param name="Private">The private key of a site you manage.</param>
		/// <param name="Channel">A single string or JSON string representing an array.</param>
		/// <returns></returns>
		public Responses.ChannelResponseDelete ChannelDelete(string Private, string Channel)
		{
			throw new NotImplementedException();
		}
		/// <summary>
		/// This method returns a list of all subscribers listening to a specific channel on a site, along with their IP and userdata.
		/// </summary>
		/// <param name="Private">The private key of a site you manage.</param>
		/// <param name="Channel">The name of the channel desired</param>
		/// <returns></returns>
		public Responses.SubscribersResponse Subscribers(string Private, string Channel)
		{
			throw new NotImplementedException();
		}
	}
}