using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace MetinYazar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Stack Word = new Stack();
        Heap Heap = new Heap();
        string text = "";
        Stack Sentence = new Stack();
        
        public bool read, stack = false;

        private void btnMetinSeç_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Text Dosyası |*.txt";
            if (file.ShowDialog() == DialogResult.OK)
            {
                txtDosyaYolu.Text = file.FileName;
                var fileStream = file.OpenFile();

                using (StreamReader reader = new StreamReader(fileStream))
                {
                    text = reader.ReadToEnd();
                    read = true;
                }
            }
        }
        private void lblDosyaYolu_Click(object sender, EventArgs e)
        {

        }
        private void txtDosyaYolu_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnStackOku_Click(object sender, EventArgs e)
        {
            if (read)
            {
                int total_word_number = 0;
                int wordcount = 0;
                int sentenceno = 0;
                
                string[] word;
                
                string[] sentences = text.Split('.');
                for (int i = 0; i < sentences.Length; i++)
                {
                    sentenceno++;
                    word = sentences[i].Split(' ');
                    wordcount = word.Length;
                    
                    txtMetinBilgileri.Text += (i + 1) + "Cümledeki kelime sayısı: " + wordcount + "\r\n";
                    Sentence.Push(sentences[i]);
                    total_word_number += wordcount;
                }
                txtMetinBilgileri.Text += "Toplam Kelime Sayısı: " + total_word_number + "\r\n" +
                    "Toplam Cümle Sayısı : " + Sentence.count;
                
                read = true;
            }
            else
            {
                MessageBox.Show("Dosya Seçiniz");
            }
        }

        private void txtMetinBilgileri_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
    
    



}
