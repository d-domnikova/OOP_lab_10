namespace Problem_1;

using System.Reflection;

class HarvestingFieldsTest
{
static void Main()
{
    Type type = typeof(HarvestingFields);
    FieldInfo[] fieldInfo = type.GetFields();
    while (true)
    {
        string input = Console.ReadLine();
        if (input.ToLower().Equals("harvest")) break;

        foreach (FieldInfo field in fieldInfo)
        {
            switch (input)
            {
                case "private":
                    Console.WriteLine($"private {field.FieldType.Name} {field.Name}");
                    break;
                case "protected":
                    Console.WriteLine($"protected {field.FieldType.Name} {field.Name}");
                    break;
                case "public":
                    Console.WriteLine($"public {field.FieldType.Name} {field.Name}");
                    break;
                case "all":
                    Console.WriteLine($"private {field.FieldType.Name} {field.Name}");
                    Console.WriteLine($"protected {field.FieldType.Name} {field.Name}");
                    Console.WriteLine($"public {field.FieldType.Name} {field.Name}");
                    break;
            }
        }
    }
}
}