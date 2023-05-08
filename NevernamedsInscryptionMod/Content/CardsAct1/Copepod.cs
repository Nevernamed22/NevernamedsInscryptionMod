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
    static class Copepod
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Copepod",
                "Copepod",
                0,
                1,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, },
                CardTemple.Nature,
                description: "The unassuming copepod, resilient to the last.",
                bloodCost: 0,
                bonesCost: 4,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/copepod.png"),
                abilities: new List<Ability>() { Ability.Sacrificial, Crunchy.ability },
                tribes: new List<Tribe>() { NevernamedsTribes.Crustacean },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/copepod_emission.png")
                );
        }
    }
}
