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
    static class Mandrake
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Mandrake",
                "Mandrake",
               5,
                2,
                new List<CardMetaCategory> {  },
                CardTemple.Undead,
                description: "",
                bonesCost: 3,
                abilities: new List<Ability>() { BloodDependent.ability },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/mandrake_pixel.png"),
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/CardsGrimora/mandrake.png"),
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/CardsGrimora/mandrake_emission.png")
                );
            CardSetupUtility.NewCard("Nevernamed StrangeBud",
                "Strange Bud",
               0,
                2,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable, Plugin.GrimoraChoiceNode },
                CardTemple.Undead,
                description: "It grows underneath the gallows, greedily lapping up the drippings of the hanged.",
                bonesCost: 3,
                abilities: new List<Ability>() { Twister.ability },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/strangebud_pixel.png"),
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/CardsGrimora/strangebud.png"),
                twisterForm: "DeadNevernamed Mandrake"
                );
        }
    }
}