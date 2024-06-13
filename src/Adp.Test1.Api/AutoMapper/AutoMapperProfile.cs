using Adp.Test1.Api.Models;
using Adp.Test1.Core.Entities;

using AutoMapper;

namespace Adp.Test1.Api.AutoMapper;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        CreateMap<ItemRequest, Item>();
    }
}
