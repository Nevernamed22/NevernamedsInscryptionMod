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
    static class CharredLump
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed CharredLump",
                "Charred Lump",
                0,
                1,
                new List<CardMetaCategory> {  },
                CardTemple.Nature,
                description: "",
                bloodCost: 0,
                bonesCost: 0,
                abilities: new List<Ability>() {  Ability.TripleBlood },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/charredlump.png"),
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.RareCardBackground },
                decals: new List<Texture>() { Tools.LoadTex("NevernamedsInscryptionMod/Resources/Other/smokedecal.png") },
                tribes: new List<Tribe>() {  }
                );
        }
    }
}