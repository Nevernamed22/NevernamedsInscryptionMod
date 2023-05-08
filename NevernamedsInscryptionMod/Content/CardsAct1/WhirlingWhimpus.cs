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
    static class WhirlingWhimpus
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed WhirlingWhimpus",
                "Whirling Whimpus",
                1,
                3,
                new List<CardMetaCategory> {  CardMetaCategory.Rare },
                CardTemple.Nature,
                description: "The whirling whimpus, it can spin fast enough to reduce an unwary creature into a faint red mist...",
                bloodCost: 2,
                bonesCost: 0,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/whirlingwhimpus.png"),
                abilities: new List<Ability>() { TransformerCustom.ability },
                tribes: new List<Tribe>() {  },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/whirlingwhimpus_emission.png"),
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.RareCardBackground },
                transformerForm: "BeastNevernamed WhirlingWhimpusSpin"
                );

            // Add the card
            CardSetupUtility.NewCard("Nevernamed WhirlingWhimpusSpin",
                "Whirling Whimpus",
                1,
                3,
                new List<CardMetaCategory> { },
                CardTemple.Nature,
                description: "",
                bloodCost: 2,
                bonesCost: 0,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/whirlingwhimpus_spin.png"),
                abilities: new List<Ability>() { TransformerCustom.ability, TripleStrike.ability, ReturnStrike.ability },
                tribes: new List<Tribe>() {},
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.RareCardBackground },
                transformerForm: "BeastNevernamed WhirlingWhimpus"
                );
        }
    }
}
