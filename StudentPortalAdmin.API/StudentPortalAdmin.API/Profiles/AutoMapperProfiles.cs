using System;
using AutoMapper;
using DataModel = StudentPortalAdmin.API.DataModel;
using StudentPortalAdmin.API.DomainModels;

namespace StudentPortalAdmin.API.Profiles
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<DataModel.Student, Student>().ReverseMap();
            CreateMap<DataModel.Gender, Gender>().ReverseMap();
            CreateMap<DataModel.Address, Address>().ReverseMap();
        }
    }
}

