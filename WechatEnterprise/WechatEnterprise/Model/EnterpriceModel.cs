namespace WechatEnterprise.Model
{
	public class EnterpriceModel
	{
		/// <summary>
		/// 企业id
		/// </summary>
		public string CorpId { get; set; }

		/// <summary>
		/// 微信客服模型
		/// </summary>
		public ChatServiceModel ChatService { get; set; }
	}

	/// <summary>
	/// 微信客服模型
	/// </summary>
	public class ChatServiceModel
	{
		/// <summary>
		/// 服务secret
		/// </summary>
		public  string Secret { get; set; }

		/// <summary>
		/// 设置接收事件服务器 EncodingAESKey
		/// </summary>
		public string EncodeAESKey { get; set; }

		/// <summary>
		/// 设置接收事件服务器token
		/// </summary>
		public string Token { get; set; }
	}
}
