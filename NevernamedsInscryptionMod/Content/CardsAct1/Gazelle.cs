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
    static class Gazelle
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Gazelle",
                "Gazelle",
                1,
                6,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, },
                CardTemple.Nature,
                description: "The royal gazelle, it stands in stark challenge to even the most ferocious of predators.",
                bloodCost: 1,
                bonesCost: 3,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/gazelle.png"),
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/gazelle_emission.png"),
                abilities: new List<Ability>() {  },
                tribes: new List<Tribe>() { Tribe.Hooved }
                );
        }
    }
}