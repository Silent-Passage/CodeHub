using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_Controls_Dynamisches_erzeugen
{
    public partial class frm_Container : Form
    {
        public frm_Container()
        {
            InitializeComponent();
        }
        Button My_Button = new Button();
        private void frm_Container_Load(object sender, EventArgs e)
        {
            TextBox My_TextBox = new TextBox();
            My_TextBox.Name = "tb_3bWI";
            My_TextBox.Height = 150;
            My_TextBox.Width = 250;
            My_TextBox.Multiline = true;
            My_TextBox.Location = new Point(100, 300);
            this.Controls.Add(My_TextBox);

        }

        private void btn_erzeugen_Click(object sender, EventArgs e)
        {
            //Button My_Button = new Button();
            My_Button.Name = "btn_OK";
            My_Button.Text = "Trau dich nochmal!";
            My_Button.Location = new Point(400, 200);
            My_Button.Width = 500;
            My_Button.Height = 200;
            My_Button.Click += new EventHandler(btn_OK_Click);
            this.Controls.Add(My_Button);
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hallo");
            My_Button.PerformClick();
        }
    }
}
