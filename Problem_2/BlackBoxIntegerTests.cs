namespace Problem_2
{
    using System;
    using System.Reflection;

    public class BlackBoxIntegerTests
    {
        public static void Main()
        {
            Type type = typeof(BlackBoxInteger);
            MethodInfo[] methodInfo = type.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance);
            var instance = (BlackBoxInteger)Activator.CreateInstance(type, true); //викликає конструктор, відповідний до вказаних параметрів (тут конструктор без параметрів)

            while (true)
            {
                string[] input = Console.ReadLine().Split('_');

                if (input[0].ToLower().Equals("end")) break;
                int parameter = int.Parse(input[1]);

                foreach (MethodInfo method in methodInfo)
                {
                    if (method.Name.ToLower() == input[0].ToLower())
                    {
                        method.Invoke(instance, new object[] { parameter });
                        var result = type.GetField("innerValue", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(instance);
                        Console.WriteLine(result);
                    }
                }
            }
        }
    }
}
