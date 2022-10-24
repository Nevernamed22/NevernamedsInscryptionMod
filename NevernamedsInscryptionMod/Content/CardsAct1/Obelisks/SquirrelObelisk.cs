using APIPlugin;
using DiskCardGame;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;
using NevernamedsSigils;

namespace NevernamedsInscryptionMod
{
    static class SquirrelObelisk
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed SquirrelObelisk",
                "Squirrel Obelisk",
                0,
                2,
                new List<CardMetaCategory> { },
                CardTemple.Nature,
                description: "An ominous standing stone, tended by a small cluster of squirrels.",
                bloodCost: 0,
                bonesCost: 3,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/Obelisks/squirrelobelisk.png"),
                abilities: new List<Ability>() { FriendshipBond.ability, Ability.MadeOfStone },
                traits: new List<Trait>() { NevernamedsTraits.Obelisk,  Trait.Terrain },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/Obelisks/squirrelobelisk_emission.png"),
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.TerrainBackground },
                preventSigilVictim: true,
                preventCampfire: true
                );
        }
    }
}
