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
    static class Pachylemur
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Pachylemur",
                "Pachylemur",
                2,
                4,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer },
                CardTemple.Nature,
                description: "The giant ancient pachylemur... this one was a difficult catch.",
                bloodCost: 3,
                bonesCost: 0,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/pachylemur.png"),
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/pachylemur_emission.png"),
                abilities: new List<Ability>() { DexterStrike.ability },
                tribes: new List<Tribe>() { }
                );
        }
    }
}
