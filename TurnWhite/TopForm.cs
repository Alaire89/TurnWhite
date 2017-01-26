using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TurnWhite
{
    public partial class TopForm : Form
    {
        public TopForm()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            //close this form
            this.Close();
        }
        TopPlayer FirstPlayer = new TopPlayer();
        TopPlayer SecondPlayer = new TopPlayer();
        TopPlayer ThirdPlayer = new TopPlayer();
        TopPlayer FourthPlayer = new TopPlayer();
        TopPlayer FifthPlayer = new TopPlayer();
        TopPlayer SixthPlayer = new TopPlayer();
        TopPlayer SeventhPlayer = new TopPlayer();
        TopPlayer EighthPlayer = new TopPlayer();
        TopPlayer NinthPlayer = new TopPlayer();
        TopPlayer TenthPlayer = new TopPlayer();


    }
}
