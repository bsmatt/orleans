namespace Orleans.Runtime
{
    /// <summary>
    /// Marker interface for all Telemetry Consumers that can/need to be closed
    /// </summary>
    public interface ICloseableTelemetryConsumer
    {
        void Close();
    }
}
