using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationSystemEntityFW
{
    public class DatabaseUtils
    {
        ReservationSystem2Entities context = new ReservationSystem2Entities();
        #region Request
        public void AddRequest (Request request)
        {
            context.Request.Add(request);
            context.SaveChanges();
        }

        public List<Request> GetAllRequests()
        {
            var list = context.Request.ToList();
            return list;
        }

        public Request GetLastRequest()
        {
            var last = context.Request.OrderByDescending(x => x.Id).First();
            return last;
        }

        public void ConfirmRequest (Request requestToBeConfirmed)
        {
            context.Request.Remove(requestToBeConfirmed);
            requestToBeConfirmed.Approved = true;
            context.Request.Add(requestToBeConfirmed);
        } 

        public void DenyRequest (Request request)
        {
            context.Request.Remove(request);
            request.Approved = false;
            context.Request.Add(request);
        }

        public List<Request> GetPendingRequests()
        {
            var list = context.Request.Where(i => i.Approved == null).ToList();
            return list;
        }

        public List<Request> GetApprovedRequests()
        {
            var list = context.Request.Where(i => i.Approved == true).ToList();
            return list;
        }

        public List<Request> GetDenyiedRequests()
        {
            var list = context.Request.Where(i => i.Approved == false).ToList();
            return list;
        }
        #endregion Request

        #region Train
        public void AddTrain(Train train)
        {
            context.Train.Add(train);
            context.SaveChanges();
        }

        public List<Train> GetAllTrains()
        {
            var list = context.Train.ToList();
            return list;
        }

        public List<Train> GetFutureTrains()
        {
            var last = context.Train.Where(i => i.DepartureDate >= DateTime.Now).ToList();
            return last;
        }

        public List<Request> ConfirmedRequestsForTrain(int TrainId)
        {
            var train = context.Train.Where(i => i.Id == TrainId).ToList().First();
            return train.Request.ToList();
        }

        public Train GetLastTrain()
        {
            var last = context.Train.OrderByDescending(x => x.Id).First();
            return last;
        }

        #endregion Train

        #region User
        public bool ValidateUser(string username, string password)
        {
            bool validUser = false;
            if (ValidUsername(username))
            {
                var user = context.User.Where(x => x.Username == username).First();
                validUser = (password == user.Password);
            }

            
            return validUser;
        }

        private bool ValidUsername(string username)
        {
            bool isValid = context.User.Where(x => x.Username == username).Count() > 0;
            return isValid;
        }


        public void AddUser(string username, string password)
        {
            if (context.User.Where(x => x.Username == username).Count() == 0)
            {
                context.User.Add(new User() { Username = username, Password = password });
                context.SaveChanges();
            }
        }

        #endregion User
    }
}
