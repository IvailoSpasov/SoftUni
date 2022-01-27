using System.IO;

namespace CopyBinaryFile
{
    public class CopyBinaryFile
    {
        static void Main(string[] args)
        {
            string inputPath = @"..\..\..\copyMe.png";
            string outputPath = @"..\..\..\copyMe-copy.png";

            CopyFile(inputPath, outputPath);
        }

        public static void CopyFile(string inputFilePath, string outputFilePath)
        {
            using FileStream fileReader = new FileStream(inputFilePath, FileMode.Open);
            using FileStream fileWriter = new FileStream(outputFilePath, FileMode.Create);

            byte[] bytesArray = new byte[512];

            while (true)
            {
                int currBytes = fileReader.Read(bytesArray, 0, bytesArray.Length);
                if (currBytes == 0)
                {
                    break;
                }
                fileWriter.Write(bytesArray,0,bytesArray.Length);
            }
        }
    }
}
