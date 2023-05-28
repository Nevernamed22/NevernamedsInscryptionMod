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
    static class Ahuizotl
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Ahuizotl",
                  "Ahuizotl",
                  1,
                  2,
                  new List<CardMetaCategory> { CardMetaCategory.Rare },
                  CardTemple.Nature,
                  description: "It lurks below the water, until the time is ripe to rend the land for prey.",
                  bloodCost: 1,
                  bonesCost: 0,
                  abilities: new List<Ability>() { Carnivore.ability, CoastGuard.ability },
                  defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/ahuizotl.png"),
                  appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.RareCardBackground, },
                  tribes: new List<Tribe>() { Tribe.Canine },
                  emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/ahuizotl_emission.png")
                  );
        }
    }
}