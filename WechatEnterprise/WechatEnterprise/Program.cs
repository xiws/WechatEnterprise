using SKIT.FlurlHttpClient.Wechat.Work;
using WechatEnterprise.Model;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Logging.AddConsole();





//builder.Services.AddSingleton<WechatWorkClient>(server =>
//{
//	var options = new WechatWorkClientOptions()
//	{
//		CorpId = "��ҵ΢�� CorpId",
//		AgentId = "��ҵ΢��Ӧ�õ� AgentId",
//		AgentSecret = "��ҵ΢��Ӧ�õ� Secret"
//	};
//	var client = new WechatWorkClient(options);
	
//	return client;
//});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

//app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();
app.MapGet("/",  context =>
{
	context.Response.Redirect("/Reply/VerifyURL");
	return Task.CompletedTask;
});

app.Run();
