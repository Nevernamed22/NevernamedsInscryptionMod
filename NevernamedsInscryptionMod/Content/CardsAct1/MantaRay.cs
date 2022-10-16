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
    static class MantaRay
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed MantaRay",
                "Manta Ray",
                1,
                1,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, },
                CardTemple.Nature,
                description: "The manta ray. Majestic angel of the waters...",
                bloodCost: 1,
                bonesCost: 2,
                //energyCost: 2,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/mantaray.png"),
                abilities: new List<Ability>() { Ability.Submerge, PointNemo.ability },
                tribes: new List<Tribe>() {  },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/mantaray_emission.png")
                );
        }
    }
}
