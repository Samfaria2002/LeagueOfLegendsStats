using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
    public class Profile
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public string Senha { get; set; }

        public string Nickname { get; set; }

        public enServer Server { get; set; }

        public enRank Rank { get; set; }

        public enTier Tier { get; set; }

        public int Pdl { get; set; }

        public string Winrate { get; set; }

        public enRole MainRole { get; set; }

        public enRole SecondaryRole { get; set; }

        public bool? ProPlayer { get; set; }

        public string? Organizacao { get; set; }

        public Profile(
            int id, 
            string nome, 
            string email, 
            string senha, 
            string nickname, 
            enServer server, 
            enRank rank, 
            enTier tier, 
            string divisao, 
            int pdl, 
            string winrate, 
            enRole mainRole, 
            enRole secondaryRole,
            bool? proPlayer,
            string? organizacao
            )
        {
            this.Id = id;
            this.Nome = nome;
            this.Email = email;
            this.Senha = senha;
            this.Nickname = nickname;
            this.Server = server;
            this.Rank = rank;
            this.Tier = tier;
            this.Pdl = pdl;
            this.Winrate = winrate;
            this.MainRole = mainRole;
            this.SecondaryRole = secondaryRole;
            this.ProPlayer = proPlayer;
            this.Organizacao = organizacao;
        }

        public string toString() {
            return $"Nome: {Nome}\nEmail: {Email}\nSenha: {Senha}\nNickname: {Nickname}\nServer: {Server}\nRank: {Rank}\nTier: {Tier}\nDivisão: {Pdl}\nWinrate: {Winrate}\nMain Role: {MainRole}\nSecondary Role: {SecondaryRole}\nPro Player: {ProPlayer}\nOrganização: {Organizacao}";
        }
    }
}