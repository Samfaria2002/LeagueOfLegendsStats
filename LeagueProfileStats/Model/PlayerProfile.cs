using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace LeagueProfileStats.Model
{

    public enum enRole {
        Top,
        Jungle,
        Mid,
        Adcarry,
        Suporte
    }

    public enum enServer {
        BR,
        NA,
        EUW,
        EUNE,
        LAN,
        LAS,
        OCE,
        RU,
        TR,
        JP,
        KR
    }

    public enum enRank {
        Ferro,
        Bronze,
        Prata,
        Ouro,
        Platina,
        Esmeralda,
        Diamante,
        Mestre,
        GrãoMestre,
        Desafiante
    }

    public enum enTier {
       I,
       II,
       III,
       IV
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
        public enTier Tier { get; set; }

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
            enTier tier,
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
        }

        public string toString() {
            return $"Nome: {Nome}\nEmail: {Email}\nSenha: {Senha}\nNickname: {Nickname}\nServer: {Server}\nRank: {Rank}\nTier: {Tier}\nDivisão: {Pdl}\nWinrate: {Winrate}\nMain Role: {MainRole}\nSecondary Role: {SecondaryRole}\nPro Player: {ProPlayer}\nOrganização: {Organizacao}";
        }
    }
}