using AutoMapper;
using BLL.DTOs.PassengerDTOs;
using DAL.Models;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class PassengerService
    {
        public static List<PassengerDTO> Get()
        {
            var data = DataAccessFactory.PassengerData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Passenger, PassengerDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<PassengerDTO>>(data);
            return mapped;

        }
        public static PassengerDTO Get(int id)
        {
            var data = DataAccessFactory.PassengerData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Passenger, PassengerDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<PassengerDTO>(data);
            return mapped;
        }

        public static PassengerDTO Create(PassengerDTO passenger)
        {

            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<PassengerDTO, Passenger>();
                c.CreateMap<Passenger, PassengerDTO>();
            });
            var mapper = new Mapper(cfg);
            var dr = mapper.Map<Passenger>(passenger);
            var data = DataAccessFactory.PassengerData().Create(dr);

            if (data != null) return mapper.Map<PassengerDTO>(data);
            return null;
        }
        public static PassengerDTO Update(PassengerDTO passenger)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<PassengerDTO, Passenger>();
                c.CreateMap<Passenger, PassengerDTO>();
            });
            var mapper = new Mapper(cfg);
            var passengers = mapper.Map<Passenger>(passenger);
            var data = DataAccessFactory.PassengerData().Update(passengers);

            if (data != null) return mapper.Map<PassengerDTO>(data);
            return null;
        }

        public static bool Delete(int Id)
        {
            var data = DataAccessFactory.PassengerData().Delete(Id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Passenger, PassengerDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<bool>(data);
            return mapped;
        }
    }
}
