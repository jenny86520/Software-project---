using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using xblocks;

namespace banana
{
    public partial class Form1 : Form
    {
        int modeIndex = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            modeIndex = 0;
            Form2 f = new Form2(0);//產生Form2的物件，才可以使用它所提供的Method

            this.Visible = false;//將Form1隱藏。由於在Form1的程式碼內使用this，所以this為Form1的物件本身
            f.Visible = true;//顯示第二個視窗
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2(1);//產生Form2的物件，才可以使用它所提供的Method

            this.Visible = false;//將Form1隱藏。由於在Form1的程式碼內使用this，所以this為Form1的物件本身
            f.Visible = true;//顯示第二個視窗
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2(2);//產生Form2的物件，才可以使用它所提供的Method

            this.Visible = false;//將Form1隱藏。由於在Form1的程式碼內使用this，所以this為Form1的物件本身
            f.Visible = true;//顯示第二個視窗
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2(3);//產生Form2的物件，才可以使用它所提供的Method

            this.Visible = false;//將Form1隱藏。由於在Form1的程式碼內使用this，所以this為Form1的物件本身
            f.Visible = true;//顯示第二個視窗
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2(4);//產生Form2的物件，才可以使用它所提供的Method

            this.Visible = false;//將Form1隱藏。由於在Form1的程式碼內使用this，所以this為Form1的物件本身
            f.Visible = true;//顯示第二個視窗
        }
    }
}
