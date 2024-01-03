
using BLL.DTOs.PassengerDTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CBMS.Controllers
{
    public class PassengerController : ApiController
    {
        [HttpGet]
        [Route("api/passengers")]
        public HttpResponseMessage Passengers()
        {
            try
            {
                var data = PassengerService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex);
            }
        }
        [HttpGet]
        [Route("api/passengers/{id}")]
        public HttpResponseMessage Passengers(int id)
        {
            try
            {
                var data = PassengerService.Get(id);

                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Massage = ex.Message });
            }
        }

        [HttpPost]
        [Route("api/passengers/add")]
        public HttpResponseMessage ADD_Passengers(PassengerDTO passenger)
        {
            try
            {
                var data = PassengerService.Create(passenger);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Massage = ex.Message });
            }
        }

        [HttpPatch]
        [Route("api/passengers/{id}/update")]
        public HttpResponseMessage Update_Passengers(PassengerDTO passenger)
        {
            try
            {
                var data = PassengerService.Update(passenger); return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Massage = ex.Message });
            }
        }

        [HttpDelete]
        [Route("api/passengers/{id}/delete")]
        public HttpResponseMessage Delete_Passengers(int id)
        {
            try
            {
                var data = PassengerService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Massage = ex.Message });
            }
        }
    }
}
