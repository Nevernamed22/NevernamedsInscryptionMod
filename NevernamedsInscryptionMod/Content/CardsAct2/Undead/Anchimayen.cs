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
    static class Anchimayen
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Anchimayen",
                "Anchimayen",
                0,
                2,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable },
                CardTemple.Undead,
                description: "",
                bloodCost: 0,
                bonesCost: 3,
                energyCost: 0,
                tribes: new List<Tribe>() { },
                abilities: new List<Ability>() { Ability.Flying, Ability.Brittle },
                specialAbilities: new List<SpecialTriggeredAbility>() { DamageScaling.ability },
                variableStat: DamageScaling.specialStatIcon,
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/anchimayen_pixel.png")
                );
        }
    }
}