using CUGOJ.CUGOJ_Judger.Model;
namespace CUGOJ.CUGOJ_Judger.Infra.MQ;

public static class MQ
{
    private static IMQProcessor? _mqProcessor;
    public static void Init()
    {
        _mqProcessor = TraceFactory.CreateTracableObject<RabbitMQ>(false, false);
        _mqProcessor.Init();
    }
    public static void Consume(SubmissionConsumer consumer)
    {
        if (_mqProcessor == null)
        {
            throw new Exception("MQProcessor is not initialized");
        }
        _mqProcessor.Consume(consumer);
    }
}

public delegate void SubmissionConsumer(JudgeSubmission submission);

public interface IMQProcessor
{
    void Init();
    void Consume(SubmissionConsumer consumer);
}