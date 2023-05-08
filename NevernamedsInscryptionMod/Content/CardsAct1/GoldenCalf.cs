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
    static class GoldenCalf
    {
        public static void Init()
        {
            CardInfo card = CardSetupUtility.NewCard("Nevernamed GoldenCalf",
                     "Golden Calf",
                     1,
                     1,
                     new List<CardMetaCategory> { CardMetaCategory.Rare },
                     CardTemple.Nature,
                     description: "It seems to exist to be destroyed...",
                     bloodCost: 1,
                     bonesCost: 0,
                     abilities: new List<Ability>() { Valuable.ability },
                     defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/goldencalf.png"),
                     emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/goldencalf_emission.png"),
                     appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.RareCardBackground, CardAppearanceBehaviour.Appearance.GoldEmission },
                     tribes: new List<Tribe>() { Tribe.Hooved }
                     );
            card.SetExtendedProperty("CustomValuablePayoutAmount", "5");
        }
    }
}