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
    static class Masok
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Masok",
                "Masok",
                1,
                2,
                new List<CardMetaCategory> { CardMetaCategory.Rare },
                CardTemple.Nature,
                description: "01101000 01100101 01101100 01101100 01101111 00100000 00111010 00101001 ",
                bloodCost: 2,
                bonesCost: 0,
                abilities: new List<Ability>() { TripleStrike.ability },
                traits: new List<Trait>() { },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/masok.png"),
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.RareCardBackground, },
                tribes: new List<Tribe>() { NevernamedsTribes.Arachnid },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/masok_emission.png"),
                preventSigilVictim: true
                );
        }
    }
}