using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Text.RegularExpressions;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        int num1 = 0; // 첫 번째 입력 숫자
        int num2 = 0; // 두 번째 입력 숫자
        int result = 0; // 계산 결과
        string currentOperator = ""; // 현재 눌린 연산자

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Form 창 이름 설정
            string str = "Calculator v1.0";
            this.Text = str;
        }

        private void btnNum_Click(object sender, EventArgs e)
        {
            // 1. 눌린 버튼 확인
            Button btn = (Button)sender;

            // 2. 눌린 버튼의 숫자를 txt박스에 추가
            txtOutput.Text += btn.Text;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            // 빈 공간 (사용 안 함)
        }

        private void btnResult_Click_1(object sender, EventArgs e)
        {
            // 빈칸 방어막
            if (txtOutput.Text == "") return;

            // 두 번째 숫자를 num2에 저장
            num2 = int.Parse(txtOutput.Text);

            // 저장된 연산자(currentOperator)가 무엇인지에 따라 다르게 계산 (switch 문)
            switch (currentOperator)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "X": // 곱하기 
                    result = num1 * num2;
                    break;
                case "÷": // 나누기 
                    result = num1 / num2;
                    break;
            }

            // 최종 수식과 결과 표시
            txtInput.Text = txtInput.Text + txtOutput.Text + " = ";
            txtOutput.Text = result.ToString();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            // 빈 공간 (사용 안 함)
        }

        private void btnNum0_Click(object sender, EventArgs e)
        {
            // 빈 공간 (사용 안 함)
        }

        private void btnOperator_Click(object sender, EventArgs e)
        {
            // 빈칸 방어
            if (txtOutput.Text == "") return;

            // 1. 어떤 기호 버튼이 눌렸는지 확인합니다 (+, -, *, / 중 하나)
            Button btn = (Button)sender;

            // 눌린 기호를 currentOperator 변수에 저장
            currentOperator = btn.Text;

            // 2. 입력된 문자를 숫자로 변환해서 num1에 저장
            num1 = int.Parse(txtOutput.Text);

            // 3. 위쪽 창에 진행 상황 표시 
            txtInput.Text = txtOutput.Text + " " + currentOperator + " ";

            // 4. 다음 숫자 입력을 위해 아래쪽 창 비우기
            txtOutput.Clear();
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            // txt Input/Output 모두 비우기
            txtInput.Clear();
            txtOutput.Clear();

            // 기억해둔 숫자와 연산자도 모두 초기화
            num1 = 0;
            num2 = 0;
            result = 0;
            currentOperator = "";
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            // 현재 입력 중인 txtOutput만 비우기
            txtOutput.Clear(); 
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // 텍스트박스에 글자가 하나라도 있는지 확인 (길이가 0보다 클 때만 작동)
            if (txtOutput.Text.Length > 0)
            {
                // 맨 뒤의 한 글자를 제외하고 잘라내서 다시 저장
                // Substring(시작점, 몇개) : 0번째(처음)부터 (전체길이 - 1)개까지만 가져옵니다.
                txtOutput.Text = txtOutput.Text.Substring(0, txtOutput.Text.Length - 1);
            }
        }
    }
}