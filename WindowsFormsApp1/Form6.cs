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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void SetButtonText() //사용자 정의 메소드
        {
            button1.Text =
            "Location = " + Location + "\n" +
            "Left/Right/Width =" + Left + ", " + Right + ", " + Width + "\n" +
            "Top/Bottom/Height = " + Top + ", " + Bottom + ", " + Height;
        }
        private void Form6_Load(object sender, EventArgs e)
        {
            SetButtonText(); //사용자 정의 메소드 호출
        }
        private void Form6_Move(object sender, EventArgs e) //폼의 위치 이동 이벤트
        {
            SetButtonText();
        }
        private void Form6_Resize(object sender, EventArgs e) //폼의 크기변경 이벤트
        {
            SetButtonText();
        }
    }
}
