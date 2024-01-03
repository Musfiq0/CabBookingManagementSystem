using BLL.DTOs.DriverDTOs;
using BLL.DTOs.OwnerDTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CBMS.Controllers
{
    public class DriverController : ApiController
    {
        [HttpGet]
        [Route("api/drivers")]
        public HttpResponseMessage Drivers()
        {
            try
            {
                var data = DriverService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex);
            }
        }
        [HttpGet]
        [Route("api/drivers/{id}")]
        public HttpResponseMessage Drivers(int id)
        {
            try
            {
                var data = DriverService.Get(id);

                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Massage = ex.Message });
            }
        }

        [HttpPost]
        [Route("api/drivers/add")]
        public HttpResponseMessage ADD_Driver(DriverDTO driver)
        {
            try
            {
                var data = DriverService.Create(driver);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Massage = ex.Message });
            }
        }

        [HttpPatch]
        [Route("api/drivers/{id}/update")]
        public HttpResponseMessage Update_Driver(DriverDTO driver)
        {
            try
            {
                var data = DriverService.Update(driver); return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Massage = ex.Message });
            }
        }

        [HttpDelete]
        [Route("api/drivers/{id}/delete")]
        public HttpResponseMessage Delete_Driver(int id)
        {
            try
            {
                var data = DriverService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Massage = ex.Message });
            }
        }
    }
}
