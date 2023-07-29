using System;
namespace TDDMicroExercises.TelemetrySystem.SomeDependencies
{
    public class TelemetryDiagnosticControlsClient3
    {
	// A class with the only goal of simulating a dependency on TelemetryDiagnosticControls
	// that has impact on the refactoring.
	private TelemetryDiagnosticControlsUtils _telemetryDiagnosticControlsUtils;
	public TelemetryDiagnosticControlsClient3(TelemetryDiagnosticControlsUtils telemetryDiagnosticControlsUtils)
	{
		_telemetryDiagnosticControlsUtils = telemetryDiagnosticControlsUtils;
    		var result = _telemetryDiagnosticControlsUtils.GetDiagnosticInfo();
	}
    }
}
