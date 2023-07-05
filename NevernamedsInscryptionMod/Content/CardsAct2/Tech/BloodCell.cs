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
    static class BloodCell
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed BloodCell",
                "Blood Cell",
                2,
                2,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable },
                CardTemple.Tech,
                description: "",
                energyCost: 4,
                abilities: new List<Ability>() { MorselWhenPowered.ability, Abstain.ability },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/bloodcell_pixel.png")
                );
        }
    }
}