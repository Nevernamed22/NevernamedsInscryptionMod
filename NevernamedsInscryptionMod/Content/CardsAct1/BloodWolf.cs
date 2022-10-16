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
    static class BloodWolf
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed BloodWolf",
                "Blood Wolf",
                3,
                2,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, },
                CardTemple.Nature,
                description: "The bloodstarved beast. It will wither and die if it does not taste violence each turn.",
                bloodCost: 0,
                bonesCost: 4,
                energyCost: 0,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/bloodwolf.png"),
                abilities: new List<Ability>() { BloodDependent.ability },
                tribes: new List<Tribe>() { Tribe.Canine },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/bloodwolf_emission.png")
                );
        }
    }
}
