using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Text.RegularExpressions;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        // [과제 4 대비] 소수점 계산을 위해 int를 double로 모두 변경했습니다!
        double num1 = 0;
        double num2 = 0;
        double result = 0;
        string currentOperator = "";

        // 사용자가 현재 타이핑 중인 숫자를 임시로 기억할 변수
        string inputNumber = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string str = "Calculator v1.0";
            this.Text = str;
        }

        // 1. 숫자 버튼 클릭 (치는 대로 아래쪽 txtInput에 바로 표시)
        private void btnNum_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            inputNumber += btn.Text;
            txtInput.Text += btn.Text;
        }

        // 2. 연산자 버튼 클릭 (+, -, X, ÷)
        private void btnOperator_Click(object sender, EventArgs e)
        {
            if (inputNumber == "") return;

            // double.Parse로 변경!
            num1 = double.Parse(inputNumber);
            inputNumber = "";

            Button btn = (Button)sender;
            currentOperator = btn.Text;

            txtInput.Text += " " + currentOperator + " ";
        }

        // 3. 결과(=) 버튼 클릭
        private void btnResult_Click_1(object sender, EventArgs e)
        {
            if (inputNumber == "") return;

            // double.Parse로 변경!
            num2 = double.Parse(inputNumber);

            switch (currentOperator)
            {
                case "+": result = num1 + num2; break;
                case "-": result = num1 - num2; break;
                case "X": result = num1 * num2; break;
                case "÷": result = num1 / num2; break;
            }

            // 아래쪽 창(txtInput)에는 = 기호를 붙여 수식 완성
            txtInput.Text += " = ";

            // 위쪽 창(txtOutput)에는 오직 결과값만 표시!
            txtOutput.Text = result.ToString();

            inputNumber = "";
        }

        // 4. C 버튼 (전체 초기화)
        private void btnC_Click(object sender, EventArgs e)
        {
            txtInput.Clear();
            txtOutput.Clear();
            num1 = 0;
            num2 = 0;
            result = 0; 
            currentOperator = "";
            inputNumber = "";
        }

        // 5. CE 버튼 (현재 입력 중인 숫자만 삭제)
        private void btnCE_Click(object sender, EventArgs e)
        {
            if (inputNumber.Length > 0)
            {
                txtInput.Text = txtInput.Text.Substring(0, txtInput.Text.Length - inputNumber.Length);
                inputNumber = "";
            }
        }

        // 6. Del 버튼 (마지막 한 글자만 삭제)
        private void btnDelete_Click(object sender, EventArgs e)
        {
            // [주의] 이 코드가 작동하려면 속성 창(번개)에서 Click 이벤트가 연결되어 있어야 합니다!
            if (inputNumber.Length > 0)
            {
                txtInput.Text = txtInput.Text.Substring(0, txtInput.Text.Length - 1);
                inputNumber = inputNumber.Substring(0, inputNumber.Length - 1);
            }
        }
    }
}