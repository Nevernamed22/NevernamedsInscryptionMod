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
    static class Glochidium
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Glochidium",
                "Glochidium",
                1,
                1,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, },
                CardTemple.Nature,
                description: "The hungry glochidium. It will happily feast upon your other beasts.",
                bloodCost: 0,
                bonesCost: 2,
                energyCost: 0,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/glochidium.png"),
                abilities: new List<Ability>() { AculeateGrip.ability },
                tribes: new List<Tribe>() { },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/glochidium_emission.png")
                );
        }
    }
}
