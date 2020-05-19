using RimWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Verse;

namespace LuluAnimalCybernetics
{
	[StaticConstructorOnStartup]
	public static class MyStaticConstructor
	{
		static MyStaticConstructor()
		{
			IEnumerable<RecipeDef> surgeries = DefDatabase<RecipeDef>.AllDefs.Where(r => r.IsSurgery);
			IEnumerable<ThingDef> animals = DefDatabase<ThingDef>.AllDefs.Where(t => t.race.Animal);

			foreach (RecipeDef surgery in surgeries)
			{
				if (surgery.AllRecipeUsers.Contains(ThingDefOf.Human) && !surgery.AllRecipeUsers.Contains(ThingDefOf.Dromedary))
				{
					surgery.recipeUsers.AddRange(animals);
				}
			}
		}
	}
}
