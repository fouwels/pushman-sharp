using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace pushcs_xunit
{
    // This project can output the Class library as a NuGet Package.
    // To enable this option, right-click on the project and select the Properties menu item. In the Build tab select "Produce outputs on build".
    public class Tests
    {
        public Tests()
        {
        }

		[Fact]
		public void ApiConstructDefault() {
			pushcs.Api.ApiRoot api;
			api = new pushcs.Api.ApiRoot(); //using default parameters
		}
		[Fact]
		public void ApiConstructCustom()
		{
			pushcs.Api.ApiRoot api;
			api = new pushcs.Api.ApiRoot(BaseUrl: "http://live.pushman.dfl.mn", UserAgent: "dutchess"); //using custom parameters
			api = new pushcs.Api.ApiRoot(BaseUrl: "http://live.pushman.dfl.mn/", UserAgent: "dutchess"); //using custom parameters and excess slash
		}
		[Fact]
		public void ClientConstruct()
		{
			pushcs.Client client;
			client = new pushcs.Client("this_is_a_60_char_string_that_looks_like_a_valid_private_key");
			Assert.Throws(typeof(ArgumentException), () => { client = new pushcs.Client("nah"); });
		}

		[Fact]
		public void LazyApiExceptionTesting()
		{
			var testkey = "this_is_a_60_char_string_that_looks_like_a_valid_private_key";

			var api = new pushcs.Api.ApiRoot(
				BaseUrl: "http://live.pushman.dfl.mn/",
				UserAgent: "Mozilla/5.0 (Windows NT 6.1) appleWebKit/537.36 (KHTML, like Gecko) Chrome/41.0.2228.0 Safari/537.36");

			var a = api.Push(Private: testkey, Event: "ayy", Payload: "{\"ayy\" : \"lemayo\"}");
			var b = api.Channels(Private: testkey);
			var c = api.ChannelGet(Private: testkey, Channel: "auth");
			var d = api.ChannelPost(Private: testkey, Channel: "auth");
			var e = api.ChannelDelete(Private: testkey, Channel: "auth");
			var f = api.Subscribers(Private: testkey, Channel: "auth");
		}

		[Fact]
		public void LazyClientExceptionTesting()
		{
			var testkey = "this_is_a_60_char_string_that_looks_like_a_valid_private_key";
			var client = new pushcs.Client(
				SitePrivateKey: testkey,
				HostUrl: "http://live.pushman.dfl.mn/");

			var x = client.PushEvent(Name: "ayy", Data: "{ \"ayy\" : \"lmao\" }").Result;
			//todo rest of methods
		}
	}
}
