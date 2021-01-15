using ClosedXML.Excel;
using ReservationSystemEntityFW;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp
{
    public partial class ViewRequests : Page
    {
        private DatabaseUtils _databaseUtils = new DatabaseUtils();
        private List<Request> _listOfRequests;
        private List<Train> _listOfTrains;

        int numberOfColumns = 4;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (WebAppContext.Instance().ValidUser != true)
            {
                Response.Redirect("Login.aspx");
                Response.End();
            }
            _listOfTrains = _databaseUtils.GetAllTrains();
            foreach (var item in _listOfTrains)
            {
                DropDownListTrains.Items.Add(item.DepartureDate.ToShortDateString());
            }
            FillTrainTable();
            
        }

        protected void ShowAllRequests(object sender, EventArgs e)
        {
            _listOfRequests = _databaseUtils.GetAllRequests();
            FillRequestTable(_listOfRequests);
        }

        protected void ShowApprovedRequestsForNextTrain(object sender, EventArgs e)
        {
            _listOfRequests = _databaseUtils.GetApprovedRequests().Where(i => i.Train.DepartureDate >= DateTime.Now && i.Approved == true).ToList();
            FillRequestTable(_listOfRequests);
        }

        protected void ShowRequestsForNextTrain(object sender, EventArgs e)
        {
            _listOfRequests = _databaseUtils.GetAllRequests().Where(i => i.Train.DepartureDate >= DateTime.Now).ToList();
            FillRequestTable(_listOfRequests);
        }

        protected void AddTrain(object sender, EventArgs e)
        {
            _databaseUtils.AddTrain(new Train() { DepartureDate = CalendarTrainDeparture.SelectedDate, TrainNumber = TextBoxTrainNumber.Text });
            AddNewTrainToTable(); 
        }

        private void CreateRequestTableHeader ()
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

        private void FillRequestTable(List<Request> list)
        {
            CreateRequestTableHeader();
            foreach (var request in list)
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

        protected void DownloadTable(object sender, EventArgs e)
        {
            var workbook = new XLWorkbook();
            workbook.AddWorksheet("sheetName");
            var ws = workbook.Worksheet("sheetName");

            int row = 1;
            foreach (var item in _databaseUtils.GetAllRequests())
            {
                ws.Cell(row, 1).Value = item.Name;
                ws.Cell(row, 2).Value = item.Description;
                ws.Cell(row, 3).Value = item.Train.DepartureDate;
                ws.Cell(row, 4).Value = item.Email; 
                row++;
            }
            
            var tempDir = Path.GetTempPath();
            var filePath = Path.Combine(tempDir, "test.xlsx");
            workbook.SaveAs(filePath);

            Response.Clear();
            Response.ClearHeaders();
            Response.ClearContent();
            Response.AddHeader("Content-Disposition", "attachment; filename=" + "text.xlsx");
            //Response.AddHeader("Content-Length", filePath.Length.ToString());
            Response.ContentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
            Response.Flush();
            Response.TransmitFile(filePath);
            Response.End();

        }

        private void CreateTrainTableHeader()
        {
            TableRow r = new TableRow();
            for (int i = 0; i < 2; i++)
            {
                TableCell c = new TableCell();

                if (i == 0)
                    c.Controls.Add(new LiteralControl("Train Number"));

                if (i == 1)
                    c.Controls.Add(new LiteralControl("Departure date"));

                r.Cells.Add(c);
            }
            TableTrains.Rows.Add(r);
        }

        private void FillTrainTable()
        {
            CreateTrainTableHeader();
            foreach (var train in _databaseUtils.GetAllTrains())
            {
                TableRow r = new TableRow();

                TableCell trainNumber = new TableCell();
                trainNumber.Controls.Add(new LiteralControl(train.TrainNumber));
                r.Cells.Add(trainNumber);

                TableCell trainDepartureDate = new TableCell();
                trainDepartureDate.Controls.Add(new LiteralControl(train.DepartureDate.ToShortDateString()));
                r.Cells.Add(trainDepartureDate);


                TableTrains.Rows.Add(r);
            }
        }

        private void AddNewTrainToTable()
        {
            Train train = _databaseUtils.GetLastTrain();
            TableRow r = new TableRow();

            TableCell trainNumber = new TableCell();
            trainNumber.Controls.Add(new LiteralControl(train.TrainNumber));
            r.Cells.Add(trainNumber);

            TableCell trainDepartureDate = new TableCell();
            trainDepartureDate.Controls.Add(new LiteralControl(train.DepartureDate.ToShortDateString()));
            r.Cells.Add(trainDepartureDate);


            TableTrains.Rows.Add(r);
            
        }

    }
}