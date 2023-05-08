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
    static class Buzzard
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Buzzard",
                "Buzzard",
                1,
                4,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, },
                CardTemple.Nature,
                description: "The shameless buzzard- an inescapable symbol of death in the sands.",
                bloodCost: 2,
                bonesCost: 0,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/buzzard.png"),
                abilities: new List<Ability>() { Ability.Flying, Ability.CorpseEater },
                tribes: new List<Tribe>() { Tribe.Bird },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/buzzard_emission.png")
                );
        }
    }
}