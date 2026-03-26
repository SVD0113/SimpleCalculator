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
            // 1. txtOutpput의 문자를 숫자로 변환해서 저장
            num1 = int.Parse(txtOutput.Text);

            // 2. Input에 현재 상황 표시
            txtInput.Text = txtOutput.Text + " + ";

            // 3. 다음 숫자 입력을 위해 txtOutput 초기화
            txtOutput.Clear();
        }

        private void btnResult_Click_1(object sender, EventArgs e)
        {
            // 1. 더하기 누른 후 두 번째로 입력한 숫자를(문자->숫자) num2에 저장
            num2 = int.Parse(txtOutput.Text);

            // 2. 더하기 계산
            result = num1 + num2;

            // 3. txtInput에 최종 수식
            txtInput.Text = txtInput.Text + txtOutput.Text + " = ";

            // 4. 계산된 숫자를 다시 문자로 변환해서 txtOutput에 표시
            txtOutput.Text = result.ToString();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            
        }

        private void btnNum0_Click(object sender, EventArgs e)
        {

        }

        
    }
}
