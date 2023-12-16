using Core_API.Models;
using Core_API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Core_API.Controllers
{/// <summary>
/// The Rute Table ENtry
/// </summary>
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        /// <summary>
        /// Injection of the service
        /// </summary>
        private IDataService<Department, int> deptServ;
        public DepartmentController(IDataService<Department,int> serv)
        {
            deptServ = serv;
        }

        [HttpGet]
        [ActionName("get")]
        public async Task<IActionResult> GetAsync()
        {
            try
            {
                var response = await deptServ.GetAsync();
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        [ActionName("getsingle")]
        public async Task<IActionResult> GetAsync(int id)
        {
            try
            {
                var response = await deptServ.GetAsync(id);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        [ActionName("createnew")]
        public async Task<IActionResult> PostAsync(Department dept)
        {
            try
            {
                ///Load the Model class and verify its data validations
                ///based on attributes applied on each property of the Model class
                if (ModelState.IsValid)
                {
                    var response = await deptServ.CreateAsync(dept);
                    return Ok(response);
                }
               return BadRequest(ModelState);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{id}")]
        [ActionName("update")]
        public async Task<IActionResult> PutAsync(int id, Department dept)
        {
            try
            {
                ///Load the Model class and verify its data validations
                ///based on attributes applied on each property of the Model class
                if (ModelState.IsValid)
                {
                    var response = await deptServ.UpdateAsync(id,dept);
                    return Ok(response);
                }
                return BadRequest(ModelState);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpDelete("{id}")]
        [ActionName("delete")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            try
            {
                var response = await deptServ.DeleteAsync(id);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
