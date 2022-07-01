using AutoMapper;
using TodoList.Application.Models;
using TodoList.Core.Entities;

namespace TodoList.Application.Mappings
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
        }
    }
}
