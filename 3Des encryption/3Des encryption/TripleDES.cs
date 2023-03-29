using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _3Des_encryption
{
    //Třída pro šifrování souboru
    public class TripleDES
    {
     
        private TripleDESCryptoServiceProvider des = new TripleDESCryptoServiceProvider();

        
        public TripleDES(string key)
        {

            des.Key = UTF8Encoding.UTF8.GetBytes(key); //Získává heslo
            des.Mode = CipherMode.ECB; //Používám cifru Electronic Code Book 
            des.Padding = PaddingMode.PKCS7; //syntaxe pro ukladani zasifrovaneho souboru
        }
        
        public void EncryptFile(string path)
        {
            byte[] Bytes = File.ReadAllBytes(path); //Přečte obsah souboru
            byte[] encBytes = des.CreateEncryptor().TransformFinalBlock(Bytes, 0, Bytes.Length); //zašifruje
            File.WriteAllBytes(path, encBytes); //Přepíše obsah souboru
        }
        public void DecryptFile(string path)
        {
            Byte[] Bytes = File.ReadAllBytes(path); //Přečte obsah souboru
            Byte[] decBytes = des.CreateDecryptor().TransformFinalBlock(Bytes, 0, Bytes.Length); //dešifruje
            File.WriteAllBytes(path, decBytes); //Přepíše obsah souboru

        }
    }
}
