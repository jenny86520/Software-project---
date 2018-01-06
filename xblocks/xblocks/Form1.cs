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
    public class mode
    {
       
        public virtual int get_grids_Left() { return 0; }//遊戲視窗x
        public virtual int get_next_Left() { return 0; }//next視窗x
        public virtual int get_next_Top() { return 0; }//next視窗y
        public virtual int nextLabel_X() { return 0; }//nextlabel視窗x
        public virtual int nextLabel_Y() { return 0; }//nextlabel視窗y
    }
    class mode0 : mode 
    {

        public override int get_grids_Left() { return 0; }
        public override int get_next_Left() { return 500; }
        public override int get_next_Top() { return 100; }
        public override int nextLabel_X() { return 500; }
        public override int nextLabel_Y() { return 150; }


    }
    public class mode1 : mode
    {
        public override int get_grids_Left() { return 100; }
        public override int get_next_Left() { return 400; }
        public override int get_next_Top() { return 100; }
        public override int nextLabel_X() { return 400; }
        public override int nextLabel_Y() { return 150; }
    }
    public class mode2 : mode
    {
        public override int get_grids_Left() { return 200; }
        public override int get_next_Left() { return 700; }
        public override int get_next_Top() { return 100; }
        public override int nextLabel_X() { return 100; }
        public override int nextLabel_Y() { return 150; }
    }
    public class mode3 : mode
    {
        public override int get_grids_Left() { return 300; }
        public override int get_next_Left() { return 700; }
        public override int get_next_Top() { return 100; }
        public override int nextLabel_X() { return 50; }
        public override int nextLabel_Y() { return 50; }
    }
    public class mode4 : mode
    {
        public override int get_grids_Left() { return 400; }
        public override int get_next_Left() { return 700; }
        public override int get_next_Top() { return 100; }
        public override int nextLabel_X() { return 0; }
        public override int nextLabel_Y() { return 0; }
    }
    public partial class Form1 : Form
    {
        //int modeIndex = 0;
        mode MODE;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           MODE = new mode0();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MODE = new mode1();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MODE = new mode2();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MODE = new mode3();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MODE = new mode4();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2(MODE);//產生Form2的物件，才可以使用它所提供的Method

            this.Visible = false;//將Form1隱藏。由於在Form1的程式碼內使用this，所以this為Form1的物件本身
            f.Visible = true;//顯示第二個視窗
        }
    }
}
