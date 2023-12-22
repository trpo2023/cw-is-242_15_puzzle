using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace game_15
{
   
    public partial class Form1 : Form
    {
        int X = 100;
        int Y = 50;
        int W = 50;
        public static List<int> arr = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 0 };
        public static Button[] btns= new Button[16];
        Random random = new Random();

        public  Form1()
        {
            InitializeComponent();
            this.BackColor = Color.LightGray;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    
                    btns[i * 4 + j] = new Button();
                    btns[i * 4 + j].Location = new System.Drawing.Point(X + W * j, Y + W * i);
                    btns[i * 4 + j].Size = new System.Drawing.Size(W, W);
                    btns[i * 4 + j].Text = (i * 4 + j + 1).ToString();
                    if (i * 4 + j == 15) break;
                    btns[i * 4 + j].BackColor = Color.White;
                    btns[i * 4 + j].Visible = true;
                    btns[i * 4 + j].Click += Class1.button_Click;
                    
                    
                    this.Controls.Add(btns[i * 4 + j]);
                }
            }
            btns[15].Text = (0).ToString();
            btns[15].BackColor = Color.White;
            this.Controls.Add(btns[15]);
            btns[15].Visible = false;
            btns[15].Click += Class1.button_Click;
            ////InitializeComponent();
            this.Invalidate();

        }
       

        private void button17_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGray;
            for (int i = 15; i >= 1; i--)
            {
                int j = random.Next(i + 1);
                var temp = arr[j];
                arr[j] = arr[i];
                arr[i] = temp;
            }

            //Class2.visual();
            button17.Focus();
        }
        public void render()
        {
            button17.Focus();
        }
        
    }
}
