namespace Problem_6
{
    class Workspave
    {
        static void Main()
        {
            List<TrafficsLight> enums = new List<TrafficsLight>();
            var input = Console.ReadLine().Split(' ');

            foreach (var item in input)
            {
                TrafficsLight trafficsLight;
                Enum.TryParse(item, out trafficsLight);
                enums.Add(trafficsLight);
            }

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < enums.Count; j++)
                {
                    enums[j] = switcher(enums[j]);
                }
                Console.WriteLine(string.Join(' ', enums));
            }

            static TrafficsLight switcher(TrafficsLight light)
            {
                int lenght = Enum.GetNames(typeof(TrafficsLight)).Length;
                int currentIndex = (int)light;
                TrafficsLight trafficsLight = (TrafficsLight)((currentIndex + 1) % lenght);
                return trafficsLight;
            }

        }
    }
}