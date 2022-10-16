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
    static class RedMite
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed RedMite",
                "Red Mite",
                0,
                1,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, },
                CardTemple.Nature,
                description: "The viciously toxic red mite. Not for consumption.",
                bloodCost: 0,
                bonesCost: 2,
                energyCost: 0,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/redmite.png"),
                abilities: new List<Ability>() { Abstain.ability, Caustic.ability },
                tribes: new List<Tribe>() { NevernamedsTribes.Arachnid },
                traits: new List<Trait>() { Trait.KillsSurvivors },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/redmite_emission.png")
                );
        }
    }
}
