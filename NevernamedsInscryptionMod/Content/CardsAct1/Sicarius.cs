using APIPlugin;
using DiskCardGame;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;
using NevernamedsSigils;
using InscryptionAPI.Card;

namespace NevernamedsInscryptionMod
{
    static class Sicarius
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Sicarius",
                "Sicarius",
                2,
                2,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, },
                CardTemple.Nature,
                description: "The crafty sicarius spider... it buries itself beneath the sand for protection.",
                bloodCost: 2,
                bonesCost: 0,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/sicarius.png"),
                abilities: new List<Ability>() { Obedient.ability, TransformerCustom.ability },
                tribes: new List<Tribe>() { NevernamedsTribes.Arachnid },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/sicarius_emission.png")
                ).SetExtendedProperty("CustomTransformerTransformation", "BeastNevernamed SicariusBuried");

            CardSetupUtility.NewCard("Nevernamed SicariusBuried",
                "Sicarius",
                0,
                2,
                new List<CardMetaCategory> { },
                CardTemple.Nature,
                description: "The crafty sicarius spider... it buries itself beneath the sand for protection.",
                bloodCost: 2,
                bonesCost: 0,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/sicariusburied.png"),
                abilities: new List<Ability>() { Ability.Sentry, TransformerCustom.ability },
                tribes: new List<Tribe>() { NevernamedsTribes.Arachnid },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/sicariusburied_emission.png")
                ).SetExtendedProperty("CustomTransformerTransformation", "BeastNevernamed Sicarius");
        }
    }
}
