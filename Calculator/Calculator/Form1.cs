using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        float data1, data2;
        string pheptinh;
        float lastResult = 0;
        private void btnClear_Click(object sender, EventArgs e)
        {
            hienthi1.Clear();
            hienthi2.Clear();
        }

        private void hienthi1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            hienthi1.Text = hienthi1.Text + "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            hienthi1.Text = hienthi1.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            hienthi1.Text = hienthi1.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            hienthi1.Text = hienthi1.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            hienthi1.Text = hienthi1.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            hienthi1.Text = hienthi1.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            hienthi1.Text = hienthi1.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            hienthi1.Text = hienthi1.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            hienthi1.Text = hienthi1.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            hienthi1.Text = hienthi1.Text + "9";
        }

        private void btnCham_Click(object sender, EventArgs e)
        {
            hienthi1.Text = hienthi1.Text + ".";
        }


        private void btnCong_Click(object sender, EventArgs e)
        {
            pheptinh = "cong";
            data1 = float.Parse(hienthi1.Text);
            hienthi1.Clear();
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            pheptinh = "tru";
            data1 = float.Parse(hienthi1.Text);
            hienthi1.Clear();
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            pheptinh = "nhan";
            data1 = float.Parse(hienthi1.Text);
            hienthi1.Clear();
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            pheptinh = "chia";
            data1 = float.Parse(hienthi1.Text);
            hienthi1.Clear();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            if(pheptinh == "cong")
            {
                data2 = data1 + float.Parse(hienthi1.Text);
                hienthi2.Text = data1.ToString() + " + " + float.Parse(hienthi1.Text) + " = ";
                hienthi1.Text = data2.ToString();
            }else if(pheptinh == "tru")
            {
                data2 = data1 - float.Parse(hienthi1.Text);
                hienthi2.Text = data1.ToString() + " - " + float.Parse(hienthi1.Text) + " = ";
                hienthi1.Text = data2.ToString();
            }else if(pheptinh == "nhan")
            {
                data2 = data1 * float.Parse(hienthi1.Text);
                hienthi2.Text = data1.ToString() + " * " + float.Parse(hienthi1.Text) + " = ";
                hienthi1.Text = data2.ToString();
            }else if(pheptinh == "chia")
            {
                if(float.Parse(hienthi1.Text) == 0)
                {
                    hienthi2.Text = data1.ToString() + " / ";
                    hienthi1.Text = "Khong chia duoc";
                }
                else
                {
                    data2 = data1 / float.Parse(hienthi1.Text);
                    hienthi2.Text = data1.ToString() + " / " + float.Parse(hienthi1.Text) + " = ";
                    hienthi1.Text = data2.ToString();
                }
                lastResult = data2;
            }
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy giá trị hiện tại từ ô nhập liệu
                float value = float.Parse(hienthi1.Text);

                if (value < 0)
                {
                    hienthi1.Text = "Không hợp lệ";
                }
                else
                {
                    // Tính căn bậc 2
                    float result = (float)Math.Sqrt(value);

                    // Hiển thị kết quả
                    hienthi2.Text = "√" + value.ToString() + " = ";
                    hienthi1.Text = result.ToString();

                    // Lưu kết quả vào biến lastResult
                    lastResult = result;
                }
            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu có vấn đề với giá trị đầu vào
                hienthi1.Text = "Lỗi";
            }
        }

        private void btnLastResult_Click(object sender, EventArgs e)
        {
            hienthi1.Text = lastResult.ToString();
        }
    }
}
