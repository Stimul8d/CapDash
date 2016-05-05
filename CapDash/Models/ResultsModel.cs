namespace CapDash.Models
{
    public class ResultsModel
    {
        public string BytesReceived { get; set; }
        public string BytesSent { get; set; }
        public string AppActions { get; set; }
        public string ErrorAppActions { get; set; }
        public string DatabaseActions { get; set; }
        public string ErrorDatabaseActions { get; set; }
        public string BrowserActions { get; set; }
        public string ErrorBrowserActions { get; set; }
        public string Checkpoints { get; set; }
        public string Controls { get; set; }
        public string Delays { get; set; }
        public string Ifs { get; set; }
        public string Nops { get; set; }
        public string Scripts { get; set; }
        public string ErrorScripts { get; set; }
        public string UIAutomationScripts { get; set; }
        public string ErrorUIAutomationScripts { get; set; }
        public string Switches { get; set; }
        public string Events { get; set; }
        public string ResultName { get; set; }
        public string CompositionNameAtExecutionTime { get; set; }
        public string Path { get; set; }
        public string Status { get; set; }
        public string Start { get; set; }
        public string End { get; set; }
        public string EffectiveStart { get; set; }
        public string TotalTime { get; set; }
        public int VirtualUsers { get; set; }
        public string Clips { get; set; }
        public string ErrorClips { get; set; }
        public string Transactions { get; set; }
        public string Pages { get; set; }
        public string Groups { get; set; }
        public string Chains { get; set; }
        public string Messages { get; set; }
        public string SentCount { get; set; }
        public string ErrorMessages { get; set; }
        public int TotalResponseTime { get; set; }
        public int MaxResponseTime { get; set; }
        public int MinResponseTime { get; set; }
        public string TotalTTFB { get; set; }
        public string TotalTTLB { get; set; }

    }
}