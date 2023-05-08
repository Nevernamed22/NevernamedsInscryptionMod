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
    static class Candiru
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Candiru",
                "Candiru",
               2,
                1,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, },
                CardTemple.Nature,
                description: "A bloodsucking fish with a terrifying reputation.",
                bloodCost: 2,
                bonesCost: 0,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/candiru.png"),
                abilities: new List<Ability>() { Ability.Strafe, Vampiric.ability },
                tribes: new List<Tribe>() {  },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/candiru_emission.png")
                );
        }
    }
}