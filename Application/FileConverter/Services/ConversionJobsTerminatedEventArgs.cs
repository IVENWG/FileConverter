
namespace FileConverter.Services
{
    using System;

    public class ConversionJobsTerminatedEventArgs : EventArgs
    {
        public ConversionJobsTerminatedEventArgs(bool allConversionsSucceed)
        {
            this.AllConversionsSucceed = allConversionsSucceed;
        }

        public bool AllConversionsSucceed
        {
            get;
            private set;
        }
    }
}
