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
    static class Curruid
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Curruid",
                  "Curruid",
                  2,
                 6,
                  new List<CardMetaCategory> { CardMetaCategory.Rare },
                  CardTemple.Nature,
                  description: "Clawed lord of the waves, the Curruid has but one blind spot.",
                  bloodCost: 3,
                  bonesCost: 0,
                  abilities: new List<Ability>() { EnemyLines.ability },
                  defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/curruid.png"),
                  appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.RareCardBackground, },
                  tribes: new List<Tribe>() { NevernamedsTribes.Crustacean },
                  emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/curruid_emission.png")
                  );
        }
    }
}