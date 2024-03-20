using System;
using System.Text;
using System.Security.Cryptography;

class Program
{
    static void Main()
    {
        // Solicita ao usuário que insira uma string para o hashing
        Console.WriteLine("Digite uma string para aplicar o hashing SHA256:");
        string inputData = Console.ReadLine();

        // Verifica se a entrada não é nula
        if (!string.IsNullOrEmpty(inputData))
        {
            // Cria uma instância do SHA256
            using (SHA256 sha256 = SHA256.Create())
            {
                // Converte a string de entrada em um array de bytes e computa o hash
                byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(inputData));

                // Utiliza StringBuilder para acumular os bytes do hash em formato hexadecimal
                StringBuilder hash = new StringBuilder();
                foreach (byte b in hashBytes)
                {
                    // Converte cada byte em hexadecimal e o adiciona ao StringBuilder
                    hash.Append(b.ToString("x2"));
                }

                // Exibe o hash SHA256 da entrada
                Console.WriteLine($"Hash SHA256 gerado: {hash}");
            }
        }
        else
        {
            // Caso a entrada seja nula ou vazia, exibe uma mensagem
            Console.WriteLine("Entrada inválida.");
        }
    }
}
