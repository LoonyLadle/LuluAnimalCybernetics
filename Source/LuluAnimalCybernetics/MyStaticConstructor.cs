using RimWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
				if (surgery.AllRecipeUsers.Contains(ThingDefOf.Human) && !surgery.AllRecipeUsers.Contains(ThingDefOf.Dromedary))
				{
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
			Log.Message(stringBuilder.ToString());
		}
	}
}
