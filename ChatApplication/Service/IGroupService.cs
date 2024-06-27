using ChatApp.Dto;

public interface IGroupService
{
    Task<ResultDto> CreateGroup(GroupDto groupDto);
    Task<GroupDto> GetGroupById(int groupId);
    Task<List<GroupDto>> GetAllGroups();
    Task<ResultDto> UpdateGroup(GroupDto groupDto);
    Task<ResultDto> DeleteGroup(int groupId);
}
