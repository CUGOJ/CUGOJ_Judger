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

    public virtual async void consumer(JudgeSubmission submission)
    {
        //TODO 核心逻辑
        // 更新提交到 compiling状态
        // var submissionStruct = submission.ToSubmissionStruct();
        // submissionStruct.Status = ((int)Constants.JudgeResult.Compiling);
        // using var client = await RPCClientManager.GetBaseClient();
        // if (client == null)
        // {
        //     throw new Exception("无法连接到Base服务");
        // }
        // else
        // {
        //     var req = new CUGOJ.RPC.Gen.Services.Base.SaveSubmissionInfoRequest(submissionStruct);
        //     req.Base = RPCTools.NewRootBase();
        //     var resp = await client.SaveSubmissionInfo(req);
        //     if (resp.BaseResp.Status != 0)
        //     {
        //         throw new Exception("更新提交状态失败");
        //     }
        // }
        // RPCClientManager.
        // compile
        // 更新提交到 running状态
        // 拿到所有的评测数据
        // for 依次评测 (启动容器，等待容器执行结束，获取容器输出，判断结果)
        // 评测结束，将结果发送给Base
        throw new NotImplementedException();
    }
}