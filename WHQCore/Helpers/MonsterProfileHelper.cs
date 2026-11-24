using WHQCore.Monsters;
using WHQCore.Monsters.MonsterProfiles;

namespace WHQCore.Helpers;

public static class MonsterProfileHelper
{
    public static MonsterProfile GetById(string id)
    {
        var profile = CoreMonsterProfiles.Profiles
            .FirstOrDefault(p => p.Id == id);

        if (profile is null)
        {
            throw new InvalidOperationException(
                $"Monster profile '{id}' was not found.");
        }

        return profile;
    }

    public static bool Exists(string id)
    {
        return CoreMonsterProfiles.Profiles
            .Any(p => p.Id == id);
    }

    public static IReadOnlyList<MonsterProfile> GetAll()
    {
        return CoreMonsterProfiles.Profiles;
    }
}