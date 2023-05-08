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
    static class VampireBat
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed VampireBat",
                "Vampire Bat",
                1,
                2,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, },
                CardTemple.Nature,
                description: "The docile Vampire Bat. Though sweet, it inevitably will require... sustenance.",
                bloodCost: 0,
                bonesCost: 4,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/vampirebat.png"),
                abilities: new List<Ability>() { Ability.Flying, Gorge.ability },
                tribes: new List<Tribe>() { },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/vampirebat_emission.png")
                );
        }
    }
}
