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

        public void Add (Request request)
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
    }
}
