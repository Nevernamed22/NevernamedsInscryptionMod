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
    static class Hammerkop
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Hammerkop",
                "Hammerkop",
               1,
                1,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, },
                CardTemple.Nature,
                description: "The cunning hammerkop, it uses it's sturdy beak to strike down it's own comrades.",
                bloodCost: 1,
                bonesCost: 0,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/hammerkop.png"),
                abilities: new List<Ability>() { Deadbeat.ability },
                tribes: new List<Tribe>() { Tribe.Bird },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/hammerkop_emission.png"),
                defaultEvolutionName: "Silver Bell"
                );
        }
    }
}