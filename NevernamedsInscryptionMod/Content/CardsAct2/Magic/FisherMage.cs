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
    static class FisherMage
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed FisherMage",
                "Fisher Mage",
                1,
                1,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable, CardMetaCategory.Rare },
                CardTemple.Wizard,
                description: "",
                bloodCost: 0,
                gemsCost: new List<GemType>() { GemType.Orange },
                bonesCost: 0,
                tribes: new List<Tribe>() { },
                abilities: new List<Ability>() { HookLineAndSinker.ability },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/fishermage_pixel.png")
                );
        }
    }
}