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
    static class EarlyBird
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed EarlyBird",
                "Early Bird",
                1,
                4,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, },
                CardTemple.Nature,
                description: "The early bird. It's effectiveness tapers off the longer it remains on the board.",
                bloodCost: 2,
                bonesCost: 0,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/earlybird.png"),
                abilities: new List<Ability>() { Ability.Flying, Eager.ability },
                tribes: new List<Tribe>() { Tribe.Bird },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/earlybird_emission.png")
                );
        }
    }
}