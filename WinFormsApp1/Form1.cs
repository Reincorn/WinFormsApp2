using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    
    public partial class Form1 : Form
    {
        private void Key(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{Tab}");
            }
        }
        public Form1()
        {
            InitializeComponent();
            tb2.KeyUp += Key;
            tb2.Text = Properties.Settings.Default.str.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = this.tb2.Text;
            str = str.Trim();
            for (int i = 0; i < 100; i++)
            {
                str = str.Replace("  ", " ");
            }
            Properties.Settings.Default.str = str;
            Properties.Settings.Default.Save();
            this.l1.Text = Logic.Maxmin(str);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.tb2.Clear();
        }
    }
    public class Logic
    {
        public static string Maxmin(string str)
        {
            string[] words = str.Split(" ");
            var aaa = words.Length;
           
            int[] mas = new int[aaa];
            string outmessege = "";
            int num = 0;
            int nn = 0;
                for (int i = 0; i < aaa; i++)
                {
                bool isNum = int.TryParse(words[i], out num);
                if (isNum == true) nn++;
                else nn--;
                }

            if (nn == aaa) //кол-во целых чисел=длине массива
            {
                for (int i = 0; i < (aaa); i++)
                {
                    mas[i] = Convert.ToInt32(words[i]);
                }
                if (mas.Length < 4)
                {
                    MessageBox.Show("Ошибка! Введите как минимум 4 значения!");
                }
                else
                {
                    int temp = 0;
                    for (int j = 0; j <= 100; j++)
                    {
                        for (int i = 0; i < aaa - 1; i++) //сортировка массива методом пузырьком 
                        {
                            if (mas[i] > mas[i + 1])
                            {
                                temp = mas[i];
                                mas[i] = mas[i + 1];
                                mas[i + 1] = temp;
                            }
                        }
                    }
                    if (outmessege == "")
                    {
                        outmessege = $"Минимальный элемент: {mas[0]}\nВторой минимальный элемент: { mas[1]}\nМаксимальный элемент: {mas[aaa - 2]}\nВторой максимальный элемент: {mas[aaa - 1]}";
                    }
                }
            }
            else
            {
                MessageBox.Show("Ошибка! Вводите целые числа!");
            }
            return outmessege;
        }
    }
}
