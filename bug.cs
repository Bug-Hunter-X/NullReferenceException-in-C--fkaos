public class ExampleClass
{
    public int MyProperty { get; set; }

    public ExampleClass(int value)
    {
        MyProperty = value;
    }

    public void MyMethod()
    {
        //This line is the problematic line which throws a NullReferenceException if MyProperty is not initialized properly
        Console.WriteLine(MyProperty.ToString());
    }
}