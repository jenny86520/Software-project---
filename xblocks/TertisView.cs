using banana;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace xblocks
{
    public partial class TertisView : Form
    {
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
<<<<<<< HEAD
            if (e.KeyCode == Keys.P)//暫停
            {
                if (game_mode == 0) { game_mode = 1; timer1.Enabled = true; }
                else { game_mode = 0; timer1.Enabled = false; }
            }
=======
            
>>>>>>> d282d5d56fcfe87d8a628374e02568bb5807a265

            if (e.KeyCode == Keys.Left)//左移
            {
                if (x_direction(block_type, block_row, block_col, -1))
                {
                    block_col_pre = block_col; block_col--;
                    block_changed = true;
                }
            }

            if (e.KeyCode == Keys.Right)//右移
            {
                if (x_direction(block_type, block_row, block_col, 1))
                {
                    block_col_pre = block_col; block_col++;
                    block_changed = true;
                }
            }

            if (e.KeyCode == Keys.Up)//旋轉
            {
                block_type_pre = block_type;
                block_col_pre = block_col; block_row_pre = block_row;
                block_type = next_block_type(block_type, block_row, block_col);
                if (block_type != block_type_pre)
                    block_changed = true;
            }

            if (e.KeyCode == Keys.S)//加速
            {
                game_mode = 2;
                timer_interval -= 50;

                if (timer_interval <= 0)
                    timer_interval = 1;

                timer1.Interval = timer_interval;
                label_level.Text = "Level:" + (1010 - timer_interval) / 50;
            }

            if (e.KeyCode == Keys.A)//減速
            {
                game_mode = 2;
                timer_interval += 50;

                if (timer_interval >= 1010)
                    timer_interval = 1010;

                timer1.Interval = timer_interval;
                label_level.Text = "Level:" + (1010 - timer_interval) / 50;
            }

            if (e.KeyCode == Keys.Down)//下移
                timer1.Interval = 15;


            if (block_changed)
            {
                erase_block(block_row_pre, block_col_pre, block_type_pre);
                update_block(block_row, block_col, block_type);
                show_grids();
                block_row_pre = block_row; block_col_pre = block_col; block_type_pre = block_type;
                block_changed = false;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            TertisModel f = new TertisModel();//產生Form2的物件，才可以使用它所提供的Method

            this.Visible = false;//將Form1隱藏。由於在Form1的程式碼內使用this，所以this為Form1的物件本身
            f.Visible = true;//顯示第二個視窗
        }

        
    }
}
