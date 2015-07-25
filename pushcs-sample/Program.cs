using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Framework.ConfigurationModel;

namespace pushcs_sample
{
	public class Program
	{
		public async void Main(string[] args)
		{
			var testkey = "this_is_a_60_char_string_that_looks_like_a_valid_private_key";

			//calling api endpoints directly. Check the method tooltips, or XML comments directly
			var api = new pushcs.Api.ApiRoot(
				BaseUrl: "http://live.pushman.dfl.mn/",
				UserAgent: "Mozilla/5.0 (Windows NT 6.1) appleWebKit/537.36 (KHTML, like Gecko) Chrome/41.0.2228.0 Safari/537.36");

			var a = api.Push(Private: testkey, Event: "ayy", Payload: "{\"ayy\" : \"lemayo\"}");
			var b = api.Channels(Private: testkey);
			var c = api.ChannelGet(Private: testkey, Channel: "auth");
			var d = api.ChannelPost(Private: testkey, Channel: "auth");
			var e = api.ChannelDelete(Private: testkey, Channel: "auth");
			var f = api.Subscribers(Private: testkey, Channel: "auth");

			//using the shim client
			var client = new pushcs.Client(
				SitePrivateKey: testkey,
				HostUrl: "http://live.pushman.dfl.mn/");

			var x = await client.PushEvent(Name: "ayy", Data: "{ \"ayy\" : \"lmao\" }");
			//etc.
		}
	}
}
