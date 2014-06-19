namespace MVPDemo.Models
{
    public class Capitalizer : ICapitalizer
    {
        public string Capitalize(string input)
        {
            return input.ToUpper();
        }
    }
}
