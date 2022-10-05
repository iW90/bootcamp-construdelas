using DapperAPI.Contracts;

namespace DapperAPI.Services
{
    public class Validations : IValidations
    {
        public int CountChacacter(string word)
        {
            var count = word.Length;
            return count;
        }
    }
}
