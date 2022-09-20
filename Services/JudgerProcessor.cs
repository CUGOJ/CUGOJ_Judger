using CUGOJ.CUGOJ_Judger.Infra.MQ;
using CUGOJ.CUGOJ_Judger.Model;

namespace CUGOJ.CUGOJ_Judger.Services;

public class JudgerProcessor : IJudgerProcessor
{
    public void Init()
    {

    }

    public virtual void StartJudge()
    {
        MQ.Consume(consumer);
    }

    public virtual void consumer(JudgeSubmission submission)
    {
        throw new NotImplementedException();
    }
}