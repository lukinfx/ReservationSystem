using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ReservationSystemEntityFW;

namespace WebApp
{
    public partial class About : Page
    {
        private DatabaseUtils _databaseUtils = new DatabaseUtils();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void AddRequest(object sender, EventArgs e)
        {
            Request request = new Request();
            request.Name = TextBox1.Text;
            _databaseUtils.Add(request);
        }

        protected void LastRequest(object sender, EventArgs e)
        {
            Label2.Text =  _databaseUtils.GetLastRequest().Name;
        }
    }
}