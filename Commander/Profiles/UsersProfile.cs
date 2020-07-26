using AutoMapper;
using Commander.Entities;
using Commander.Models;
using Commander.Models.Users;

namespace Commander.Helpers
{
    public class UsersProfile : Profile
    {
        public UsersProfile()
        {
            CreateMap<User, UserModel>();
            CreateMap<RegisterModel, User>();
            CreateMap<UpdateModel, User>();
        }
    }
}