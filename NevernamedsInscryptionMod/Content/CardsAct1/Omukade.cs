using APIPlugin;
using DiskCardGame;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;
using NevernamedsSigils;
using InscryptionAPI.Card;

namespace NevernamedsInscryptionMod
{
    static class Omukade
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Omukade",
                "Omukade",
                3,
                5,
                new List<CardMetaCategory> { CardMetaCategory.Rare },
                CardTemple.Nature,
                description: "Omukade, the dragon eater. Its many legs thrash and writhe and strike out with minds of their own.",
                bloodCost: 3,
                bonesCost: 0,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/omukade.png"),
                abilities: new List<Ability>() { Wriggle.ability,  Writhe.ability },
                 appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance>() { CardAppearanceBehaviour.Appearance.RareCardBackground },
                tribes: new List<Tribe>() { Tribe.Insect },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/omukade_emission.png")
                );
        }
    }
}