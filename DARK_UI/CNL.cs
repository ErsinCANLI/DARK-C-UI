﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace DARK_UI
{
    public partial class CNL : Form
    {
    //    [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
    //    private static extern IntPtr CreateRoundRectRgn
    //    (
    //        int nLeftRect,     // x-coordinate of upper-left corner
    //        int nTopRect,      // y-coordinate of upper-left corner
    //        int nRightRect,    // x-coordinate of lower-right corner
    //        int nBottomRect,   // y-coordinate of lower-right corner
    //        int nWidthEllipse, // height of ellipse
    //        int nHeightEllipse // width of ellipse
        //);
        public CNL()
        {
            InitializeComponent();
            //this.FormBorderStyle = FormBorderStyle.None;
            //Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
