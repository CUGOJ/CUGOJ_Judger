using CUGOJ.CUGOJ_Judger.Model;
namespace CUGOJ.CUGOJ_Judger.Infra.MQ;
public class RabbitMQ : IMQProcessor
{
    public virtual void Consume(SubmissionConsumer consumer)
    {
        // TODO
        // 监听一个消息队列
        // 拿到提交id
        // 去Base请求id对应的提交信息
        // 转换成JudgeSubmission
        // 调用consumer
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
        // TODO 初始化RabbitMQ连接
        // throw new NotImplementedException();
    }
}