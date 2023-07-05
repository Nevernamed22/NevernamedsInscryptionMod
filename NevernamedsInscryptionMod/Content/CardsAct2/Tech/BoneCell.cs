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
    static class BoneCell
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed BoneCell",
                "Bone Cell",
                2,
                1,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable },
                CardTemple.Tech,
                description: "",
                energyCost: 5,
                abilities: new List<Ability>() { ScavengeWhenPowered.ability },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/bonecell_pixel.png")
                );
        }
    }
}