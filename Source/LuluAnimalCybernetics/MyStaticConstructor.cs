using RimWorld;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using Verse;

namespace LoonyLadle.AnimalCybernetics
{
	[StaticConstructorOnStartup]
	public static class MyStaticConstructor
	{
		static MyStaticConstructor()
		{
			IEnumerable<RecipeDef> surgeries = DefDatabase<RecipeDef>.AllDefs.Where(r => r.IsSurgery);
			IEnumerable<ThingDef> animals = DefDatabase<ThingDef>.AllDefs.Where(t => t.race?.Animal ?? false);
			StringBuilder stringBuilder = new StringBuilder("[LuluAnimalCybernetics] Dynamic patched the following defs: ");
			bool first = true;

			foreach (RecipeDef surgery in surgeries)
			{
				if (!surgery.HasModExtension<DisallowAnimalsExt>() && surgery.AllRecipeUsers.Contains(ThingDefOf.Human) && !surgery.AllRecipeUsers.Contains(ThingDefOf.Muffalo))
				{
					if (surgery.recipeUsers == null) surgery.recipeUsers = new List<ThingDef>();
					surgery.recipeUsers.AddRange(animals);

					if (first)
					{
						stringBuilder.Append(surgery.defName);
						first = false;
					}
					else
					{
						stringBuilder.AppendWithComma(surgery.defName);
					}

				}
			}
			foreach (ThingDef animal in animals)
			{
				// Clear recipe cache; shouldn't be necessary unless other mods have forced it to be created somehow.
				typeof(ThingDef).GetField("allRecipesCached", BindingFlags.NonPublic | BindingFlags.Instance).SetValue(animal, null);
			}
			Log.Message(stringBuilder.ToString());
		}
	}
}
