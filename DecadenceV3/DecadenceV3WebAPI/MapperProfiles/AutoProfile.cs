using AutoMapper;
using DecadenceV3BLL.DTOs;
using DecadenceV3BLL.ViewModels;
using DecadenceV3DAL.Entities;

namespace DecadenceV3WebAPI.MapperProfiles
{
    public class AutoProfile: Profile
    {
        public AutoProfile()
        {
            CreateMap<Filter, FilterDto>();
            CreateMap<Label, LabelDto>();
            CreateMap<Project , ProjectDto>();
            CreateMap<Project, ProjectViewModel>();
            CreateMap<User, UserDto>();
            CreateMap<WorkItem, WorkItemDto>();
        }
    }
}