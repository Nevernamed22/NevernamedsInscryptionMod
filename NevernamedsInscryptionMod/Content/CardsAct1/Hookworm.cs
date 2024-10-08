﻿using APIPlugin;
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
    static class Hookworm
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Hookworm",
                  "Hookworm",
                  0,
                  2,
                  new List<CardMetaCategory> { CardMetaCategory.Rare },
                  CardTemple.Nature,
                  description: "An irritant worm, its consumption will surely drive any creature mad...",
                  bloodCost: 1,
                  bonesCost: 0,
                  abilities: new List<Ability>() { Ability.Reach, HookLineAndSinker.ability },
                  defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/hookworm.png"),
                  appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.RareCardBackground, },
                  tribes: new List<Tribe>() { Tribe.Insect },
                  emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/hookworm_emission.png"),
                  traits: new List<Trait>() { Trait.KillsSurvivors }
                  );
        }
    }
}