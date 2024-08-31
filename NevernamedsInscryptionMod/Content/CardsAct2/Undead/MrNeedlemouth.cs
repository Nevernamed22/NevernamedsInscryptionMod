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
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable, Plugin.GrimoraChoiceNode },
                CardTemple.Undead,
                description: "Many careful teeth to pick clean even the sinewiest deplorables...",
                bloodCost: 0,
                bonesCost: 6,
                energyCost: 0,
                tribes: new List<Tribe>() { },
                abilities: new List<Ability>() { PickyEater.ability },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/CardsGrimora/mrneedlemouth.png"),
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/CardsGrimora/mrneedlemouth_emission.png"),
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/mrneedlemouth_pixel.png")
                );
        }
    }
}