using AutoMapper;
using WoMakersCode.ToDoList.Application.Models;
using WoMakersCode.ToDoList.Core.Entities;

namespace WoMakersCode.ToDoList.Application.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<TaskRequest, TaskDetail>()
                .ForMember(dest => dest.IdTaskList, fonte => fonte.MapFrom(src => src.IdTaskList))
                .ForMember(dest => dest.Executado, fonte => fonte.MapFrom(src => src.Executado))
                .ForMember(dest => dest.DataHora, fonte => fonte.MapFrom(src => src.DataHora))
                .ForMember(dest => dest.Descricao, fonte => fonte.MapFrom(src => src.Descricao));

            CreateMap<TaskListRequest, TaskList>()
                .ForMember(dest => dest.ListName, fonte => fonte.MapFrom(src => src.ListName));

            CreateMap<TaskList, TaskListResponse>()
                .ForMember(dest => dest.ListName, fonte => fonte.MapFrom(src => src.ListName))
                .ForMember(dest => dest.Id, fonte => fonte.MapFrom(src => src.Id));

            CreateMap<TaskList, GetByIdResponse>()
                .ForMember(dest => dest.ListName, fonte => fonte.MapFrom(src => src.ListName))
                .ForMember(dest => dest.Id, fonte => fonte.MapFrom(src => src.Id))
                .ForMember(dest => dest.Tasks, fonte => fonte.MapFrom(src => src.Details));

            CreateMap<TaskDetail, TaskResponse>()
                .ForMember(dest => dest.DataHora, fonte => fonte.MapFrom(src => src.DataHora))
                .ForMember(dest => dest.Executado, fonte => fonte.MapFrom(src => src.Executado))
                .ForMember(dest => dest.Id, fonte => fonte.MapFrom(src => src.Id))
                .ForMember(dest => dest.Descricao, fonte => fonte.MapFrom(src => src.Descricao));

            CreateMap<TaskListRequest, TaskList>()
                .ForMember(dest => dest.ListName, fonte => fonte.MapFrom(src => src.ListName));

            CreateMap<InsertAlarmRequest, Alarm>()
                .ForMember(dest => dest.DataHora, fonte => fonte.MapFrom(src => src.DataHora))
                .ForMember(dest => dest.IdTaskDetail, fonte => fonte.MapFrom(src => src.IdTaskDetail));
        }
    }
}
