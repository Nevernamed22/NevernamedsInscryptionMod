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
    static class AmorphousShame
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed AmorphousShame",
                "Amorphous Shame",
                1,
                3,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, },
                CardTemple.Nature,
                description: "...such a shame...",
                bloodCost: 1,
                bonesCost: 1,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/amorphousshame.png"),
                abilities: new List<Ability>() { PunchingBag.ability },
                tribes: new List<Tribe>() {  },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/amorphousshame_emission.png")
                );
        }
    }
}
