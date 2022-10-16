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
    static class BlankObelisk
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed BlankObelisk",
                "Blank Obelisk",
                0,
                2,
                new List<CardMetaCategory> {  },
                CardTemple.Nature,
                description: "A blank obelisk. Unremarkable.",
                bloodCost: 0,
                bonesCost: 2,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/Obelisks/blankobelisk.png"),
                abilities: new List<Ability>() { MeaninglessBond.ability, Ability.MadeOfStone },
                traits: new List<Trait>() { NevernamedsTraits.Obelisk, NevernamedsTraits.BannedSigilTransferVictim, NevernamedsTraits.BannedFromCampfire, Trait.Terrain },
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.TerrainBackground }
                );
        }
    }
}
