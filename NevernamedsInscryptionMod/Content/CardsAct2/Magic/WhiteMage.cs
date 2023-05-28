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
    static class WhiteMage
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed WhiteMage",
                "White Mage",
                0,
                1,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable, CardMetaCategory.Rare },
                CardTemple.Wizard,
                description: "",
                bloodCost: 0,
                gemsCost: new List<GemType>() { },
                bonesCost: 0,
                tribes: new List<Tribe>() { },
                variableStat: MagickePower.specialStatIcon,
                specialAbilities: new List<SpecialTriggeredAbility>() { MagickePower.ability },
                abilities: new List<Ability>() { Ability.GemDependant, ArtisticLicense.ability },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/whitemage_pixel.png")
                );
        }
    }
}