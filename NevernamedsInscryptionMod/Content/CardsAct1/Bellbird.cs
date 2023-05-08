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
    static class Bellbird
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Bellbird",
                "Bellbird",
                0,
                1,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, },
                CardTemple.Nature,
                description: "Their cry is melodic, like the ringing of a great chime.",
                bonesCost: 6,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/bellbird.png"),
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/bellbird_emission.png"),
                abilities: new List<Ability>() { Ability.Flying, Flighty.ability },
                specialAbilities: new List<SpecialTriggeredAbility>() { SpecialTriggeredAbility.BellProximity},
                variableStat: SpecialStatIcon.Bell,
                tribes: new List<Tribe>() { Tribe.Bird }
                );
        }
    }
}