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
    static class Scapegoat
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Scapegoat",
                "Scapegoat",
                1,
                1,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, },
                CardTemple.Nature,
                description: "The unruly scapegoat. It fights, and struggles- yet it bleeds all the same...",
                bonesCost: 4,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/scapegoat.png"),
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/scapegoat_emission.png"),
                abilities: new List<Ability>() { Ability.TripleBlood },
                traits: new List<Trait>() { Trait.Goat },
                tribes: new List<Tribe>() { Tribe.Hooved }
                );
        }
    }
}