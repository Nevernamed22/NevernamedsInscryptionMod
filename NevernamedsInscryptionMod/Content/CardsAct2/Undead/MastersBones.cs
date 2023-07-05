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
    static class MastersBones
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed MastersBones",
                "Masters Bones",
               2,
                3,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable, CardMetaCategory.Rare },
                CardTemple.Undead,
                description: "",
                bonesCost: 6,
                abilities: new List<Ability>() { ElderConduit.ability },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/mastersbones_pixel.png")
                );
        }
    }
}