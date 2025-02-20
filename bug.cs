public class ExampleClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        // Accessing a null object reference
        Console.WriteLine(MyProperty.ToString());
    }
}