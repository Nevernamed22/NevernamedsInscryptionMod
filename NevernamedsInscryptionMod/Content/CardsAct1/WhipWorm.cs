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
    static class WhipWorm
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed WhipWorm",
                "Whip Worm",
                0,
                1,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, },
                CardTemple.Nature,
                description: "A curious annelid eager to whip your creatures into shape.",
                bloodCost: 1,
                bonesCost: 0,
                energyCost: 0,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/whipworm.png"),
                abilities: new List<Ability>() { AculeateGrip.ability,  Motivator.ability },
                tribes: new List<Tribe>() { },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/whipworm_emission.png")
                );
        }
    }
}
