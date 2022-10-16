using APIPlugin;
using DiskCardGame;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;

namespace NevernamedsInscryptionMod
{
    static class DudEgg
    {
        public static void Init()
        {

            Texture2D tex = Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/dudegg.png");
            // Add the card
            CardSetupUtility.NewCard("Nevernamed DudEgg",
                "Dud Egg",
                0,
                2,
                new List<CardMetaCategory> { CardMetaCategory.Rare },
                CardTemple.Nature,
                description: "A sad, dud egg. There's no way it could hatch on it's own now. Perhaps it needs a little help?",
                bloodCost: 0,
                bonesCost: 4,
                defaultTex: tex,
                abilities: new List<Ability>() {  },
                tribes: new List<Tribe>() { Tribe.Bird},
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/dudegg_emission.png"),
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.RareCardBackground },
                defaultEvolutionCard: "Nevernamed Roc"
                );

            Texture2D tex2 = Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/roc.png");
            // Add the card
            CardSetupUtility.NewCard("Nevernamed Roc",
                "Roc",
                6,
                4,
                new List<CardMetaCategory> {  },
                CardTemple.Nature,
                description: "",
                bloodCost: 0,
                bonesCost: 4,
                defaultTex: tex2,
                abilities: new List<Ability>() {Ability.Flying },
                tribes: new List<Tribe>() { Tribe.Bird },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/roc_emission.png"),
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.RareCardBackground },
                defaultEvolutionName: "Party Roc"
                );
        }
    }
}
