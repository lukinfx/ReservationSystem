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

        #endregion Train
    }
}
