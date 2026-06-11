
namespace FileConverter.Services
{
    public interface ISettingsService
    {
        Settings Settings
        {
            get;
        }

        bool PostInstallationInitialization();

        void SaveSettings();

        void RevertSettings();
    }
}
