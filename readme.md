#Pushman-sharp

C# wrapper and shim client for the pushman (https://github.com/PushmanPHP/pushman) websockets event server.

## Installation
```json
Add dependency 'pushcs' to your project.json

"dependencies": {
	"pushcs": "1.2.1",
},

run a 'dnu restore' in console
```

To build from local files rather then pulling off nuget, add pushcs (core) to the solution and drop the version number.

```json
"dependencies": {
	"pushcs": ""
},
```

## Usage

Using the shim client. Doesn't do much vs calling directly apart from provide friendly method names and shims into awaitable task<t>s.

```csharp

var client = new pushcs.Client(
	SitePrivateKey: testkey, 
	HostUrl: "http://live.pushman.dfl.mn/");

await client.PushEvent(Name: "ayy", Data: "{ \"ayy\" : \"lmao\" }");
//etc. see intellisense or the class declaration

```

Calling endpoints directly.

```csharp
var testkey = "this_is_a_60_char_string_that_looks_like_a_valid_private_key";

var api = new pushcs.Api.ApiRoot(
	BaseUrl: "http://live.pushman.dfl.mn/", 
	UserAgent: "Mozilla/5.0 (Windows NT 6.1) appleWebKit/537.36 (KHTML, like Gecko) Chrome/41.0.2228.0 Safari/537.36");

#[POST] /api/push
var a =	api.Push(Private: testkey, Event: "ayy", Payload: "{\"ayy\" : \"lemayo\"}");

#[GET] /api/channels
var b =	api.Channels(Private: testkey);

#[GET] /api/channel
var c =	api.ChannelGet(Private: testkey, Channel: "auth");

#[POST] /api/channel
var d =	api.ChannelPost(Private: testkey, Channel: "auth");

#[DELETE] /api/channel
var e = api.ChannelDelete(Private: testkey, Channel: "auth");

#[GET] /api/subscribers
var f =	api.Subscribers(Private: testkey, Channel: "auth");

#endpoints return data in the form of the templates found under folder and namespace /api/responses

```

Methods are documented through intellisense, or you can lookup the xml comments manually. Source documentation at: http://pushman.dfl.mn/documentation

Use DNVM to build outside of visual studio, uses the vnext/asp.net 6 project system, rather than msbuild.

Available on nuget as package 'pushcs' (Install-Package pushcs) https://www.nuget.org/packages/pushcs/.
