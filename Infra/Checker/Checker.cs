namespace CUGOJ.CUGOJ_Judger.Infra.Checker;

public static class Checker
{

    public class CheckerProcessor
    {
        public virtual CheckResult Check(Stream output, Stream answer)
        {
            throw new NotImplementedException();
        }
    }
    private static CheckerProcessor _processor = TraceFactory.CreateTracableObject<CheckerProcessor>(false, false);

    public static CheckResult Check(Stream output, Stream answer)
    {
        return _processor.Check(output, answer);
    }
}