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
    static class Pidgeon
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Pidgeon",
                "Pidgeon",
                1,
                4,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, },
                CardTemple.Nature,
                description: "A rat, taken flight.",
                bonesCost: 5,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/pidgeon.png"),
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/pidgeon_emission.png"),
                abilities: new List<Ability>() { Ability.Flying, Flighty.ability },
                tribes: new List<Tribe>() { Tribe.Bird }
                );
        }
    }
}