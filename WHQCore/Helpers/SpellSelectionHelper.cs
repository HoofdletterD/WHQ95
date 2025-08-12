using WHQCore.Models;
using WHQCore.Models.Enums;
using WHQCore.Spells;

namespace WHQCore.Helpers;

public class SpellSelectionHelper
{
    public static readonly List<Spell> StartingSpells =
    [
        SpellLibrary.Fireball,
        SpellLibrary.Freeze,
        SpellLibrary.LightningBolt,
        SpellLibrary.OgreStrength,
        SpellLibrary.Levitate,
        SpellLibrary.Rebound,
        SpellLibrary.Shield,
        SpellLibrary.IronSkin,
        SpellLibrary.Confuse,
        SpellLibrary.HealWounds,
        SpellLibrary.HealingHands,
        SpellLibrary.LifeForce,
        SpellLibrary.Lifebringer,
        SpellLibrary.Resurrection
    ];

    public static readonly List<Spell> StartingAttackSpells =
        StartingSpells.Where(s => s.SpellTypes.Contains(SpellType.Attack)).ToList();

    public static readonly List<Spell> StartingDefensiveSpells =
        StartingSpells.Where(s => s.SpellTypes.Contains(SpellType.Defensive)).ToList();

    public static readonly List<Spell> StartingHealingSpells =
        StartingSpells.Where(s => s.SpellTypes.Contains(SpellType.Healing)).ToList();

    public static IEnumerable<Spell> AllSpells()
    {
        var list = new List<Spell>
        {
            // casting 1
            SpellLibrary.Bloodblade,
            SpellLibrary.Sting,
            SpellLibrary.Coughing,
            SpellLibrary.Drop,
            SpellLibrary.CreateFood,
            SpellLibrary.CureSmallWounds,
            SpellLibrary.FleetOfFoot,
            SpellLibrary.Open,
            // casting 2
            SpellLibrary.FleshWorm,
            SpellLibrary.Strength,
            SpellLibrary.FeignDeath,
            SpellLibrary.MarshLights,
            SpellLibrary.Nausea,
            SpellLibrary.Slip,
            SpellLibrary.HealingHands,
            SpellLibrary.Tongues,
            SpellLibrary.ZoneOfSilence,
            // casting 3
            SpellLibrary.FistOfIron,
            SpellLibrary.IceBlades,
            SpellLibrary.OgreStrength,
            SpellLibrary.Confuse,
            SpellLibrary.GlitteringRobe,
            SpellLibrary.FingerOfLife,
            SpellLibrary.Speed,
            // casting 4
            SpellLibrary.AcidBlast,
            SpellLibrary.IceTomb,
            SpellLibrary.LightningBolt,
            SpellLibrary.Levitate,
            SpellLibrary.Rebound,
            SpellLibrary.HealWounds,
            SpellLibrary.DispelMagic,
            SpellLibrary.SecondSight,
            // casting 5
            SpellLibrary.Fireball,
            SpellLibrary.Firehammer,
            SpellLibrary.Freeze,
            SpellLibrary.PitOfDespair,
            SpellLibrary.Blur,
            SpellLibrary.Dazzle,
            SpellLibrary.IronSkin,
            SpellLibrary.LifeForce,
            SpellLibrary.Lifebringer,
            SpellLibrary.Invisibility,
            SpellLibrary.Sleep,
            // casting 6
            SpellLibrary.Cataclysm,
            SpellLibrary.SwordsOfDoom,
            SpellLibrary.Weaponmaster,
            SpellLibrary.Invulnerability,
            SpellLibrary.Shield,
            SpellLibrary.Resurrection,
            SpellLibrary.CauseAnimosity,
            SpellLibrary.CreateBridge,
            SpellLibrary.WingsOfPower,
            // casting 7
            SpellLibrary.BurningStorm,
            SpellLibrary.ChainLightning,
            SpellLibrary.DomeOfPower,
            SpellLibrary.FoolsGold,
            SpellLibrary.Bloodpulse,
            SpellLibrary.Glory,
            SpellLibrary.TimeFreeze,
            SpellLibrary.WarpJump,
            // casting 8
            SpellLibrary.Hellbeast,
            SpellLibrary.SpearOfLight,
            SpellLibrary.CageOfStone,
            SpellLibrary.HaloOfVengeance,
            SpellLibrary.Voidmaster,
            SpellLibrary.ChorusOfValour,
            // casting 9
            SpellLibrary.Lifestealer,
            SpellLibrary.HoundsOfGrimnair,
            // casting 10
            SpellLibrary.Windblast,
            SpellLibrary.RadianceOfPtolos,
            SpellLibrary.Heartbeat,
            SpellLibrary.WindsOfFate,
            // casting 11
            SpellLibrary.CarnivalOfDeath,
            SpellLibrary.WindowOfTheVoid,
            SpellLibrary.TissueOfLife,
            SpellLibrary.TowerOfIsolation,
            // casting 12
            SpellLibrary.Firestorm,
            SpellLibrary.Transmute,
            SpellLibrary.VortexOfDestruction,
            SpellLibrary.TransportOfTheDamned
        };
        return list;
    }

    public static IEnumerable<Spell> GetSpellsByCastingNumber(string castingNumber)
    {
        return AllSpells().Where(s => s.CastingNumber == castingNumber);
    }

    public static Spell? GetSpellByValue(string value)
    {
        return AllSpells().FirstOrDefault(s => s.CastingNumber == value);
    }

    public static List<List<int>> GenerateCastingNumberCombinations(List<int> diceRolls)
    {
        var results = new List<List<int>>();
        GenerateCombinationsRecursive(diceRolls, new List<int>(), results);
        return results;
    }

    private static void GenerateCombinationsRecursive(List<int> remainingDice, List<int> current, List<List<int>> results)
    {
        if (remainingDice.Count == 0)
        {
            results.Add(new List<int>(current));
            return;
        }

        // Try all group sizes from 1 up to remainingDice.Count
        for (var i = 1; i <= remainingDice.Count; i++)
        {
            var group = remainingDice.Take(i).ToList();
            var sum = group.Sum();

            var nextRemaining = remainingDice.Skip(i).ToList();
            var nextCurrent = new List<int>(current) { sum };

            GenerateCombinationsRecursive(nextRemaining, nextCurrent, results);
        }
    }
}