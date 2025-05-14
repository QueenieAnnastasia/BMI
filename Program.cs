public class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Tính chỉ số BMI");
        Console.WriteLine("Nhập chiều cao");
        double height = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Nhập cân nặng");
        double weight = Convert.ToDouble(Console.ReadLine());
        double bmi = weight/(Math.Pow(height,2));
        //bmi = Math.Round(bmi, 1);
        Console.WriteLine($"Chỉ số của bạn là {bmi}");
        if (bmi < 18)
        {
            Console.WriteLine("Bạn thuộc loại gầy");
        }
        else if (bmi >= 18 && bmi < 25)
        {
            Console.WriteLine("Bạn thuộc loại trung bình");
        }
        else if (bmi >=25 && bmi < 30)
        {
            Console.WriteLine("Bạn thuộc loại thừa cân");
        }
        else
        {
            Console.WriteLine("Bạn thuộc loại béo phì");
        }
    }
}