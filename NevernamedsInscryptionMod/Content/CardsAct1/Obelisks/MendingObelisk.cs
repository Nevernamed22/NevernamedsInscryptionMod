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
    static class MendingObelisk
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed MendingObelisk",
                "Mending Obelisk",
                0,
                2,
                new List<CardMetaCategory> { },
                CardTemple.Nature,
                description: "An ominous standing stone, wrapped in inviting cloth.",
                bloodCost: 0,
                bonesCost: 2,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/Obelisks/mendingobelisk.png"),
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/Obelisks/mendingobelisk_emission.png"),
                abilities: new List<Ability>() { TenderBond.ability, Ability.MadeOfStone },
                traits: new List<Trait>() { NevernamedsTraits.Obelisk, Trait.Terrain },
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.TerrainBackground },
                preventSigilVictim: true,
                preventCampfire: true

                );
        }
    }
}
