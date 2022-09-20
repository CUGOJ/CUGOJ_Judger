namespace CUGOJ.CUGOJ_Judger.Dao;

public static class DaoContext
{
    public class DaoContextProcessor
    {
        public virtual List<JudgeCase> GetJudgeCases(long ProblemID)
        {
            throw new NotImplementedException();
        }
    }

    private static DaoContextProcessor _processor = TraceFactory.CreateTracableObject<DaoContextProcessor>(false, false);

    public static List<JudgeCase> GetJudgeCases(long ProblemID)
    {
        return _processor.GetJudgeCases(ProblemID);
    }
}
