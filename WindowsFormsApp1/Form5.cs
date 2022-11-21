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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Invalidate(); // paint이벤트 발생
        }
       
        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics; //Graphics객체 생성
            Random r = new Random(); //Random객체 생성
            Color c = Color.FromArgb(r.Next(256), r.Next(256), r.Next(256)); //0 ~255의 난수를 생성함
            g.FillRectangle(new SolidBrush(c), e.ClipRectangle); //사각형 내부 채움 메소드
        }
    }
}
