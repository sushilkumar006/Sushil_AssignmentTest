using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Sushil_AssignmentTest.Areas.Identity.Data;
using Sushil_AssignmentTest.Migrations;
using Sushil_AssignmentTest.Models;

namespace Sushil_AssignmentTest.Controllers
{
    
    public class CustomersController : Controller
    {
        private readonly DataBaseContext _context;

        public CustomersController(DataBaseContext context)
        {
            _context = context;
        }
     
        public IActionResult CustomerList() {
          
          return View();
        }

        public IActionResult ErrorPage() 
        {
            return View();
        }
        public  JsonResult GetState()
        {
           
            var data = _context.States.ToList();

            return Json(data);
        }

        public JsonResult GetDistrict(int state)
        {

            var data = _context.Districts.ToList().Where(x=>x.StId==state);

            return Json(data);
        }

        public void UserInsertUpdate(Customer_Info obj)
        {
            try
            {
                    if (obj.ID == 0)
                    {

                        Customer_Info customer = new Customer_Info();
                        customer = obj;
                        _context.Customer_Infos.Add(customer);
                        _context.SaveChanges();

                    }
                    else
                    {

                        var data = _context.Customer_Infos.Find(obj.ID);

                        if (data != null)
                        {
                            data.Name = obj.Name;
                            data.GenderId = obj.GenderId;
                            data.StateId = obj.StateId;
                            data.DistrictId = obj.DistrictId;
                            _context.Customer_Infos.Update(data);
                            _context.SaveChanges();
                        }
                    }
               
            }
            catch (Exception ex)
            {

            }

        }
        public JsonResult GetCustomer()
        
        {
            try
            {

                var data = _context.Customer_Infos
            .Include(c => c.State)
            .Include(c => c.District)
            .Select(c => new Customer_Info
            {
                ID = c.ID,
                Name = c.Name,
                GenderId = c.GenderId,


                State = new State
                {
                    Id = c.State.Id,
                    StateName = c.State.StateName
                },
                District = new District
                {
                    Id = c.District.Id,
                    DistrictName = c.District.DistrictName
                }
            })
            .ToList();
                return Json(data);
            }
            catch(Exception ex) {
                return Json(null);
            }

           
        }

        public JsonResult UserEdit(int UserId)
        {
            var data = _context.Customer_Infos.Find(UserId);
            return Json(data);
        }
        public void UserDelete(int UserId)
        {
            try
            {
                var data = _context.Customer_Infos.Find(UserId);
                if (data != null)
                {
                    _context.Customer_Infos.Remove(data);
                    _context.SaveChanges();
                }
            }
            catch (Exception ex) { }
          
            
        }
    }
}
