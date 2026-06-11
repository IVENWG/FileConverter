
namespace FileConverter.Services
{
    using System.Threading.Tasks;

    public interface IUpgradeService
    {
        event System.EventHandler<UpgradeVersionDescription> NewVersionAvailable;

        UpgradeVersionDescription UpgradeVersionDescription
        {
            get;
        }

        Task<UpgradeVersionDescription> CheckForUpgrade();

        Task<string> DownloadChangeLog();

        Task StartUpgrade();

        void CancelUpgrade();
    }
}
