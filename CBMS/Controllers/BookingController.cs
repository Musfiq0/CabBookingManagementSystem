using BLL.DTOs.BookingDTOs;
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
    public class BookingController : ApiController
    {
        [HttpGet]
        [Route("api/bookings")]
        public HttpResponseMessage Bookings()
        {
            try
            {
                var data = BookingService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex);
            }
        }
        [HttpGet]
        [Route("api/bookings/{id}")]
        public HttpResponseMessage Bookings(int id)
        {
            try
            {
                var data = BookingService.Get(id);

                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Massage = ex.Message });
            }
        }

        [HttpPost]
        [Route("api/bookings/add")]
        public HttpResponseMessage ADD_Bookings(BookingDTO booking)
        {
            try
            {
                var data = BookingService.Create(booking);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Massage = ex.Message });
            }
        }

        [HttpPatch]
        [Route("api/bookings/{id}/update")]
        public HttpResponseMessage Update_Bookings(BookingDTO booking)
        {
            try
            {
                var data = BookingService.Update(booking); return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Massage = ex.Message });
            }
        }

        [HttpDelete]
        [Route("api/bookings/{id}/delete")]
        public HttpResponseMessage Delete_Bookings(int id)
        {
            try
            {
                var data = BookingService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Massage = ex.Message });
            }
        }
    }
}
