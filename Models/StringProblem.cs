namespace proiectMaghiar.Models
{
    public class StringProblem :IStringValidator
    {
        /// <summary>
        /// Check if inputString is eligible
        /// </summary>
        /// <param name="problem"></param>
        /// <returns></returns>
      public bool checkString(Problem problem)
        {
            if(problem.inputString!= null)
            return true;
            return false;
        }
    }
}
