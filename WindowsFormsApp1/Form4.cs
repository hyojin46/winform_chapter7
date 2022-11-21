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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        private void SetButtonText() //사용자 정의 메소드
        {
            button1.Text = "Form.FormBorderStyle = " + FormBorderStyle.ToString() + "\n" + //폼의 테두리 스타일
                            "Form.Size = " + Size.ToString() + "\n" + //윈도우 폼의 전체크기
                            "Form.ClientSize = " + ClientSize.ToString(); //제목 표시줄을 제외한 순수한 클라이언트 영역에 대한 크기
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            SetButtonText(); // 사용자 정의 메소드 호출
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (FormBorderStyle == FormBorderStyle.SizableToolWindow) // 폼의 스타일이 SizableToolWindow인경우
                FormBorderStyle = FormBorderStyle.None; // 폼 스타일 None으로 변경
            else
                FormBorderStyle++; //열거형이기때문에 증감 사용가능 (보드 스타일 변경 - 사이즈 속성만 변경)
            SetButtonText(); //사용자 정의 메소드 호출
        }
    }
}
