namespace CUGOJ.CUGOJ_Judger.Infra.FileManager;

public static class FileManager
{
    private static IFileManagerProcessor? _fileManagerProcessor;
    public static void Init()
    {
        _fileManagerProcessor = TraceFactory.CreateTracableObject<FileManagerProcessor>(false, false);
        _fileManagerProcessor.Init();
    }

    public static void LoadFile(long ProblemID)
    {
        if (_fileManagerProcessor == null)
        {
            throw new Exception("FileManagerProcessor is not initialized");
        }
        _fileManagerProcessor.LoadFile(ProblemID);
    }
}

public interface IFileManagerProcessor
{
    void Init();
    void LoadFile(long ProblemID);
}