using CUGOJ.RPC.Gen.Base;

namespace CUGOJ.JudgerService;

public class JudgerServiceHandler : CUGOJ.RPC.Gen.Services.Judger.JudgerService.IAsync
{
    public Task<PingResponse> Ping(PingRequest req, CancellationToken cancellationToken = default)
    {
        PingResponse resp = new PingResponse(CommonTools.UnixMili());
        resp.BaseResp = RPCTools.SuccessBaseResp();
        return Task.FromResult(resp);
    }
}