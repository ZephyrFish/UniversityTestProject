using business_logic;

namespace Data.Repositories.Groups;

public interface IGroupRepository : IRepository<Group>
{
    IEnumerable<Group> GetGroupsWithStudents(int page, int size);
}
