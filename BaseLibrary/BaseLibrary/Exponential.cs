namespace BaseLibrary
{
    public class Exponential : IGenerator
    {
        IEnumerable<int> IGenerator.Generate(int maxIterations)
        {
            int ret = 1;
            for (int i = 0; i < maxIterations; i++)
            {
                yield return ret;
                ret *= 2;
            }
        }
    }
}
