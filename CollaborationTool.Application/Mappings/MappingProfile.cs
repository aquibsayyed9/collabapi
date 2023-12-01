using AutoMapper;
using CollaborationTool.Application.DTOs;
using CollaborationTool.Domain.Entities;

namespace CollaborationTool.Application.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // User mappings
            CreateMap<User, UserDto>()
                .ForMember(dto => dto.UserId, opt => opt.MapFrom(entity => entity.UserId))
                .ForMember(dto => dto.Username, opt => opt.MapFrom(entity => entity.Username))
                .ForMember(dto => dto.Email, opt => opt.MapFrom(entity => entity.Email));
            // Add reverse mapping if necessary
            // .ReverseMap();

            // Document mappings
            CreateMap<Document, DocumentDto>()
                .ForMember(dto => dto.DocumentId, opt => opt.MapFrom(entity => entity.DocumentId))
                .ForMember(dto => dto.Title, opt => opt.MapFrom(entity => entity.Title))
                .ForMember(dto => dto.Content, opt => opt.MapFrom(entity => entity.Content))
                .ForMember(dto => dto.UserId, opt => opt.MapFrom(entity => entity.UserId));
            // .ReverseMap();

            // CollaborationSession mappings
            CreateMap<CollaborationSession, CollaborationSessionDto>()
                .ForMember(dto => dto.SessionId, opt => opt.MapFrom(entity => entity.SessionId))
                .ForMember(dto => dto.StartTime, opt => opt.MapFrom(entity => entity.StartTime))
                .ForMember(dto => dto.EndTime, opt => opt.MapFrom(entity => entity.EndTime))
                .ForMember(dto => dto.DocumentId, opt => opt.MapFrom(entity => entity.DocumentId));
            // .ReverseMap();
        }
    }
}