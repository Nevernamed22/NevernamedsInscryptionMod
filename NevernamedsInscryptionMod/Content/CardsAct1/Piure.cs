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
    static class Piure
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Piure",
                "Piure",
                0,
                2,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, },
                CardTemple.Nature,
                description: "To look at it, you would not know it was a beast.",
                bloodCost: 1,
                bonesCost: 0,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/piure.png"),
                abilities: new List<Ability>() { },
                tribes: new List<Tribe>() { },
                specialAbilities: new List<SpecialTriggeredAbility>() { Lithophile.ability },
                variableStat: Lithophile.specialStatIcon,
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/piure_emission.png")
                );
        }
    }
}
