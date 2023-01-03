using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using hoangdung.Server.BLL.IService;
using hoangdung.Server.DAL.Context;
using hoangdung.Server.DAL.Entity;
using Microsoft.AspNetCore.Mvc;

namespace hoangdung.Server.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ToDoController : ControllerBase
    {
        private readonly ITodoService _todoService;

        public ToDoController(ITodoService todoService)
        {
            _todoService = todoService;
        }
        [HttpGet()]
        public async Task<IActionResult> GetAll()
        {
            var data = await _todoService.GetAll();
            return Ok(data);
        }
        [HttpPost]
        public async Task<IActionResult> Add(ToDo todo)
        {
            await _todoService.Add(todo);
            var result = _todoService.SaveChange();
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update(ToDo todo)
        {
            _todoService.Update(todo);
            var result = _todoService.SaveChange();
            return Ok(result);
        }
    }
}