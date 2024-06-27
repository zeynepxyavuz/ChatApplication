// GroupService.cs
using AutoMapper;
using ChatApp.Dto;

public class GroupService : IGroupService
{
    private readonly IMapper _mapper;

    public GroupService(IMapper mapper)
    {
        _mapper = mapper;
    }

    public async Task<ResultDto> CreateGroup(GroupDto groupDto)
    {
        // Group oluşturma işlemleri
        // Implementasyonunuza göre grup oluşturma işlemlerini gerçekleştirin
        throw new NotImplementedException();
    }

    public async Task<GroupDto> GetGroupById(int groupId)
    {
        // Grup id'sine göre grup bilgisi getirme işlemi
        // Implementasyonunuza göre grup getirme işlemlerini gerçekleştirin
        throw new NotImplementedException();
    }

    public async Task<List<GroupDto>> GetAllGroups()
    {
        // Tüm grupları getirme işlemi
        // Implementasyonunuza göre tüm grupları getirme işlemlerini gerçekleştirin
        throw new NotImplementedException();
    }

    public async Task<ResultDto> UpdateGroup(GroupDto groupDto)
    {
        // Grup güncelleme işlemi
        // Implementasyonunuza göre grup güncelleme işlemlerini gerçekleştirin
        throw new NotImplementedException();
    }

    public async Task<ResultDto> DeleteGroup(int groupId)
    {
        // Grup silme işlemi
        // Implementasyonunuza göre grup silme işlemlerini gerçekleştirin
        throw new NotImplementedException();
    }
}