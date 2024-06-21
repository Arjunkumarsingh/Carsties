using AuctionService.DTOs;
using AuctionService.Entities;
using AutoMapper;

namespace AuctionService.RequestHandlers;

public class MappingProfile : Profile
{
    protected MappingProfile()
    {
        CreateMap<Auction, AuctionDto>()
        .IncludeMembers(x => x.Item);

        CreateMap<Item, AuctionDto>();

        CreateMap<CreateAuctionDto, Auction>()
        .ForMember(d => d.Item, o => o.MapFrom(s => s));

        CreateMap<CreateAuctionDto, Item>();
    }
}
