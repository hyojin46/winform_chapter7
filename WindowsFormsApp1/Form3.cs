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
    public partial class Form3 : Form
    {
        public Form3() //생성자
        {
            InitializeComponent();
        }
        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you want to close?", "Prompt", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                e.Cancel = false; //폼의 창을 닫음
            else
                e.Cancel = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Close(); //창닫기
        }
    }
}
