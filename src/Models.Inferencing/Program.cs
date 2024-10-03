using System.ClientModel;
using System.ClientModel.Primitives;
using Models.Inferencing;
using Models.Inferencing.Extensions;
using Models.Inferencing.Interceptors;
using OpenAI;
using OpenAI.Chat;

var localhostUri = new Uri("http://localhost:5272/v1/chat/completions");

OpenAIClientOptions clientOptions = new();
clientOptions.AddPolicy(new OverrideRequestUriPolicy(localhostUri), PipelinePosition.BeforeTransport);

var client = new OpenAIClient(new ApiKeyCredential("unused"), clientOptions);

var chatClient = client.GetChatClient("Phi-3-mini-128k-cpu-int4-rtn-block-32-onnx");
var resultA = await chatClient.CompleteChatAsync(new UserChatMessage("What is the golden ratio?"));
Console.WriteLine(resultA.Value.Content.GetResult());