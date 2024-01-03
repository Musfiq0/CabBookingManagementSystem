using AutoMapper;

using DAL.Models;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.DTOs.BookingDTOs;

namespace BLL.Services
{
    public class BookingService
    {
        public static List<BookingDTO> Get()
        {
            var data = DataAccessFactory.BookingData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Driver, BookingDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<BookingDTO>>(data);
            return mapped;

        }
        public static BookingDTO Get(int id)
        {
            var data = DataAccessFactory.BookingData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Driver, BookingDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<BookingDTO>(data);
            return mapped;
        }

        public static BookingDTO Create(BookingDTO booking)
        {

            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<BookingDTO, Booking>();
                c.CreateMap<Booking, BookingDTO>();
            });
            var mapper = new Mapper(cfg);
            var bk = mapper.Map<Booking>(booking);
            var data = DataAccessFactory.BookingData().Create(bk);

            if (data != null) return mapper.Map<BookingDTO>(data);
            return null;
        }
        public static BookingDTO Update(BookingDTO booking)
        {
            var cfg = new MapperConfiguration(c =>
            {     
                c.CreateMap<BookingDTO, Booking>();
                c.CreateMap<Booking, BookingDTO>();
            });
            var mapper = new Mapper(cfg);
            var bookings = mapper.Map<Booking>(booking);
            var data = DataAccessFactory.BookingData().Update(bookings);

            if (data != null) return mapper.Map<BookingDTO>(data);
            return null;
        }

        public static bool Delete(int Id)
        {
            var data = DataAccessFactory.BookingData().Delete(Id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Booking, BookingDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<bool>(data);
            return mapped;
        }
    }
}
