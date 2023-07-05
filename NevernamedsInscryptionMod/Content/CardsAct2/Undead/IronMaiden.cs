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
    static class IronMaiden
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed IronMaiden",
                "Iron Maiden",
               0,
                2,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable, CardMetaCategory.Rare },
                CardTemple.Undead,
                description: "",
                bonesCost: 6,
                abilities: new List<Ability>() { BloodBorn.ability },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/ironmaiden_pixel.png"),
                bloodbornForm: "DeadNevernamed IronMaiden2"
                );

            CardSetupUtility.NewCard("Nevernamed IronMaiden2",
                "Iron Maiden", 1, 3,
                new List<CardMetaCategory> { CardMetaCategory.Rare },CardTemple.Undead,description: "",bonesCost: 6,
                abilities: new List<Ability>() { BloodBorn.ability, Ability.Strafe },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/ironmaiden2_pixel.png"),
                bloodbornForm: "DeadNevernamed IronMaiden3"
                );

            CardSetupUtility.NewCard("Nevernamed IronMaiden3",
                "Iron Maiden", 2, 4,
                new List<CardMetaCategory> { CardMetaCategory.Rare }, CardTemple.Undead, description: "", bonesCost: 6,
                abilities: new List<Ability>() { BloodBorn.ability, Ability.StrafePush },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/ironmaiden3_pixel.png"),
                bloodbornForm: "DeadNevernamed IronMaiden4"
                );

            CardSetupUtility.NewCard("Nevernamed IronMaiden4",
                "Iron Maiden", 3, 5,
                new List<CardMetaCategory> { CardMetaCategory.Rare }, CardTemple.Undead, description: "", bonesCost: 6,
                abilities: new List<Ability>() { BloodBorn.ability, Ability.StrafeSwap },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/ironmaiden4_pixel.png"),
                bloodbornForm: "DeadNevernamed IronMaiden5"
                );

            CardSetupUtility.NewCard("Nevernamed IronMaiden5",
                "Iron Maiden", 4, 6,
                new List<CardMetaCategory> { CardMetaCategory.Rare }, CardTemple.Undead, description: "", bonesCost: 6,
                abilities: new List<Ability>() { Ability.StrafeSwap },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/ironmaiden5_pixel.png")
                );


        }
    }
}