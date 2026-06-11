namespace FileConverter.ConversionJobs
{
    /// <summary>
    /// This enum describe the special conversion state that need to be multi-threads prerequisites.
    /// </summary>
    [System.Flags]
    public enum ConversionFlags
    {
        None = 0x00,

        CdDriveExtraction = 0x01,
    }
}