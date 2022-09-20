using CUGOJ.CUGOJ_Judger.Model;
namespace CUGOJ.CUGOJ_Judger.Infra.MQ;
public class RabbitMQ : IMQProcessor
{
    public virtual void Consume(SubmissionConsumer consumer)
    {
        throw new NotImplementedException();
    }

    public virtual void Init()
    {
        if (Context.Debug)
        {
            return;
        }
        var rabbitMQAddress = Context.ServiceBaseInfo.RabbitMQAddress;
        if (CommonTools.IsEmptyString(rabbitMQAddress))
        {
            throw new Exception("RabbitMQAddress连接串为空,无法启动服务");
        }
        //TODO 初始化RabbitMQ连接
        // throw new NotImplementedException();
    }
}