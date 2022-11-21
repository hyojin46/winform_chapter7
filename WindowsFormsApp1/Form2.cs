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
    public partial class Form2 : Form
    {
        public Form2() //생성자
        {
            InitializeComponent(); //초기화
        }

        private void Form2_Load(object sender, EventArgs e) //폼이 로드될때 실행됨
        {
            MessageBox.Show("This form is loaded");
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e) //폼이 종료되고 실행됨
        {
            MessageBox.Show("This form is closed");
        }
    }
}
