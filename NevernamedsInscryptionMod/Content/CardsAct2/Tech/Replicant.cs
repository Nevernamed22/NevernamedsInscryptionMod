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
    static class Replicant
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Replicant",
                "Replicant",
                0,
                1,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable, CardMetaCategory.Rare },
                CardTemple.Tech,
                description: "",
                energyCost: 6,
                abilities: new List<Ability>() { Ability.DrawCopy },
                specialAbilities: new List<SpecialTriggeredAbility>() { SpecialTriggeredAbility.Ant },
                variableStat: SpecialStatIcon.Ants,
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/replicant_pixel.png")
                );
        }
    }
}