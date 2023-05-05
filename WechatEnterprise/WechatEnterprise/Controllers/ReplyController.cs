using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Newtonsoft.Json.Linq;
using WechatEnterprise.Model;

namespace WechatEnterprise.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class ReplyController: ControllerBase
	{
		private readonly ILogger<WeatherForecastController> _logger;
		private readonly IConfiguration config;
		public ReplyController(ILogger<WeatherForecastController> logger,IConfiguration config)
		{
			_logger = logger;
			this.config = config;
		}

		[HttpGet("VerifyURL")]
		public string VerifyURL(string timestamp,string nonce,string echostr,string msg_signature)
		{			
			Tencent.WXBizMsgCrypt wxcpt = new Tencent.WXBizMsgCrypt(config["Enterprice:ChatService:Token"], config["Enterprice:ChatService:EncodeAESKey"], config["Enterprice:CorpId"]);
			int ret = 0;
			string sEchoStr = "";
			ret = wxcpt.VerifyURL(msg_signature, timestamp, nonce, echostr, ref sEchoStr);
			if (ret != 0)
			{
				System.Console.WriteLine("ERR: VerifyURL fail, ret: " + ret);
				return string.Empty;
			}

			return sEchoStr;
		}
	}
}
