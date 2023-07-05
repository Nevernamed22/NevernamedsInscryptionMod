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
    static class GemFrog
    {
        public static void Init()
        {
          CardInfo inf =  CardSetupUtility.NewCard("Nevernamed GemFrog",
                "Gem Frog",
                1,
                1,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable },
                CardTemple.Nature,
                description: "",
                bloodCost: 1,
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/gemfrog_pixel.png"),
                abilities: new List<Ability>() { Ability.Reach },
                tribes: new List<Tribe>() { Tribe.Reptile }
                );
            inf.Mods.Add(new CardModificationInfo() { gemify = true });
        }
    }
}