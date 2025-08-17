using System.Reflection;
using WHQCore.Models;

namespace WHQCore.Helpers
{
    public static class TreasureLibraryHelper
    {
        /// <summary>
        /// Gets all MagicItemData entries from a static library class using reflection.
        /// </summary>
        public static IEnumerable<MagicItemData> GetAllItemsFromLibrary(Type libraryType)
        {
            if (!libraryType.IsAbstract || !libraryType.IsSealed) // static class check
                throw new ArgumentException($"{libraryType.Name} must be a static class.");

            return libraryType
                .GetProperties(BindingFlags.Public | BindingFlags.Static)
                .Where(p => p.PropertyType == typeof(MagicItemData))
                .Select(p => (MagicItemData)p.GetValue(null))
                .Where(item => item != null);
        }

        /// <summary>
        /// Gets an item from a library by its D66 table result.
        /// </summary>
        public static MagicItemData? GetByD66(Type libraryType, string d66Result)
        {
            return GetAllItemsFromLibrary(libraryType)
                .FirstOrDefault(i => i.TreasureTableDiceResult == d66Result);
        }
    }
}