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
    static class Minnow
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Minnow",
                "Minnow",
                1,
                1,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, },
                CardTemple.Nature,
                description: "The small minnow. Though it hides well, predators will always find it in the end...",
                bloodCost: 0,
                bonesCost: 4,
                //energyCost: 4,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/minnow.png"),
                abilities: new List<Ability>() { Ability.Submerge, Ability.Morsel },
                tribes: new List<Tribe>() { },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/minnow_emission.png")
                );
        }
    }
}
