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
    static class Famine
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Famine",
                "Famine",
                0,
                7,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable, CardMetaCategory.Rare },
                CardTemple.Undead,
                description: "",
                bonesCost: 13,
                abilities: new List<Ability>() { Ability.Strafe },
                specialAbilities: new List<SpecialTriggeredAbility>() { Starved.ability, InherentGraveyardShift.ability },
                variableStat: Starved.specialStatIcon,
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/famine_pixel.png"),
                defaultFrozenCard: "Starvation"
                );
        }
    }
}