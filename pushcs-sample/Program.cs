using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Framework.ConfigurationModel;

namespace pushcs_sample
{
    public class Program
    {
        public void Main(string[] args)
        {
			var testkey = "this_is_a_60_char_string_that_looks_like_a_valid_private_key";

			//call api endpoints directly. Check the method tooltips, or XML comments directly
			var ap = new pushcs.Api.ApiRoot(
				BaseUrl: "http://live.pushman.dfl.mn/", UserAgent: "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/41.0.2228.0 Safari/537.36");

			var a =	ap.Push(Private: testkey, Event: "ayy", Payload: "{\"ayy\" : \"lemayo\"}");
			var b =	ap.Channels(Private: testkey);
			var c =	ap.ChannelGet(Private: testkey, Channel: "auth");
			var d =	ap.ChannelPost(Private: testkey, Channel: "auth");
			var e = ap.ChannelDelete(Private: testkey, Channel: "auth");
			var f =	ap.Subscribers(Private: testkey, Channel: "auth");

			var client = new pushcs.Client.Client();

        }
    }
}
