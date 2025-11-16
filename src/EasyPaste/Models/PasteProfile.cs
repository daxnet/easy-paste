using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace EasyPaste.Models
{
    internal sealed class PasteProfile
    {
        private const string ProfileFileName = "profile.json";

        public List<PasteItem> Items { get; set; } = [];

        public List<PasteItemGroup> Groups { get; set; } =
        [
            new PasteItemGroup(PasteItemGroup.DefaultGroupId, PasteItemGroup.DefaultGroupName, PasteItemGroup.DefaultGroupColorName)
        ];

        public static async Task<PasteProfile> LoadAsync()
        {
            if (!File.Exists(ProfileFileName))
            {
                return new();
            }

            var profileJson = await File.ReadAllTextAsync(ProfileFileName);
            if (profileJson is null)
            {
                return new();
            }

            return JsonSerializer.Deserialize<PasteProfile>(profileJson) ?? new PasteProfile();
        }

        public static async Task SaveAsync(PasteProfile profile)
        {
            var profileJson = JsonSerializer.Serialize(profile);
            if (profileJson is not null)
            {
                await File.WriteAllTextAsync(ProfileFileName, profileJson);
            }
        }

        public void UpdateGroup(PasteItemGroup group)
        {
            foreach (var g in Groups.Where(g => g.Id == group.Id))
            {
                g.Name = group.Name;
                g.ColorName = group.ColorName;
            }
        }
    }
}
