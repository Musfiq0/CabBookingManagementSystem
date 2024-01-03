using AutoMapper;
using BLL.DTOs.OwnerDTOs;
using DAL;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class OwnerService
    {
        public static List<OwnerDTO> Get() {
            var data = DataAccessFactory.OwnerData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Owner, OwnerDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<OwnerDTO>>(data);
            return mapped;

        }
        public static OwnerDTO Get(int id)
        {
            var data = DataAccessFactory.OwnerData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Owner, OwnerDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<OwnerDTO>(data);
            return mapped;
        }

        public static OwnerDTO Create(OwnerDTO owner)
        {

            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<OwnerDTO, Owner>();
                c.CreateMap<Owner, OwnerDTO>();
            });
            var mapper = new Mapper(cfg);
            var ow = mapper.Map<Owner>(owner);
            var data = DataAccessFactory.OwnerData().Create(ow);
            
            if(data != null) return mapper.Map<OwnerDTO>(data);
            return null;
        }
        public static OwnerDTO Update(OwnerDTO owner)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<OwnerDTO, Owner>();
                c.CreateMap<Owner, OwnerDTO>();
            });
            var mapper = new Mapper(cfg);
            var ow = mapper.Map<Owner>(owner);
            var data=DataAccessFactory.OwnerData().Update(ow);

            if (data != null) return mapper.Map<OwnerDTO>(data);
            return null;
        }

        public static bool Delete(int Id)
        {
            var data = DataAccessFactory.OwnerData().Delete(Id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Owner, OwnerDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<bool>(data);
            return mapped;
        }
    }
}
