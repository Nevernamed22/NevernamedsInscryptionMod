using APIPlugin;
using DiskCardGame;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using NevernamedsSigils;
using UnityEngine;
using InscryptionAPI.Card;

namespace NevernamedsInscryptionMod
{
    static class Suangi
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed StuffedCorpse",
                "Stuffed Corpse",
                1,
                1,
                new List<CardMetaCategory> {  },
                CardTemple.Undead,
                description: "",
                bloodCost: 0,
                bonesCost: 0,
                energyCost: 0,
                tribes: new List<Tribe>() { },
                abilities: new List<Ability>() { Harbinger.ability },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/CardsGrimora/stuffedcorpse.png"),
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/CardsGrimora/stuffedcorpse_emission.png"),
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/stuffedcorpse_pixel.png")
                );

     CardInfo inf =       CardSetupUtility.NewCard("Nevernamed Suangi",
                "Suangi",
                3,
                1,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable, Plugin.GrimoraChoiceNode },
                CardTemple.Undead,
                description: "A vicious witch- he stuffs the corpses of his victims, denying them any peace in death.",
                bloodCost: 0,
                bonesCost: 6,
                energyCost: 0,
                tribes: new List<Tribe>() { },
                abilities: new List<Ability>() { Propagation.ability, EyeForBattle.ability },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/CardsGrimora/suangi.png"),
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/CardsGrimora/suangi_emission.png"),
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/suangi_pixel.png")
                );
            inf.SetExtendedProperty("PropagationOverride", "DeadNevernamed StuffedCorpse");
        }
    }
}