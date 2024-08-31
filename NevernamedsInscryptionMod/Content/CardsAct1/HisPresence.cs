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
    static class HisPresence
    {
        public static void Init()
        {
            Texture2D title = Tools.LoadTex("NevernamedsInscryptionMod/Resources/Other/fadedsquidtitle.png");

            Texture2D decal2 = Tools.LoadTex("NevernamedsInscryptionMod/Resources/Other/fakesquirrel2_decal.png");
            Texture2D decal3 = Tools.LoadTex("NevernamedsInscryptionMod/Resources/Other/fakesquirrel3_decal.png");
            Texture2D decal4 = Tools.LoadTex("NevernamedsInscryptionMod/Resources/Other/fakesquirrel4_decal.png");


            CardSetupUtility.NewCard("Nevernamed HisPresence",
                "Squirrel",
                0,
                1,
                new List<CardMetaCategory> { CardMetaCategory.Rare },
                CardTemple.Nature,
                description: "",
                bloodCost: 0,
                bonesCost: 0,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/fakesquirrel1.png"),
                abilities: new List<Ability>() {  },
                 appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance>() {  },
                tribes: new List<Tribe>() { Tribe.Squirrel },
                specialAbilities: new List<SpecialTriggeredAbility>() { InherentFledgling.ability },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/fakesquirrel1_emission.png"),
                defaultEvolutionCard: "BeastNevernamed HisPresence2",
                preventSignature: true
                ).SetExtendedProperty("InherentFledglingGlitcher", "true");

            CardSetupUtility.NewCard("Nevernamed HisPresence2",
                "Squirrel",
                1,
                2,
                new List<CardMetaCategory> {  },
                CardTemple.Nature,
                description: "",
                bloodCost: 0,
                bonesCost: 0,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/fakesquirrel2.png"),
                abilities: new List<Ability>() { },
                 appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance>() { CardAppearanceBehaviour.Appearance.RedEmission },
                 decals: new List<Texture>() { decal2 },
                tribes: new List<Tribe>() { Tribe.Squirrel },
                specialAbilities: new List<SpecialTriggeredAbility>() { InherentFledgling.ability },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/fakesquirrel2_emission.png"),
                defaultEvolutionCard: "BeastNevernamed HisPresence3",
                preventSignature: true
                ).SetExtendedProperty("InherentFledglingGlitcher", "true");

            CardSetupUtility.NewCard("Nevernamed HisPresence3",
                "Squirrel",
                2,
                3,
                new List<CardMetaCategory> { },
                CardTemple.Nature,
                description: "",
                bloodCost: 0,
                bonesCost: 0,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/fakesquirrel3.png"),
                abilities: new List<Ability>() { },
                 appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance>() { CardAppearanceBehaviour.Appearance.RedEmission },
                 decals: new List<Texture>() { decal3 },
                tribes: new List<Tribe>() { Tribe.Squirrel },
                specialAbilities: new List<SpecialTriggeredAbility>() { InherentFledgling.ability },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/fakesquirrel3_emission.png"),
                defaultEvolutionCard: "BeastNevernamed HisPresence4",
                preventSignature: true
                ).SetExtendedProperty("InherentFledglingGlitcher", "true");

            CardSetupUtility.NewCard("Nevernamed HisPresence4",
                "Squirrel",
                3,
                4,
                new List<CardMetaCategory> { },
                CardTemple.Nature,
                description: "",
                bloodCost: 0,
                bonesCost: 0,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/fakesquirrel4.png"),
                abilities: new List<Ability>() { Ability.GuardDog, Ability.Sentry },
                 appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance>() { CardAppearanceBehaviour.Appearance.RedEmission },
                 decals: new List<Texture>() { decal4 },
                 titleGraphic: title,
                tribes: new List<Tribe>() { Tribe.Squirrel },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/fakesquirrel4_emission.png"),
                preventSignature: true
                );
        }
    }
}