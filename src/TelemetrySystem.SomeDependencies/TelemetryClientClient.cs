using TDDMicroExercises.TelemetrySystem;

namespace TDDMicroExercises.TelemetrySystem.SomeDependencies
{
    public class TelemetryClientClient
    {
	    private ITelemetryClient _telemetryClient;
		// A class with the only goal of simulating a dependency on TelemetryClient
		// that has impact on the refactoring.

		public TelemetryClientClient(ITelemetryClient telemetryClient)
        {
		_telemetryClient = telemetryClient;	
            //var tc = new TelemetryClient();
            if (!_telemetryClient.OnlineStatus)
                _telemetryClient.Connect("a connection string");

            _telemetryClient.Send("some message");

            var response = _telemetryClient.Receive();

            _telemetryClient.Disconnect();

        }
    }
}
