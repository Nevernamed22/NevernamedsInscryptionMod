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
    static class Gibbon
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Gibbon",
                "Gibbon",
                1,
                1,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, },
                CardTemple.Nature,
                description: "The craft Gibbon. It uses it's long arms to attack from wherever it is on the board.",
                bloodCost: 0,
                bonesCost: 4,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/gibbon.png"),
                abilities: new List<Ability>() { OddStrike.ability },
                tribes: new List<Tribe>() {  },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/gibbon_emission.png")
                );
        }
    }
}