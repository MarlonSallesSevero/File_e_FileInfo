using System;
using System.IO; // Realiza Operações com arquivos -> FileStream : É um objeto a sequencia de leitura ou escrita de um recurso de IO / Arquivo
                 //File : Operações Estaticas 
                 //FileInfo : Instanciação de objeto necessaria. Porem mais perfomartico. 
namespace File_e_FileInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Users\marlo\AppData\Local\Temp\arquivo.txt"; //Caminho do arquivo ja criado  
            string targetPath = @"C:\Users\marlo\AppData\Local\Temp\arquivo2.txt"; 
            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath); //Instanciãção de objeto associado ao sourcePath
                fileInfo.CopyTo(targetPath);
                string[] lines =  File.ReadAllLines(sourcePath);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }catch(IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                string a = Console.ReadLine();
            }
        }
    }
}
