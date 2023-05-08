using APIPlugin;
using DiskCardGame;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using NevernamedsSigils;
using UnityEngine;

namespace NevernamedsInscryptionMod
{
    static class Strigoi
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed StrigoiMort",
                "Strigoi Mort",
                3,
               4,
                new List<CardMetaCategory> { },
                CardTemple.Undead,
                description: "",
                bloodCost: 0,
                bonesCost: 7,
                energyCost: 0,
                tribes: new List<Tribe>() { },
                abilities: new List<Ability>() { TransformerCustom.ability },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/strigoimort_pixel.png"),
                transformerForm: "DeadNevernamed StrigoiViu"
                );

            CardSetupUtility.NewCard("Nevernamed StrigoiViu",
                "Strigoi Viu",
                0,
               4,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable },
                CardTemple.Undead,
                description: "",
                bloodCost: 0,
                bonesCost: 7,
                energyCost: 0,
                tribes: new List<Tribe>() { },
                abilities: new List<Ability>() { TransformerCustom.ability },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/strigoiviu_pixel.png"),
                transformerForm: "DeadNevernamed StrigoiMort"
                );
        }
    }
}