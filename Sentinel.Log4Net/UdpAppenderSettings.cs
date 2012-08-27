namespace Sentinel.Log4Net
{
    using Sentinel.Interfaces.Providers;

    public class UdpAppenderSettings : IUdpAppenderListenerSettings
    {
        public UdpAppenderSettings(IProviderSettings previousSettings)
        {
            ProviderSettings = previousSettings;
        }

        public string Name
        {
            get
            {
                return ProviderSettings.Name;
            }
        }

        public string Summary
        {
            get
            {
                return ProviderSettings.Summary;
            }
        }

        public IProviderInfo Info
        {
            get
            {
                return ProviderSettings.Info;
            }
        }

        private IProviderSettings ProviderSettings { get; set; }
    }
}