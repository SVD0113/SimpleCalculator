using System;
using System.Data;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        bool isCalculated = false; // 계산 완료 여부

        public Form1()
        {
            InitializeComponent();
        }

        // 1. 숫자 버튼 클릭 (0~9) - txtInput과 txtOutput에 출력
        private void btnNum_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (isCalculated)
            {
                txtInput.Clear();
                txtOutput.Clear();
                isCalculated = false;
            }

            txtOutput.Text += btn.Text;
            txtInput.Text += btn.Text;
        }

        // 2. 연산자 버튼 클릭 (+, -, X, ÷) - txtOutput 초기화
        private void btnOperator_Click(object sender, EventArgs e)
        {
            if (txtInput.Text == "" && txtOutput.Text == "") return;

            Button btn = (Button)sender;

            // 아래쪽 창은 다음 입력을 위해 비움
            txtOutput.Clear();

            if (isCalculated)
            {
                // 이전 결과값이 있는 경우 결과값 뒤에 연산자 붙여서 시작
                string lastResult = txtOutput.Text;
                txtInput.Text = lastResult + " " + btn.Text + " ";
                isCalculated = false;
            }
            else
            {
                txtInput.Text += " " + btn.Text + " ";
            }
        }

        // 3. 결과(=) 버튼 클릭 - 디자인 파일에 적힌 btnResult_Click_1 로 맞춤
        private void btnResult_Click_1(object sender, EventArgs e)
        {
            if (txtInput.Text == "" || isCalculated) return;

            try
            {
                // X와 ÷를 연산 가능한 기호로 변환
                string expression = txtInput.Text.Replace("X", "*").Replace("÷", "/");
                var result = new DataTable().Compute(expression, null);

                // 상단: 전체 수식 = 결과
                txtInput.Text += " = " + result.ToString();
                // 하단: 최종 결과만
                txtOutput.Text = result.ToString();

                isCalculated = true;
            }
            catch (Exception)
            {
                MessageBox.Show("수식이 잘못되었습니다.");
                btnC_Click(sender, e);
            }
        }

        // 4. C(Clear) 버튼 클릭
        private void btnC_Click(object sender, EventArgs e)
        {
            txtInput.Clear();
            txtOutput.Clear();
            isCalculated = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtOutput.Text.Length > 0)
            {
                // txtOutput에서 마지막 한 글자 제거
                txtOutput.Text = txtOutput.Text.Substring(0, txtOutput.Text.Length - 1);

                // txtInput에서도 마지막 한 글자 제거 (수식 동기화)
                if (txtInput.Text.Length > 0)
                {
                    txtInput.Text = txtInput.Text.Substring(0, txtInput.Text.Length - 1);
                }
            }
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            // 아래쪽 창(현재 입력 중인 숫자)만 비우기
            int lengthToRemove = txtOutput.Text.Length;
            txtOutput.Clear();

            // 위쪽 창(전체 수식)에서도 방금 입력한 숫자만큼만 뒤에서 지우기
            if (txtInput.Text.Length >= lengthToRemove)
            {
                txtInput.Text = txtInput.Text.Substring(0, txtInput.Text.Length - lengthToRemove);
            }
        }
    }
}