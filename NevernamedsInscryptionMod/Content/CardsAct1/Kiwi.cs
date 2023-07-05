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
    static class Kiwi
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Kiwi",
                "Kiwi",
                1,
               1,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, },
                CardTemple.Nature,
                description: "The small, round kiwi. It lurks on the forest floor, scavenging for bugs.",
                bloodCost: 0,
                bonesCost: 3,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/kiwi.png"),
                abilities: new List<Ability>() { Insectivore.ability },
                tribes: new List<Tribe>() { Tribe.Bird },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/kiwi_emission.png")
                );
        }
    }
}
