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
    static class DeBug
    {
        public static void Init()
        {

            Texture2D tex = Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/debug.png");
            // Add the card
            CardInfo inf = CardSetupUtility.NewCard("De Bug",
                  "De Bug",
              0,
                  1,
                  new List<CardMetaCategory> {   CardMetaCategory.GBCPlayable  }, //DONT FUCKING COPY THIS YOU NUMPTY
                  CardTemple.Nature,
                  description: "What... is that?",
                  bloodCost: 0,
                  bonesCost: 0,
                  gemsCost: new List<GemType>() {  },
                  defaultTex: tex,
                  abilities: new List<Ability>() { Healer.ability  },   
                  tribes: new List<Tribe>() { },
                  specialAbilities: new List<SpecialTriggeredAbility>() {   },
                  emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/debug_emission.png"),
                  pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/debug_pixel.png"),
                  appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.AlternatingBloodDecal  }
                  );;
            inf.mods.Add(new CardModificationInfo() { gemify = true });
        }
    }
}
