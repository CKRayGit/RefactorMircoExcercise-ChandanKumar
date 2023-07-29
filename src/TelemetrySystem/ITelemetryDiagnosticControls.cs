
using System;

namespace TDDMicroExercises.TelemetrySystem
{
    public interface ITelemetryDiagnosticControls
    {
        string DiagnosticInfo
        {
            get;
            set;
        }

        void CheckTransmission();
    }
}
