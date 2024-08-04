using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace LeagueProfileStats.Model
{

    [JsonConverter(typeof(StringEnumConverter))]
    public enum enRole {
        [Display(Name = "Top")]
        Top,
        [Display(Name = "Jungle")]
        Jungle,
        [Display(Name = "Mid")]
        Mid,
        [Display(Name = "Adcarry")]
        Adcarry,
        [Display(Name = "Suporte")]
        Suporte
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum enServer {
        [Display(Name = "BR")]
        BR,
        [Display(Name = "NA")]
        NA,
        [Display(Name = "EUW")]
        EUW,
        [Display(Name = "EUNE")]
        EUNE,
        [Display(Name = "LAN")]
        LAN,
        [Display(Name = "LAS")]
        LAS,
        [Display(Name = "OCE")]
        OCE,
        [Display(Name = "RU")]
        RU,
        [Display(Name = "TR")]
        TR,
        [Display(Name = "JP")]
        JP,
        [Display(Name = "KR")]
        KR
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum enRank {
        [Display(Name = "Ferro")]
        Ferro,
        [Display(Name = "Bronze")]
        Bronze,
        [Display(Name = "Prata")]
        Prata,
        [Display(Name = "Ouro")]
        Ouro,
        [Display(Name = "Platina")]
        Platina,
        [Display(Name = "Esmeralda")]
        Esmeralda,
        [Display(Name = "Diamante")]
        Diamante,
        [Display(Name = "Mestre")]
        Mestre,
        [Display(Name = "Grão-Mestre")]
        GrãoMestre,
        [Display(Name = "Desafiante")]
        Desafiante
    }

    [Serializable]
    public enum enTier {
        
        [Display(Name = "I")]
       I,
       [Display(Name = "II")]
       II,
       [Display(Name = "III")]
       III,
        [Display(Name = "IV")]
       IV,
    }


    public class PlayerProfile
    {
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Senha { get; set; }

        [Required]
        public string Nickname { get; set; }

        [Required]
        public enServer Server { get; set; }

        [Required]
        public enRank Rank { get; set; }

        [Required]
        public enTier? Tier { get; set; }

        [Required]
        public int Pdl { get; set; }

        [Required]
        public string Winrate { get; set; }

        [Required]
        public enRole MainRole { get; set; }

        [Required]
        public enRole SecondaryRole { get; set; }

        public bool? ProPlayer { get; set; }

        public string? Organizacao { get; set; }

        public PlayerProfile(
            int id,
            string nome,
            string email,
            string senha,
            string nickname,
            enServer server,
            enRank rank,
            enTier? tier,
            int pdl,
            string winrate,
            enRole mainRole,
            enRole secondaryRole,
            bool? proPlayer,
            string? organizacao)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Senha = senha;
            Nickname = nickname;
            Server = server;
            Rank = rank;
            Tier = tier;
            Pdl = pdl;
            Winrate = winrate;
            MainRole = mainRole;
            SecondaryRole = secondaryRole;
            ProPlayer = proPlayer;
            Organizacao = organizacao;

            if(this.Rank == enRank.Mestre || this.Rank == enRank.GrãoMestre || this.Rank == enRank.Desafiante) {
                this.Tier = null;
            }
            
        }

        public string toString() {
            return $"Nome: {Nome}\nEmail: {Email}\nSenha: {Senha}\nNickname: {Nickname}\nServer: {Server}\nRank: {Rank}\nTier: {Tier}\nDivisão: {Pdl}\nWinrate: {Winrate}\nMain Role: {MainRole}\nSecondary Role: {SecondaryRole}\nPro Player: {ProPlayer}\nOrganização: {Organizacao}";
        }
    }
}