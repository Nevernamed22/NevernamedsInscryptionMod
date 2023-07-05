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
    static class FileSearcher
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed FileSearcher",
                "File Searcher",
                1,
                1,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable },
                CardTemple.Tech,
                description: "",
                energyCost: 4,
                abilities: new List<Ability>() { Ability.OpponentBones, Harbinger.ability },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/filesearcher_pixel.png")
                );
        }
    }
}