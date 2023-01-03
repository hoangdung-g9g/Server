using AutoMapper;
using hoangdung.Core.Entity.Repository;
using hoangdung.Server.BLL.IService;
using hoangdung.Server.DAL.Context;
using hoangdung.Server.DAL.Entity;
using Microsoft.EntityFrameworkCore;

namespace hoangdung.Server.BLL.Services
{
    public class TodoService : GenericRepository<ToDo>,ITodoService
    {
        public TodoService(AppDbContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}