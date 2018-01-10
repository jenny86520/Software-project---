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
        public virtual int label_block_X() { return 0; }//label_block視窗x
        public virtual int label_block_Y() { return 0; }//label_block視窗y
        public virtual int label_score_X() { return 0; }//label_score視窗x
        public virtual int label_score_Y() { return 0; }//label_score視窗y
        public virtual int label_level_X() { return 0; }//label_level視窗x
        public virtual int label_level_Y() { return 0; }//label_level視窗y
        public virtual Color color() { return Color.Black; }
        
    }
    class mode0 : mode 
    {

        public override int get_grids_Left() { return 50; }
        public override int get_next_Left() { return 500; }
        public override int get_next_Top() { return 150; }
        public override int nextLabel_X() { return 500; }
        public override int nextLabel_Y() { return 50; }
        public override int label_block_X() { return 500; }//label_block視窗x
        public override int label_block_Y() { return 200; }//label_block視窗y
        public override int label_score_X() { return 500; }//label_score視窗x
        public override int label_score_Y() { return 250; }//label_score視窗y
        public override int label_level_X() { return 500; }//label_level視窗x
        public override int label_level_Y() { return 300; }//label_level視窗y

        public override Color color() { return Color.MistyRose; }
    }
    public class mode1 : mode
    {
        public override int get_grids_Left() { return 350; }
        public override int get_next_Left() { return 100; }
        public override int get_next_Top() { return 200; }
        public override int nextLabel_X() { return 100; }
        public override int nextLabel_Y() { return 100; }
        public override int label_block_X() { return 100; }//label_block視窗x
        public override int label_block_Y() { return 230; }//label_block視窗y
        public override int label_score_X() { return 100; }//label_score視窗x
        public override int label_score_Y() { return 280; }//label_score視窗y
        public override int label_level_X() { return 100; }//label_level視窗x
        public override int label_level_Y() { return 330; }//label_level視窗y
        public override Color color() { return Color.Bisque; }
    }
    public class mode2 : mode
    {
        public override int get_grids_Left() { return 350; }
        public override int get_next_Left() { return 100; }
        public override int get_next_Top() { return 350; }
        public override int nextLabel_X() { return 100; }
        public override int nextLabel_Y() { return 250; }
        public override int label_block_X() { return 100; }//label_block視窗x
        public override int label_block_Y() { return 200; }//label_block視窗y
        public override int label_score_X() { return 100; }//label_score視窗x
        public override int label_score_Y() { return 150; }//label_score視窗y
        public override int label_level_X() { return 100; }//label_level視窗x
        public override int label_level_Y() { return 100; }//label_level視窗y
        public override Color color() { return Color.Beige; }
    }
    public class mode3 : mode
    {
        public override int get_grids_Left() { return 50; }
        public override int get_next_Left() { return 500; }
        public override int get_next_Top() { return 150; }
        public override int nextLabel_X() { return 500; }
        public override int nextLabel_Y() { return 50; }
        public override int label_block_X() { return 500; }//label_block視窗x
        public override int label_block_Y() { return 200; }//label_block視窗y
        public override int label_score_X() { return 500; }//label_score視窗x
        public override int label_score_Y() { return 250; }//label_score視窗y
        public override int label_level_X() { return 500; }//label_level視窗x
        public override int label_level_Y() { return 300; }//label_level視窗y
        public override Color color() { return Color.Aquamarine; }
    }
    public class mode4 : mode
    {
        public override int get_grids_Left() { return 350; }
        public override int get_next_Left() { return 100; }
        public override int get_next_Top() { return 200; }
        public override int nextLabel_X() { return 100; }
        public override int nextLabel_Y() { return 100; }
        public override int label_block_X() { return 100; }//label_block視窗x
        public override int label_block_Y() { return 230; }//label_block視窗y
        public override int label_score_X() { return 100; }//label_score視窗x
        public override int label_score_Y() { return 280; }//label_score視窗y
        public override int label_level_X() { return 100; }//label_level視窗x
        public override int label_level_Y() { return 330; }//label_level視窗y
        public override Color color() { return Color.Thistle; }
    }
    public partial class TertisModel : Form
    {
        //int modeIndex = 0;
        mode MODE = new mode0();
        public TertisModel()
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
            TertisView f = new TertisView(MODE);//產生Form2的物件，才可以使用它所提供的Method

            this.Visible = false;//將Form1隱藏。由於在Form1的程式碼內使用this，所以this為Form1的物件本身
            f.Visible = true;//顯示第二個視窗
        }
       

    }
}
