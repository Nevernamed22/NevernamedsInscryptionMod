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
    static class Baboon
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Baboon",
                "Baboon",
                2,
                2,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, },
                CardTemple.Nature,
                description: "Far more vicious than its name and appearance would betray- it needs only a reason to strike.",
                bloodCost: 0,
                bonesCost: 6,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/baboon.png"),
                abilities: new List<Ability>() { Spurred.ability },
                tribes: new List<Tribe>() { },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/baboon_emission.png")
                );
        }
    }
}
