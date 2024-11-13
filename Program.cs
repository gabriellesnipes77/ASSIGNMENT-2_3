namespace ASSIGNMENT_2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Enter the bill total
            Console.WriteLine("Enter the bill total: ");
            double billTotal = Convert.ToDouble(Console.ReadLine());

            //2. Enter tip %
            Console.WriteLine("Enter tip percentage: ");
            double tipPercentage = Convert.ToDouble(Console.ReadLine());

            //Calculate the tip amount
            double tipAmount = (tipPercentage / 100) * billTotal;

            //Calculate the grand total 
            double grandTotal = billTotal + tipAmount;

            //3. Display the grand total after adding tip
            Console.WriteLine($"\nTip Amount: ${tipAmount}");
            Console.WriteLine($"Grand Total (including tip): ${grandTotal}");

        }
    }
}
