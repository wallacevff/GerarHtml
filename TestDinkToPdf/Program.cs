// See https://aka.ms/new-console-template for more information
using Services.DinkToPdf;

var pdf = new DinkToPdfService();

byte[] str = pdf.ConvertTest();
foreach(byte elem in str)
{
    Console.WriteLine(elem);
}
//Console.WriteLine();

