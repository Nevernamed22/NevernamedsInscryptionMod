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
    static class FrogR
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed FrogR",
                "Frog-R",
                1,
                2,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable },
                CardTemple.Tech,
                description: "",
                energyCost: 4,
                abilities: new List<Ability>() { Obedient.ability, Ability.Reach },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/frogr_pixel.png")
                );
        }
    }
}