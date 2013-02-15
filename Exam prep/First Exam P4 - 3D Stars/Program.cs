using System;

class Program
{
    private static string[, ,] ReadInput()
    {
        string cuboidSize = Console.ReadLine();
        char separator = ' ';
        string[] cuboidSizeArray = cuboidSize.Split(separator);
        int[] WHD = new int[3];
        for (int dimension = 0; dimension < 3; dimension++)
        {
            WHD[dimension] = int.Parse(cuboidSizeArray[dimension]);
        }
        int width = WHD[0];
        int height = WHD[1];
        int depth = WHD[2];
        string[, ,] cuboid = new string[width, height, depth];
        for (int currentHeight = 0; currentHeight < height; currentHeight++)
        {
            string currentPlane = Console.ReadLine();
            string[] planes = currentPlane.Split(' ');
            for (int currentDepth = 0; currentDepth < depth; currentDepth++)
            {
                char[] blocks = planes[currentDepth].ToCharArray();
                for (int currentWidth = 0; currentWidth < width; currentWidth++)
                {
                    cuboid[currentWidth, currentHeight, currentDepth] = blocks[currentWidth].ToString();
                }
            }
        }
        return cuboid;
    }

    private static void FindStars(string[, ,] cuboid)
    {
        string[] colors = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z"};
        int[] colorCount = new int[26];
        int counter = 0;
        for (int height = 1; height < cuboid.GetLength(1) - 1; height++)
        {
            for (int width = 1; width < cuboid.GetLength(0) - 1; width++)
            {
                for (int depth = 1; depth < cuboid.GetLength(2) - 1; depth++)
                {
                    if (cuboid[width, height, depth] == cuboid[width + 1, height, depth] && cuboid[width, height, depth] == cuboid[width - 1, height, depth] && cuboid[width, height, depth] == cuboid[width, height + 1, depth] && cuboid[width, height, depth] == cuboid[width, height - 1, depth] && cuboid[width, height, depth] == cuboid[width, height, depth + 1] && cuboid[width, height, depth] == cuboid[width, height, depth - 1])
                    {
                        counter++;
                        for (int color = 0; color < colors.Length; color++)
                        {
                            if (cuboid[width, height, depth] == colors[color])
                            {
                                colorCount[color]++;
                                continue;
                            }
                        }
                    }
                }
            }
        }
        Console.WriteLine(counter);
        for (int colorCountint = 0; colorCountint < colorCount.Length; colorCountint++)
        {
            if (colorCount[colorCountint] > 0)
            {
                Console.WriteLine(colors[colorCountint] + " " + colorCount[colorCountint]);
            }
            
        }
    }

    static void Main(string[] args)
    {
        string[, ,] cuboid = ReadInput();
        FindStars(cuboid);

        //for (int cheight = 0; cheight < cuboid.GetLength(1); cheight++)
        //{
        //    for (int cdepth = 0; cdepth < cuboid.GetLength(2); cdepth++)
        //    {
        //        for (int cwidth = 0; cwidth < cuboid.GetLength(0); cwidth++)
        //        {
        //            Console.Write(cuboid[cwidth,cheight,cdepth]);
        //        }
        //        Console.Write(" ");
        //    }
        //    Console.WriteLine();
        //}
    }
}