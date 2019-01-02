namespace SessionWorkshop.Infrastructures.Interfaces
{
	public interface ISessionContext
	{
		string Username { get; set; }

		bool IsAuthentication { get; }
	}
}