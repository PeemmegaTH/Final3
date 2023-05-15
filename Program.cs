using System;
class Program{
   
    static void Main(string[] args){
        string location = "";
        string location_CK = "";
        string location_Output = "";

        Console.WriteLine("Input location , Convolution Kernel, Output Location:");
        location = (Console.ReadLine());
        location_CK = (Console.ReadLine());
        location_Output = (Console.ReadLine());
        
        double[,] Getlocation = ReadImageDataFromFile(location);

        static double[,] ReadImageDataFromFile(string imageDataFilePath)
        {
            string[] lines = System.IO.File.ReadAllLines(imageDataFilePath);
            int imageHeight = lines.Length;
            int imageWidth = lines[0].Split(',').Length;
            double[,] imageDataArray = new double[imageHeight, imageWidth];
        
            for(int i=0; i<imageHeight; i++)
            {
                string[] items = lines[i].Split(',');
                for(int j=0; j<imageWidth; j++)
                {
                    imageDataArray[i, j] = double.Parse(items[j]);
                }
            }
            return imageDataArray;
        }

        static double[,] WriteImageDataToFile(string imageDataFilePath)
        {
            string[] lines = System.IO.File.ReadAllLines(imageDataFilePath);
            int imageHeight = lines.Length;
            int imageWidth = lines[0].Split(',').Length;
            double[,] imageDataArray = new double[imageHeight, imageWidth];
        
            for(int i=0; i<imageHeight; i++)
            {
                string[] items = lines[i].Split(',');
                for(int j=0; j<imageWidth; j++)
                {
                    imageDataArray[i, j] = double.Parse(items[j]);
                }
            }
            return imageDataArray;
        }



    }
}