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
    static class Deathstalker
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Deathstalker",
                "Deathstalker",
                1,
                1,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, },
                CardTemple.Nature,
                description: "The deathstalker scorpion. It's tail packs a potent venom.",
                bonesCost: 5,
                //energyCost: 2,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/deathstalker.png"),
                abilities: new List<Ability>() { Ability.Deathtouch },
                tribes: new List<Tribe>() { NevernamedsTribes.Arachnid },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/deathstalker_emission.png")
                );
        }
    }
}