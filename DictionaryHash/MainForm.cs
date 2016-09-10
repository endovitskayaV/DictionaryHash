using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace DictionaryHash
{
    public partial class MainForm : Form
    {
        public const int INCREASING = 1;
        public const int REDUCING = 0;

        private MyDictionary mydictionary;


        public MainForm()
        {
            InitializeComponent();
            mydictionary = new MyDictionary();
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            if (mydictionary.Add(key_tb.Text, value_tb.Text)) table_dataGridView.Rows.Add(key_tb.Text, value_tb.Text);
            else MessageBox.Show("Mistake!");

            key_tb.Clear();
            value_tb.Clear();
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            mydictionary.Delete(key_tb.Text);
            ShowAllTable();
            
            key_tb.Clear();
            value_tb.Clear();
        }

        private void choose_btn_Click(object sender, EventArgs e)
        {
            string value = mydictionary.Choose(key_tb.Text);
            if (value != null)
            {
                table_dataGridView.Rows.Clear();
                table_dataGridView.Rows.Add(key_tb.Text, value);
            }
            else MessageBox.Show("Mistake!");

            key_tb.Clear();
            value_tb.Clear();

        }

        private void show_all_btn_Click(object sender, EventArgs e)
        {
            ShowAllTable();
        }

        private void ShowAllTable()
        {
            table_dataGridView.Rows.Clear();
            for (int i = 0; i < mydictionary.Capacity; i++)
            {
                if ( mydictionary.Table(i)!= null)
                table_dataGridView.Rows.Add(mydictionary.Table(i).Key, mydictionary.Table(i).Value);
            }

        }

        private void test_btn_Click(object sender, EventArgs e)
        {
            if (key_tb.Text != "" && value_tb.Text != "")
            {
                Dictionary<string, string> dictionary = new Dictionary<string, string>();
                Stopwatch watch = new Stopwatch();
                watch.Start();

                dictionary.Add(key_tb.Text, value_tb.Text); //watch.Stop();  long foo= watch.ElapsedTicks; watch = new Stopwatch(); watch.Start();
                string value = dictionary[key_tb.Text];// watch.Stop(); long foo1 = watch.ElapsedTicks; watch = new Stopwatch(); watch.Start();
                dictionary.Remove(key_tb.Text); //watch.Stop(); long foo2 = watch.ElapsedTicks; 

                watch.Stop();
                long timeBuildinDict = watch.ElapsedTicks;



                watch = new Stopwatch();
                watch.Start();

                mydictionary.Add(key_tb.Text, value_tb.Text); //watch.Stop(); long foo3 = watch.ElapsedTicks; watch = new Stopwatch(); watch.Start();
                mydictionary.Choose(key_tb.Text);// watch.Stop(); long foo4 = watch.ElapsedTicks; watch = new Stopwatch(); watch.Start();
                mydictionary.Delete(key_tb.Text); //watch.Stop(); long foo5 = watch.ElapsedTicks;

                watch.Stop();
                long timeMyDict = watch.ElapsedTicks;

                MessageBox.Show("MyDictionary takes " + timeMyDict + " ticks" + Environment.NewLine + "Buid-in dictionary takes " + timeBuildinDict + " ticks");
                // MessageBox.Show(foo + " " + foo1 + " " + foo2 + " " + foo3+" " + foo4+" " + foo5);
            }
            else MessageBox.Show("Key and value must be entered!");
        }
    }
}
