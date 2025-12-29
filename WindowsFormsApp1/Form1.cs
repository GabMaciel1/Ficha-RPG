using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Reconfigure the ListView to show attribute names as column headers
            // and a single row labelled "Valor" with values laid out horizontally.
            listView1.Clear();
            listView1.View = View.Details;
            listView1.HideSelection = false;

            // First column is the row label ("Valor"), then one column per attribute
            listView1.Columns.Add("", 70, HorizontalAlignment.Left);
            string[] attributes = { "AGI", "FOR", "INT", "PRE", "VIG" };
            foreach (var attr in attributes)
            {
                listView1.Columns.Add(attr, 60, HorizontalAlignment.Center);
            }

            // Example values for each attribute (replace with your actual values)
            string[] values = { "2", "3", "1", "4", "2" };

            var row = new ListViewItem("Valor");
            foreach (var v in values) row.SubItems.Add(v);

            listView1.Items.Add(row);

            // Optional: auto-resize columns to content if desired
            for (int i = 0; i < listView1.Columns.Count; i++)
            {
                listView1.AutoResizeColumn(i, ColumnHeaderAutoResizeStyle.ColumnContent);
            }

            label14.Text = $"{ProgressVida1.Value} de {ProgressVida1.Maximum}";
            label15.Text = $"{ProgressSanidade2.Value} de {ProgressSanidade2.Maximum}";
            label16.Text = $"{ProgressEsforco3.Value} de {ProgressEsforco3.Maximum}";
        }


        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {



        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {


        }

        private void progressVida1_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }
    }
}
