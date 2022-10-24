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
    static class Trapezia
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Trapezia",
                "Trapezia",
                3,
                1,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, },
                CardTemple.Nature,
                description: "The feisty fighting crab.",
                bloodCost: 2,
                bonesCost: 0,
                energyCost: 0,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/trapezia.png"),
                abilities: new List<Ability>() { CoastGuard.ability },
                tribes: new List<Tribe>() { NevernamedsTribes.Crustacean },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/trapezia_emission.png")
                );
        }
    }
}
