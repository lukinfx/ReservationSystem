using ReservationSystemEntityFW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp
{
    public partial class Contact : Page
    {
        private DatabaseUtils _databaseUtils = new DatabaseUtils();
        List<Train> listOfTrains;
        int numberOfColumns = 4;

        protected void Page_Load(object sender, EventArgs e)
        {
            listOfTrains = _databaseUtils.GetAllTrains();
            foreach (var item in listOfTrains)
            {
                DropDownListTrains.Items.Add(item.DepartureDate.ToShortDateString());
            }
        }

        protected void ShowAllRequests(object sender, EventArgs e)
        {
            var requests = _databaseUtils.GetAllRequests();
            CreateTableHeader();
            
            foreach (var request in requests)
            {
                TableRow r = new TableRow();

                TableCell name = new TableCell();
                name.Controls.Add(new LiteralControl(request.Name));
                r.Cells.Add(name);

                TableCell description = new TableCell();
                description.Controls.Add(new LiteralControl(request.Description));
                r.Cells.Add(description);

                TableCell departureDate = new TableCell();
                departureDate.Controls.Add(new LiteralControl(request.Train.DepartureDate.ToShortDateString()));
                r.Cells.Add(departureDate);

                TableCell email = new TableCell();
                email.Controls.Add(new LiteralControl(request.Email));
                r.Cells.Add(email);
                

                TableRequests.Rows.Add(r);

            }

        }

        protected void ShowApprovedRequestsForNextTrain(object sender, EventArgs e)
        {


        }

        protected void ShowRequestsForNextTrain(object sender, EventArgs e)
        {


        }

        private void CreateTableHeader ()
        {
            TableRow r = new TableRow();
            for (int i = 0; i < numberOfColumns; i++)
            {
                TableCell c = new TableCell();

                if (i == 0)
                    c.Controls.Add(new LiteralControl("Name"));

                if (i == 1)
                    c.Controls.Add(new LiteralControl("Description"));

                if (i == 2)
                    c.Controls.Add(new LiteralControl("Departure date"));

                if (i == 3)
                    c.Controls.Add(new LiteralControl("Email"));

                r.Cells.Add(c);
            }
            TableRequests.Rows.Add(r);
        }
    }
}