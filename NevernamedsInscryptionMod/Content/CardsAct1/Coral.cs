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
    static class Coral
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Coral",
                "Coral",
                0,
                4,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, },
                CardTemple.Nature,
                description: "A stoic coral colony, akin more to the landscape around it than to any other beast...",
                bloodCost: 1,
                bonesCost: 0,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/coral.png"),
                abilities: new List<Ability>() { Ability.Sharp, BloodFromStone.ability },
                tribes: new List<Tribe>() { },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/coral_emission.png")
                );
        }
    }
}