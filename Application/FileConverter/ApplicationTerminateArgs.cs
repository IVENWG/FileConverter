
namespace FileConverter
{
    public class ApplicationTerminateArgs : System.EventArgs
    {
        public ApplicationTerminateArgs(float remainingTimeBeforeTermination)
        {
            this.RemainingTimeBeforeTermination = remainingTimeBeforeTermination;
        }

        public float RemainingTimeBeforeTermination
        {
            get;
            private set;
        }
    }
}