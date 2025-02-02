public class ExampleClass
{
    public int? MyProperty { get; set; } // Changed to nullable int

    public ExampleClass(int? value)
    {
        MyProperty = value;
    }

    public void MyMethod()
    {
        // Check for null before accessing MyProperty
        Console.WriteLine(MyProperty?.ToString() ?? "MyProperty is null");
    }
}