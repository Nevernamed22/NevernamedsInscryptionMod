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
    static class AnnoyingDog
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed AnnoyingDog",
                "Annoying Dog",
                3,
                3,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, },
                CardTemple.Nature,
                description: "That irritating canine...",
                bloodCost: 2,
                bonesCost: 0,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/annoyingdog.png"),
                abilities: new List<Ability>() { Ability.BuffEnemy },
                tribes: new List<Tribe>() { Tribe.Canine },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/annoyingdog_emission.png")
                );
        }
    }
}
