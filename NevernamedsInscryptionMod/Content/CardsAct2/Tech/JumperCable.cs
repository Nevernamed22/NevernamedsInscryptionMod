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
    static class JumperCable
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed JumperCable",
                "Jumper Cable",
                0,
                1,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable },
                CardTemple.Tech,
                description: "",
                energyCost: 2,
                abilities: new List<Ability>() { Ability.Reach, CallToArms.ability },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/jumpercable_pixel.png")
                );
        }
    }
}