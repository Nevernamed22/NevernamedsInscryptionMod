using APIPlugin;
using DiskCardGame;
using System;
using System.Collections.Generic;
using System.IO;
using NevernamedsSigils;
using System.Text;
using UnityEngine;

namespace NevernamedsInscryptionMod
{
    static class CatalogueKeeper
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed CatalogueKeeper",
                "Catalogue Keeper",
                1,
                1,
                new List<CardMetaCategory> { CardMetaCategory.Part3Random, CardMetaCategory.ChoiceNode },
                CardTemple.Tech,
                description: "",
                bloodCost: 0,
                bonesCost: 0,
                energyCost: 5,
                tribes: new List<Tribe>() { },
                abilities: new List<Ability>() { Summoner.ability },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/CardsTech/cataloguekeeper.png")
                );
        }
    }
}