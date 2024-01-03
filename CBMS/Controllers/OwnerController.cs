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
    public class OwnerController : ApiController
    {
        [HttpGet]
        [Route("api/owners")]
        public HttpResponseMessage Owners()
        {
            try
            {
                var data = OwnerService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex);
            }
        }
        [HttpGet]
        [Route("api/owners/{id}")]
        public HttpResponseMessage Owners(int id)
        {
            try
            {
                var data = OwnerService.Get(id);

                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Massage = ex.Message });
            }
        }

        [HttpPost]
        [Route("api/owners/add")]
        public HttpResponseMessage ADD_Owner(OwnerDTO owner)
        {
            try
            {
                var data = OwnerService.Create(owner);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Massage = ex.Message });
            }
        }

        [HttpPatch]
        [Route("api/owners/{id}/update")]
        public HttpResponseMessage Update_Owner(OwnerDTO owner)
        {
            try
            {
                var data = OwnerService.Update(owner); return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Massage = ex.Message });
            }
        }

        [HttpDelete]
        [Route("api/owners/{id}/delete")]
        public HttpResponseMessage Delete_Owner(int id)
        {
            try
            {
                var data = OwnerService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Massage = ex.Message });
            }
        }
    }
}
