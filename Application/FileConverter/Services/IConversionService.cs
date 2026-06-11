
namespace FileConverter.Services
{
    using System.Collections.ObjectModel;

    using FileConverter.ConversionJobs;

    public interface IConversionService
    {
        event System.EventHandler<ConversionJobsTerminatedEventArgs> ConversionJobsTerminated;

        ReadOnlyCollection<ConversionJob> ConversionJobs
        {
            get;
        }

        void ConvertFilesAsync();

        void RegisterConversionJob(ConversionJob conversionJob);
    }
}
