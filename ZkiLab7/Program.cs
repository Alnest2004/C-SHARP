using System;
using System.Security.Cryptography;
using System.Text;

namespace ZkiLab7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст:");
            string source = Console.ReadLine();
            using (SHA1 sha1Hash = SHA1.Create())
            {
                //From String to byte array
                byte[] sourceBytes = Encoding.UTF8.GetBytes(source);
                byte[] hashBytes = sha1Hash.ComputeHash(sourceBytes);
                string hash = BitConverter.ToString(hashBytes).Replace("-", String.Empty);

                Console.WriteLine("The SHA1 hash of " + source + " is: " + hash);
            }
            Console.WriteLine("Enter the text to hash:");
            string source1 = Console.ReadLine();
            using (MD5 sha1Hash = MD5.Create())
            {
                //From String to byte array
                byte[] sourceBytes = Encoding.UTF8.GetBytes(source);
                byte[] hashBytes = sha1Hash.ComputeHash(sourceBytes);
                string hash = BitConverter.ToString(hashBytes).Replace("-", String.Empty);

                Console.WriteLine("The MD5 hash of " + source1 + " is: " + hash);
            }
            Console.WriteLine("Enter the text to hash:");
            string source2 = Console.ReadLine();
            using (SHA256 sha1Hash = SHA256.Create())
            {
                //From String to byte array
                byte[] sourceBytes = Encoding.UTF8.GetBytes(source);
                byte[] hashBytes = sha1Hash.ComputeHash(sourceBytes);
                string hash = BitConverter.ToString(hashBytes).Replace("-", String.Empty);

                Console.WriteLine("The SHA256 hash of " + source2 + " is: " + hash);
            }
        }
    }
}