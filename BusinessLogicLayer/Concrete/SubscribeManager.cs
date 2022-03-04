using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Concrete
{
    public class SubscribeManager
    {
        Repository<SubscribeMail> repoSubscribe = new Repository<SubscribeMail>(); 
        public int BLAdd(SubscribeMail p)
        {
            if(p.Mail.Length<=9 || p.Mail.Length>=50)
            {
                return -1;
            }
            return repoSubscribe.Insert(p);
        }

        public List<SubscribeMail> GetAll()
        {
            return repoSubscribe.List();

        }
        public int DeleteSubscriberBLL(int p)
        {
            SubscribeMail subscriber = repoSubscribe.Find(x => x.MailID == p);
            return repoSubscribe.Delete(subscriber);
        }
    }
}
