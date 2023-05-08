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
    static class PrarieDog
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed PrairieDog",
                "Prairie Dog",
                0,
                3,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, },
                CardTemple.Nature,
                description: "Stern sentinels of the prairies.",
                bonesCost: 3,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/prariedog.png"),
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/prariedog_emission.png"),
                abilities: new List<Ability>() { Ability.WhackAMole },
                tribes: new List<Tribe>() {  }
                );
        }
    }
}