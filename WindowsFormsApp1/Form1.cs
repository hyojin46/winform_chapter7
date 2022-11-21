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
            startDateTime = DateTime.Now; // 객체 생성시 필드를 현재시간으로 설정
        }
        DateTime startDateTime; //DateTime 클래스 객체 생성
        public DateTime GetStartDateTime()
        {
            return startDateTime;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(GetStartDateTime().ToString()); // DataTime자료형을 문자열형으로 변환
        }
    }
}
