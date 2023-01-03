using AutoMapper;
using hoangdung.Core.Entity.Repository;
using hoangdung.Server.DAL.Entity;
using Microsoft.EntityFrameworkCore;

namespace hoangdung.Server.BLL.Services
{
    public class TodoService : GenericRepository<ToDo>
    {
        public TodoService(DbContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}