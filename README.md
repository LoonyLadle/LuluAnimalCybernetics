# Lulu's Animal Cybernetics
Allows installing of vanilla cybernetics on animals.

## There's a lot of animal cybernetics mods; what makes this one different?
Through the magic of patching, Lulu's Animal Cybernetics allows the installation of _vanilla_ cybernetics on animals with _vanilla_ recipes; absolutely no new defs are added! This means Lulu's Animal Cybernetics is (theoretically) completely safe to add or remove from a game in progress, guaranteed to match vanilla balance, inherently compatible with all animal mods, and should not break on a RimWorld update barring a dramatic change in def structure.

## Compatibility
Any mod that adds additional surgery recipes or animals with new body parts will require a compatibility patch to make their additions accessable to Lulu's Animal Cybernetics. Is your favorite mod not supported? Open an issue!

* Vanilla Bionics Extension: fully supported! (2018-12-14)

## Technical Details
Lulu's Animal Cybernetics functions by adding (almost) all installation recipes found on humans to the recipes of AnimalThingBase, which all animals inherit from. Additionally, all surgeries are patched to be applicable to "equivalent" body parts (so that dentures can be applied to an AnimalJaw, SnakeMouth, etc). Everything this mod does is achieved with a single, relatively small patch file.

## Why did I make this mod?
I was frustrated with A Dog Said and Cyber Fauna for being balanced against Expanded Prosthetics and Organ Engineering, presumably out of a mistaken impression that everyone likes that mod. I do not, and wished for a minimalistic vanilla-like way to add peg legs and dentures to my wounded war animals. When I realized how easy it was to make such a mod, I expanded it to include all cybernetics and released it in the hope others would find it useful.
