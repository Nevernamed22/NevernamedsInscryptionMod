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
    static class GrandHighIllusionist
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed MasterBleenejiraq",
               "Master Bleene?",
               0,
               4,
               new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable, CardMetaCategory.Rare },
               CardTemple.Wizard,
               description: "",
               gemsCost: new List<GemType>() { GemType.Blue, GemType.Green },
               specialAbilities: new List<SpecialTriggeredAbility>() { Act2Shapeshifter.ability },
               abilities: new List<Ability>() { Ability.ActivatedSacrificeDrawCards },
               pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/masterbleenejiraq_pixel.png")
               ).SetExtendedProperty("Act2ShapeshifterOverride", "WizardNevernamed GrandHighIllusionist")
               .SetExtendedProperty("InfAct2ExcludeFromBattle", "true");

            CardSetupUtility.NewCard("Nevernamed GrandHighIllusionist",
                "Grand High Illusionist",
                1,
                1,
                new List<CardMetaCategory> {  CardMetaCategory.Rare },
                CardTemple.Wizard,
                description: "",
                gemsCost: new List<GemType>() {  },
                specialAbilities: new List<SpecialTriggeredAbility>() {  },
                abilities: new List<Ability>() { QuadStrike.ability },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/grandhighillusionist_pixel.png")
                );
        }
    }
}