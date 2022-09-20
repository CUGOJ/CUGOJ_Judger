namespace CUGOJ.CUGOJ_Judger.Services;

public static class JudgerManager
{
    public static int JudgerCount { get; set; } = 0;
    public static SemaphoreSlim judgerSemaphore = new SemaphoreSlim(0, 1);
    public static bool _stopFlag = false;
    private static IJudgerProcessor _judgerProcessor = TraceFactory.CreateTracableObject<IJudgerProcessor>(false, false);
    public static void Init()
    {
        JudgerCount = Math.Min(1, Environment.ProcessorCount);
        judgerSemaphore = new SemaphoreSlim(0, JudgerCount);
        new Thread(ManageCycle).Start();
    }

    public static void ManageCycle(object? args)
    {
        while (true)
        {
            if (_stopFlag) break;
            judgerSemaphore.Wait();
            new Thread((obj) =>
            {
                try
                {
                    _judgerProcessor.StartJudge();
                }
                catch (Exception e)
                {
                    Logger.Error("评测过程发生Exception,e={0}", e);
                }
                finally
                {
                    judgerSemaphore.Release();
                }
            }).Start();
        }
    }

    public static void StopJudger()
    {
        _stopFlag = true;
        judgerSemaphore.Release();
    }
}

public interface IJudgerProcessor
{
    void Init();
    void StartJudge();
}