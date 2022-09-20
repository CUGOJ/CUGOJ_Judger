try
{
    var parsedArgs = CUGOJ.CUGOJ_Tools.Tools.ParamsTool.ParseArgs(args, CUGOJ.RPC.Gen.Base.ServiceTypeEnum.Base);
    string connectionString = "";
    if (parsedArgs.ContainsKey("connectionString"))
        connectionString = parsedArgs["connectionString"];
    if (parsedArgs.ContainsKey("debug"))
    {
        Context.Debug = true;
        Context.ServiceBaseInfo = new()
        {
            LogAddress = string.Empty,
            TraceAddress = string.Empty
        };
    }
    if (!CUGOJ.CUGOJ_Tools.Tools.DBTools.InitSqlite<CUGOJ.CUGOJ_Judger.Dao.CaseContext>())
    {
        throw new Exception("初始化数据库失败");
    }

    await CUGOJ.CUGOJ_Tools.RPC.RPCService.StartJudgerService<CUGOJ.JudgerService.JudgerServiceHandler>(connectionString, () =>
    {
        CUGOJ.CUGOJ_Judger.Infra.FileManager.FileManager.Init();
        CUGOJ.CUGOJ_Judger.Infra.MQ.MQ.Init();
        CUGOJ.CUGOJ_Judger.Services.JudgerManager.Init();
    });
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}