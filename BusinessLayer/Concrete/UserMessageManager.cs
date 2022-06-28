using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class UserMessageManager : IUserMessageService
    {
        IUserMessageDal _UserMessageDal;

        public UserMessageManager(IUserMessageDal userMessageDal)
        {
            _UserMessageDal = userMessageDal;
        }

        public UserMessage GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<UserMessage> GetUserMessagesWithUserService()
        {
            return _UserMessageDal.GetUserMessagesWithUser();
        }

        public void TAdd(UserMessage t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(UserMessage t)
        {
            throw new NotImplementedException();
        }

        public List<UserMessage> TGetList()
        {
            return _UserMessageDal.GetList();
        }

        public void TUpdate(UserMessage t)
        {
            throw new NotImplementedException();
        }
    }
}
