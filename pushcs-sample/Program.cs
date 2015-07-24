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
			//var configuration = new Configuration();
			//configuration.AddJsonFile("config.json");
			//configuration.AddUserSecrets();

			var testkey = "this_is_a_60_char_string_that_looks_like_a_valid_private_key";

			var ap = new pushcs.Api.ApiRoot();
			var push =			ap.Push(			Private: testkey, Event: "ayy", Payload: "{\"ayy\" : \"lemayo\"}");
			var channels =		ap.Channels(		Private: testkey);
			var channelget =	ap.ChannelGet(		Private: testkey, Channel: "auth");
			var channelpost =	ap.ChannelPost(		Private: testkey, Channel: "auth");
			var channeldelete = ap.ChannelDelete(	Private: testkey, Channel: "auth");
			var subscribers =	ap.Subscribers(		Private: testkey, Channel: "auth");
        }
    }
}
