using System;
using System.Data;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        bool isCalculated = false;

        public Form1()
        {
            InitializeComponent();
        }

        // 1. 숫자 버튼: 치는 대로 위아래 창에 표시
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

        // 2. [수정됨] 연산자 버튼 (+, -, X, ÷): 아래 창 비우고 위 창에 기호만 추가
        private void btnOperator_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtInput.Text)) return;

            Button btn = (Button)sender;
            string op = btn.Text;

            // 이미 결과가 나온 상태면 결과값 뒤에 연산자 붙여서 이어서 계산
            if (isCalculated)
            {
                string lastResult = txtOutput.Text;
                txtInput.Text = lastResult + " " + op + " ";
                isCalculated = false;
            }
            else
            {
                txtInput.Text += " " + op + " ";
            }

            txtOutput.Clear(); // 다음 숫자를 위해 아래 창 비우기
        }

        // 3. [수정됨] 결과(=) 버튼: 여기서만 실제 계산을 수행함
        private void btnResult_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtInput.Text) || isCalculated) return;

            try
            {
                string expression = txtInput.Text.Trim();

                // 수식 끝에 연산자가 남았으면 제거
                char[] ops = { '+', '-', 'X', '÷', '*', '/' };
                expression = expression.TrimEnd(ops).Trim();

                // 기호 변환
                string finalExpr = expression.Replace("X", "*").Replace("÷", "/");

                // [핵심] 암시적 곱셈 처리 ( 2(3) -> 2*(3) )
                for (int i = 0; i < 10; i++)
                {
                    finalExpr = finalExpr.Replace(i.ToString() + "(", i.ToString() + "*(");
                    finalExpr = finalExpr.Replace(")" + i.ToString(), ")*" + i.ToString());
                }
                finalExpr = finalExpr.Replace(")(", ")*(");

                // DataTable로 계산
                DataTable dt = new DataTable();
                var result = dt.Compute(finalExpr, "");

                // 결과 표시
                txtInput.Text = expression + " = " + result.ToString();
                txtOutput.Text = result.ToString();
                isCalculated = true;
            }
            catch (Exception)
            {
                MessageBox.Show("수식이 올바르지 않습니다.");
            }
        }

        // 4. 초기화 및 삭제 버튼들
        private void btnC_Click(object sender, EventArgs e)
        {
            txtInput.Clear();
            txtOutput.Clear();
            isCalculated = false;
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            int len = txtOutput.Text.Length;
            txtOutput.Clear();
            if (txtInput.Text.Length >= len)
                txtInput.Text = txtInput.Text.Substring(0, txtInput.Text.Length - len);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtOutput.Text.Length > 0)
            {
                txtOutput.Text = txtOutput.Text.Substring(0, txtOutput.Text.Length - 1);
                if (txtInput.Text.Length > 0)
                    txtInput.Text = txtInput.Text.Substring(0, txtInput.Text.Length - 1);
            }
        }

        private void btnParenLeft_Click(object sender, EventArgs e)
        {
            if (isCalculated) { btnC_Click(null, null); }
            txtOutput.Clear();
            txtInput.Text += "(";
        }

        private void btnParenRight_Click(object sender, EventArgs e)
        {
            txtOutput.Clear();
            txtInput.Text += ")";
        }
    }
}