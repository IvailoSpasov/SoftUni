﻿using System.IO.Compression;

namespace ZipAndExtract
{
    using System;
    using System.IO;
    public class ZipAndExtract
    {
        static void Main(string[] args)
        {
            string inputFile = @"..\..\..\copyMe.png";
            string zipArchiveFile = @"..\..\..\archive.zip";
            string extractedFile = @"..\..\..\extracted.png";

            ZipFileToArchive(inputFile, zipArchiveFile);
            
            var fileNameOnly = Path.GetFileName(inputFile);
            ExtractFileFromArchive(zipArchiveFile, fileNameOnly, extractedFile);
        }

        public static void ZipFileToArchive(string inputFilePath, string zipArchiveFilePath)
        {
            ZipArchive zipFile = ZipFile.Open(zipArchiveFilePath, ZipArchiveMode.Create);
            zipFile.CreateEntryFromFile(inputFilePath, "copyMy.png");
        }

        public static void ExtractFileFromArchive(string zipArchiveFilePath, string fileName, string outputFilePath)
        {
            using ZipArchive zip = ZipFile.OpenRead(zipArchiveFilePath);
            zip.ExtractToDirectory(outputFilePath);

        }
    }
}
