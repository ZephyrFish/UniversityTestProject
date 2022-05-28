using business_logic;

using Data.DataAccess;

using Microsoft.EntityFrameworkCore;

namespace Data.Repositories.Groups;

public class GroupRepository : Repository<Group>, IGroupRepository
{
    public GroupRepository(UniversityContext context) : base(context)
    {

    }

    public IEnumerable<Group> GetGroupsWithStudents(int page, int size)
    {
        return UniversityContext.Group
            .Include(g => g.Students)
            .OrderBy(g => g.Number)
            .Skip(page * size)
            .Take(size)
            .ToList();
    }

    public UniversityContext UniversityContext  => (_context as UniversityContext)!;
}
