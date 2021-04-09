using System;
using System.IO;
public class ProcessFile
{
    public static void Main()
    {
        FileStream fs = null;
        try
        {
            //Abre o arquivo solicitado data.txt e converte os dados para uma stream binária
            fs = new FileStream(@"C:\Users\hugob\Desktop\data.txt", FileMode.Open);

            //A variável sr vai ser capaz de ler o conteúdo caractere que está em binário
            StreamReader sr = new StreamReader(fs);

            //Para percorrer todo o conteúdo do arquivo e armazenar na variável Line
            string line = sr.ReadLine();

            //Mostrar o conteúdo que está no arquivo
            Console.WriteLine(line);
        }
        catch (FileNotFoundException e)
        {
            //Caso não encontre o arquivo
            Console.WriteLine(e.Message);
        }
        finally
        {
            //Se o arquivo que foi aberto não for nulo(tem dados) feche o arquivo
            if (fs != null)
            {
                fs.Close();
            }
        }
    }
}