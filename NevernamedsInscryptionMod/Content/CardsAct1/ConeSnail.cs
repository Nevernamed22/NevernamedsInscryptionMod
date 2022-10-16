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
    static class ConeSnail
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed ConeSnail",
                "Cone Snail",
                1,
                1,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, },
                CardTemple.Nature,
                description: "The venomous cone snail. Beware it's paralysing toxin.",
                bloodCost: 1,
                bonesCost: 0,
                energyCost: 0,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/conesnail.png"),
                abilities: new List<Ability>() { Paralytic.ability },
                tribes: new List<Tribe>() { },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/conesnail_emission.png")
                );
        }
    }
}
