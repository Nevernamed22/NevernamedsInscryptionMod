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
    static class Cockle
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Cockle",
                "Cockle",
                0,
                1,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, },
                CardTemple.Nature,
                description: "The unremarkable cockle, it feeds upon the remnants of the dead...",
                bloodCost: 0,
                bonesCost: 2,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/cockle.png"),
                abilities: new List<Ability>() { FilterFeeder.ability },
                tribes: new List<Tribe>() { },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/cockle_emission.png"),
                defaultEvolutionName: "Silver Bell"
                );
        }
    }
}