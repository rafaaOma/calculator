namespace simpleCalculator.Data
{ 
    public class CalculatorService//using state management to store calculation history
    {
        public List<string> History { get; set; } = new(); //list to store calculation history

        public void AddToHistory(string expression, string result)
        {
            History.Add($"{expression} = {result}");
        }
    }
}