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
    static class BloodKnight
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed BloodKnight",
                "Blood Knight",
                0,
                5,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable },
                CardTemple.Wizard,
                description: "",
                gemsCost: new List<GemType>() { GemType.Green, GemType.Orange },
                tribes: new List<Tribe>() { },
                variableStat: SpecialStatIcon.GreenGems,
                specialAbilities: new List<SpecialTriggeredAbility>() { SpecialTriggeredAbility.GreenMage },
                abilities: new List<Ability>() { Bloodrunner.ability, },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/bloodknight_pixel.png")
                );
        }
    }
}