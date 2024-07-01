using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WH_management.Forms;

namespace WH_management
{
    public partial class mainForm : Form
    {
        private Button currentButton;
        private Form activeForm;
        public mainForm()
        {
            InitializeComponent();
        }

        private void showNewForm(Form cform , object btn)
        {
            if(activeForm != null )
            {
                activeForm.Close();
            }
            activeForm = cform;
            activeButton(btn);
            cform.TopLevel = false;
            cform.Dock = DockStyle.Fill;
            cform.FormBorderStyle = FormBorderStyle.None;
            AddformPnl.Controls.Add(cform);
            AddformPnl.Tag = cform;
            cform.BringToFront();
            cform.Show();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {

        }

        private void activeButton(object sender)
        {
            if(sender != null)
            {
                currentButton = (Button)sender;
                unselectedButton();
                if(currentButton != (Button)sender)
                {
                    currentButton = (Button)sender;
                    currentButton.BackColor = Color.White;
                    currentButton.ForeColor = Color.Black;
                }
            }
        }
        private void unselectedButton()
        {
            foreach(Control ctr in panel1.Controls)
            {
                if(ctr.GetType() == typeof(Button))
                {
                    currentButton.BackColor = Color.Gray;
                    currentButton.ForeColor = Color.White;
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) // إضافة
        {
            Button BTN = (Button)sender;
            showNewForm(new Addition_Permit(), BTN);
        }

        private void sarf_Click(object sender, EventArgs e) // صرف
        {
            Button BTN = (Button)sender;
            activeButton(BTN);

        }

        private void button3_Click(object sender, EventArgs e) // إرجاع
        {
            Button BTN = (Button)sender;
            activeButton(BTN);

        }

        private void button4_Click(object sender, EventArgs e) // اهلاك
        {
            Button BTN = (Button)sender;
            activeButton(BTN);

        }

        private void toolStripButton5_Click(object sender, EventArgs e) // exit the system
        {
            Application.Exit();
        }
    }
}