﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace overload
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public int size;
        public char[] DataLoad()
        {
            try
            {
                size = dataGridView1.RowCount;
                char[] matrixRead = new char[dataGridView1.RowCount - 1];

                for (int i = 0; i < dataGridView1.RowCount - 1; ++i)
                {
                    if (dataGridView1.Rows[i].Cells[0].Value != null)
                        matrixRead[i] = Convert.ToChar(dataGridView1.Rows[i].Cells[0].Value);
                }
                return matrixRead;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }

        }
        public char[] DataLoad2()
        {
            try
            {
                size = dataGridView2.RowCount;
                char[] matrixRead = new char[dataGridView2.RowCount - 1];

                for (int i = 0; i < dataGridView2.RowCount - 1; ++i)
                {
                    if (dataGridView1.Rows[i].Cells[0].Value != null)
                        matrixRead[i] = Convert.ToChar(dataGridView2.Rows[i].Cells[0].Value);
                }
                return matrixRead;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        class StringClass
        {
            public char[] array1;

            public string stringg;
            public StringClass(char[] array1 = null, string stringg = "")
            {
                this.array1 = array1;

                this.stringg = stringg;
            }


            public static StringClass operator +(StringClass obj1, StringClass obj2)
            {
                StringClass arr = new StringClass();

                for (int i = 0; i < obj1.array1.Length; ++i)
                {

                    arr.stringg += Convert.ToString(obj1.array1[i]);

                }
                for (int i = 0; i < obj2.array1.Length; ++i)
                {

                    arr.stringg += Convert.ToString(obj2.array1[i]);

                }

                return arr;
            }

            public static bool operator ==(StringClass obj1, StringClass obj2)
            {
                bool res = false;
                if (obj1.array1.Length == obj2.array1.Length)
                {
                    for (int i = 0; i < obj1.array1.Length; ++i)
                    {

                        if (obj1.array1[i] == obj2.array1[i])
                            res = true;
                        else
                        {
                            res = false;
                            break;
                        }
                    }
                }

                return res;

            }
            public static bool operator !=(StringClass obj1, StringClass obj2)
            {
                bool res = false;
                if (obj1.array1.Length != obj2.array1.Length)
                {
                    res = true;
                }
                if (obj1.array1.Length == obj2.array1.Length)
                {
                    for (int i = 0; i < obj1.array1.Length; ++i)
                    {

                        if (obj1.array1[i] != obj2.array1[i])
                            res = true;
                        else
                        {
                            res = false;
                            break;
                        }
                    }
                }

                return res;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                char[] exam = DataLoad();
                char[] exam2 = DataLoad2();

                if (exam[0] != null && exam2[0] != null)
                {
                    StringClass char1 = new StringClass(DataLoad());
                    StringClass char2 = new StringClass(DataLoad2());
                    StringClass char3 = char1 + char2;
                    label1.Text = Convert.ToString(char3.stringg);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
            finally { //MessageBox.Show("Вы забыли заполнить поля"); 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                char[] exam = DataLoad();
                char[] exam2 = DataLoad2();

                if (exam[0] != null && exam2[0] != null)
                {
                    StringClass char1 = new StringClass(DataLoad());
                    StringClass char2 = new StringClass(DataLoad2());
                    if (char1 == char2)
                        label2.Text = "Правда";
                    else
                        label2.Text = "Ложь";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally { //MessageBox.Show("Вы забыли заполнить поля");
                      }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                char[] exam = DataLoad();
                char[] exam2 = DataLoad2();

                if (exam[0] != null && exam2[0] != null)
                {
                    StringClass char1 = new StringClass(DataLoad());
                    StringClass char2 = new StringClass(DataLoad2());
                    if (char1 != char2)
                        label3.Text = "Правда";
                    else
                        label3.Text = "Ложь";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally { //MessageBox.Show("Вы забыли заполнить поля"); 
            }
        }
    }
}
