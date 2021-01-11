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
        List<Train> listOfTrains;

        protected void Page_Load(object sender, EventArgs e)
        {
            listOfTrains = _databaseUtils.GetAllTrains();
            foreach(var item in listOfTrains)
            {
                DropDownListDates.Items.Add(item.DepartureDate.ToShortDateString());
            }
        }

        protected void AddRequest(object sender, EventArgs e)
        {
            //_databaseUtils.AddTrain(new Train() { DepartureDate = DateTime.Today, TrainNumber = "ABCDE256" });

            Request request = new Request()
            {
                Name = TextBoxName.Text,
                Description = TextBoxDescription.Text,
                Height = 10,
                Lenght = 10,
                Depth = 10,
                SubmitDate = DateTime.Now,
                Weight = Convert.ToDecimal(TextBoxweight.Text),
                Email = TextBoxEmail.Text,
                TrainId = listOfTrains.Where(i => i.DepartureDate.ToShortDateString() == DropDownListDates.SelectedValue).ToList().First().Id
            };

            _databaseUtils.AddRequest(request);
            LabelSubmitted.Text = "Request submitted";
        }


    }
}