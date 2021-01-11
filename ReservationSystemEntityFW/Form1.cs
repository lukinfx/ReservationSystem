using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReservationSystemEntityFW
{
    public partial class Form1 : Form
    {
        DatabaseUtils databaseUtils = new DatabaseUtils();
        public Form1()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            databaseUtils.AddRequest(new Request{ Name = "001", Approved = false });
        }

        private void ReadButton_Click(object sender, EventArgs e)
        {
            var a = databaseUtils.GetLastRequest();
        }
    }
}
