using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DictionaryHash
{
    public partial class MainForm : Form
    {
        public const int INCREASING = 1;
        public const int REDUCING = 0;
        private MyDictionary mydictionary = new MyDictionary();

        public MainForm()
        {
            InitializeComponent();
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            if (mydictionary.DataIsCorrect(key_tb.Text, value_tb.Text))
            {
                mydictionary.Add(key_tb.Text, value_tb.Text);
                table_dataGridView.Rows.Add(key_tb.Text, value_tb.Text);
            }
            else MessageBox.Show("Mistake!");

            key_tb.Clear();
            value_tb.Clear();
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            if (key_tb.Text == "") MessageBox.Show("Key  must be entered!");
            else
            {
                mydictionary.Delete(key_tb.Text);
                ShowAllTable();
            }

            key_tb.Clear();
            value_tb.Clear();
        }

        private void choose_btn_Click(object sender, EventArgs e)
        {
            if (!key_tb.Text.Equals(""))
            {
                string value = mydictionary.Choose(key_tb.Text);
                table_dataGridView.Rows.Clear();
                table_dataGridView.Rows.Add(key_tb.Text, value);
            }
            else MessageBox.Show("Mistake!");

            key_tb.Clear();
            value_tb.Clear();
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

        private void show_all_btn_Click(object sender, EventArgs e)
        {
            ShowAllTable();
        }
    }
}
