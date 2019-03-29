using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace 御剑KEYGEN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = AesEncrypt(Encoding.Default.GetBytes(textBox1.Text), new byte[] { 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15 });
        }

        public static string AesEncrypt(byte[] SourceArray, byte[] KeyArray)
        {
            RijndaelManaged rijndaelManaged = new RijndaelManaged();
            RijndaelManaged rijndaelManaged2 = rijndaelManaged;
            rijndaelManaged2.Key = KeyArray;
            rijndaelManaged2.Mode = CipherMode.ECB;
            rijndaelManaged2.Padding = PaddingMode.Zeros;
            byte[] value = rijndaelManaged.CreateEncryptor().TransformFinalBlock(SourceArray, 0, SourceArray.Length);
            return BitConverter.ToString(value).Replace("-", "");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.ch1ng.com/");
        }
    }
}
