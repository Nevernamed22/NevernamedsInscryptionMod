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
    static class Lobster
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Lobster",
                "Lobster",
               2,
                1,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, },
                CardTemple.Nature,
                description: "Shelled sentinels of the deep, their mighty claws are quick to crush anything outside of their blind spot.",
                bloodCost: 2,
                bonesCost: 0,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/lobster.png"),
                abilities: new List<Ability>() { SplitSentry.ability },
                tribes: new List<Tribe>() { NevernamedsTribes.Crustacean },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/lobster_emission.png")
                );
        }
    }
}