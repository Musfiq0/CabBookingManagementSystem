using AutoMapper;
using BLL.DTOs.OwnerDTOs;
using DAL.Models;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.DTOs.DriverDTOs;

namespace BLL.Services
{
    public class DriverService
    {

        public static List<DriverDTO> Get()
        {
            var data = DataAccessFactory.DriverData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Driver, DriverDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<DriverDTO>>(data);
            return mapped;

        }
        public static DriverDTO Get(int id)
        {
            var data = DataAccessFactory.DriverData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Driver, DriverDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<DriverDTO>(data);
            return mapped;
        }

        public static DriverDTO Create(DriverDTO driver)
        {

            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<DriverDTO, Driver>();
                c.CreateMap<Driver, DriverDTO>();
            });
            var mapper = new Mapper(cfg);
            var dr = mapper.Map<Driver>(driver);
            var data = DataAccessFactory.DriverData().Create(dr);

            if (data != null) return mapper.Map<DriverDTO>(data);
            return null;
        }
        public static DriverDTO Update(DriverDTO driver)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<DriverDTO, Driver>();
                c.CreateMap<Driver, DriverDTO>();
            });
            var mapper = new Mapper(cfg);
            var drivers = mapper.Map<Driver>(driver);
            var data = DataAccessFactory.DriverData().Update(drivers);

            if (data != null) return mapper.Map<DriverDTO>(data);
            return null;
        }

        public static bool Delete(int Id)
        {
            var data = DataAccessFactory.DriverData().Delete(Id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Driver, DriverDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<bool>(data);
            return mapped;
        }
    }
}
