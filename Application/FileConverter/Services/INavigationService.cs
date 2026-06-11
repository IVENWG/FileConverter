
namespace FileConverter.Services
{
    using System.Windows;

    public interface INavigationService
    {
        void RegisterPage<T>(string pageKey, bool cancelAutoExit, bool mainWindow) where T : Window;
        
        void Show(string pageKey);

        void Close(string pageKey, bool alreadyClosing);
    }
}