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
    static class Sphinx
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed SphinxCub",
                "Sphinx Cub",
                3,
                2,
                new List<CardMetaCategory> { CardMetaCategory.Rare },
                CardTemple.Nature,
                description: "The young Sphinx. A creature of the endless cycle...",
                bloodCost: 2,
                bonesCost: 0,
                abilities: new List<Ability>() { TransformerCustom.ability },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/sphinxcub.png"),
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/sphinxcub_emission.png"),
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.RareCardBackground, },
                transformerForm: "BeastNevernamed Sphinx"
                );

            CardSetupUtility.NewCard("Nevernamed Sphinx",
                "Sphinx",
                6,
                2,
                new List<CardMetaCategory> {  },
                CardTemple.Nature,
                description: "The Sphinx. A creature of the endless cycle...",
                bloodCost: 2,
                bonesCost: 0,
                abilities: new List<Ability>() { TransformerCustom.ability },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/sphinx.png"),
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/sphinx_emission.png"),
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.RareCardBackground, },
                transformerForm: "BeastNevernamed ElderSphinx"
                );

            CardSetupUtility.NewCard("Nevernamed ElderSphinx",
                "Elder Sphinx",
                9,
                2,
                new List<CardMetaCategory> { },
                CardTemple.Nature,
                description: "The elder Sphinx. A creature of the endless cycle...",
                bloodCost: 2,
                bonesCost: 0,
                abilities: new List<Ability>() { TransformerCustom.ability },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/eldersphinx.png"),
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/eldersphinx_emission.png"),
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.RareCardBackground, },
                transformerForm: "BeastNevernamed SphinxCub"
                );
        }
    }
}