namespace Profiler
{
	class Program
	{
		static void Main (string[] args)
		{
			var sdk = new LittleSdk.Messaging.Messaging(new LittleSdk.LittleSdk());

			sdk.Send ("Hello World!");
		}
	}
}
