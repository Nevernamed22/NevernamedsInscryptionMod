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
    static class MrNeedlemouth
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed MrNeedlemouth",
                "Mr Needlemouth",
                1,
                2,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable },
                CardTemple.Undead,
                description: "",
                bloodCost: 0,
                bonesCost: 6,
                energyCost: 0,
                tribes: new List<Tribe>() { },
                abilities: new List<Ability>() { PickyEater.ability },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/mrneedlemouth_pixel.png")
                );
        }
    }
}