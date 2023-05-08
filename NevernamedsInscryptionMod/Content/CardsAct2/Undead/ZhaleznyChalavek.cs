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
    static class ZhaleznyChalavek
    {
        public static void Init()
        {
            // Add the card
            CardSetupUtility.NewCard("Nevernamed ZhaleznyChalavek",
                "Zhalezny Chalavek",
                5,
                5,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable, CardMetaCategory.Rare },
                CardTemple.Undead,
                description: "",
                bloodCost: 0,
                bonesCost: 6,
                energyCost: 6,
                tribes: new List<Tribe>() { },
                abilities: new List<Ability>() { Ability.MadeOfStone, Ability.StrafeSwap },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/zhaleznychalavek_pixel.png")
                );
        }
    }
}