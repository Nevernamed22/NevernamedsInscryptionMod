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
    static class TummyBug
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed TummyBug",
                  "Tummy Bug",
                  1,
                  1,
                  new List<CardMetaCategory> { CardMetaCategory.Rare },
                  CardTemple.Nature,
                  description: "An excercise in literalism...",
                  bloodCost: 1,
                  bonesCost: 0,
                  abilities: new List<Ability>() { Ability.LatchBrittle, FrailLatch.ability, AnnoyingLatch.ability },
                  defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/tummybug.png"),
                  appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.RareCardBackground, },
                  tribes: new List<Tribe>() { Tribe.Insect },
                  emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/tummybug_emission.png")
                  );           
        }
    }
}