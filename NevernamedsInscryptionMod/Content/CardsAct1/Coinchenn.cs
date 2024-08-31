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
    static class Coinchenn
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Coinchenn",
                  "Coinchenn",
                  2,
                  2,
                  new List<CardMetaCategory> { CardMetaCategory.Rare },
                  CardTemple.Nature,
                  description: "It lurks in the shadows of history, and shows no mercy to its prey.",
                  bloodCost: 2,
                  bonesCost: 0,
                  abilities: new List<Ability>() { Spurred.ability },
                  defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/coinchenn.png"),
                  appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.RareCardBackground, },
                  tribes: new List<Tribe>() {  },
                  emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/coinchenn_emission.png")
                  ).SetExtendedProperty("CustomSpurredBuff", 3);
        }
    }
}