using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestCleanArchitecture.Domain.Contracts.Infrastructure;
using TestCleanArchitecture.Domain.Entities;

namespace TestCleanArchitecture.Application.UseCases
{
    public class UserService 
    {
        private readonly IUnitOfWork UnitOfWork;
        public UserService(IUnitOfWork unitOfWork)
        {
            UnitOfWork = unitOfWork;
        }

        public IQueryable<User> GetAll()
        {
            return UnitOfWork.Repository<User>().GetAll();
        }
    }
}
