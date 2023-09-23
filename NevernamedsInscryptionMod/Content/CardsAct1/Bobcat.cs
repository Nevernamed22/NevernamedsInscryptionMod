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
    static class Bobcat
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Bobcat",
                "Bobcat",
                1,
                1,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, },
                CardTemple.Nature,
                description: "Often underestimated, the Bobcat will strike the moment it is played.",
                bloodCost: 0,
                bonesCost: 3,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/bobcat.png"),
                abilities: new List<Ability>() { PreemptiveStrike.ability },
                tribes: new List<Tribe>() { },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/bobcat_emission.png")
                );
        }
    }
}
