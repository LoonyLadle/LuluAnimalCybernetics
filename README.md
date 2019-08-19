# Lulu's Animal Cybernetics
Allows installing of vanilla cybernetics on animals.

## There's a lot of animal cybernetics mods; what makes this one different?
Through the magic of patching, Lulu's Animal Cybernetics allows the installation of _vanilla_ cybernetics on animals with _vanilla_ recipes; absolutely no new defs are added! This means Lulu's Animal Cybernetics is (theoretically) completely safe to add or remove from a game in progress, guaranteed to match vanilla balance, inherently compatible with all animal mods, and should not break on a RimWorld update barring a dramatic change in def structure.

## Compatibility
Any mod that adds additional surgery recipes or animals with new body parts will require a compatibility patch to make their additions accessible to Lulu's Animal Cybernetics. Is your favorite mod not supported? Open an issue!

* (Recommended) [Lulu's More Surgeries](https://github.com/LoonyLadle/LuluMoreSurgeries): supported externally!
* (Recommended) [Lulu's Vanilla Surgery Expansion](https://github.com/LoonyLadle/LuluVanillaSurgeryExpansion): supported externally!
* [Archotech Expanded](https://steamcommunity.com/sharedfiles/filedetails/?id=1442734859) (and its derivatives, *probably*): supported internally! (2019-08-19)
* [Cybernetic Organism and Neural Network](https://steamcommunity.com/sharedfiles/filedetails/?id=1767214408): supported internally! (2019-08-19)
* [Expanded Prosthetics and Organ Engineering](https://steamcommunity.com/sharedfiles/filedetails/?id=725956940): supported internally! (2019-08-19)
* [Glitter Tech](https://steamcommunity.com/sharedfiles/filedetails/?id=725576127): supported internally! (2019-08-19)
* [Medical System Expansion](https://steamcommunity.com/sharedfiles/filedetails/?id=1749027802): supported internally! (2019-08-19)
* [Rah's Bionics and Surgery Expansion](https://steamcommunity.com/sharedfiles/filedetails/?id=850429707) (and hardcore edition): supported internally! (2019-08-19)
* [Vanilla Bionics Extension](https://steamcommunity.com/sharedfiles/filedetails/?id=1419675146): supported internally! (2018-12-14)

## Technical Details
Lulu's Animal Cybernetics functions by adding (almost) all installation recipes found on humans to the recipes of AnimalThingBase, which all animals inherit from. Additionally, all surgeries are patched to be applicable to "equivalent" body parts (so that dentures can be applied to an AnimalJaw, SnakeMouth, etc). Everything this mod does is achieved with a single, relatively small patch file.

## Why did I make this mod?
I was frustrated with A Dog Said and Cyber Fauna for being balanced against Expanded Prosthetics and Organ Engineering, presumably out of a mistaken impression that everyone likes that mod. I do not, and wished for a minimalistic vanilla-like way to add peg legs and dentures to my wounded war animals. When I realized how easy it was to make such a mod, I expanded it to include all cybernetics and released it in the hope others would find it useful.

## Acknowledgments
[Trunken](https://steamcommunity.com/profiles/76561198095669661/myworkshopfiles/) for keeping the mod alive during my absence from Steam and creating compatibility patches for many other mods.