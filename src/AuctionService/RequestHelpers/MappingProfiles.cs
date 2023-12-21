using AuctionService.DTO;
using AuctionService.Entities;
using AutoMapper;

namespace AuctionService.RequestHelpers;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<Auction, AuctionDto>().IncludeMembers(x => x.Item);
        CreateMap<Item, AuctionDto>();
        CreateMap<CreateAuctionDto, Auction>().ForMember(d => d.Item, o => o.MapFrom(s => s));
        CreateMap<AuctionDto, Item>();
        CreateMap<CreateAuctionDto, Item>();
        //CreateMap<AuctionDto, AuctionCreated>();
       // CreateMap<Auction, AuctionUpdated>().IncludeMembers(a => a.Item);
        //CreateMap<Item, AuctionUpdated>();
    }
}