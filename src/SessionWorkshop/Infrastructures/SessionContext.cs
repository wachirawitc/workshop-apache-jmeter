using Microsoft.AspNetCore.Http;
using SessionWorkshop.Infrastructures.Interfaces;

namespace SessionWorkshop.Infrastructures
{
	public class SessionContext : ISessionContext
	{
		public string Username
		{
			get => session.GetString(nameof(Username));
			set => session.SetString(nameof(Username), value);
		}

		public bool IsAuthentication => string.IsNullOrEmpty(Username) == false;

		private readonly ISession session;

		public SessionContext(IHttpContextAccessor httpContextAccessor)
		{
			session = httpContextAccessor?.HttpContext?.Session;
		}
	}
}