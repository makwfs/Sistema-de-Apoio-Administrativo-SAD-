using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMysql.Entidades
{
    public class Pessoas
    {
        int id, IdSaida;
        public string Patrimonio, Modelo, Serial, Local, Observacao, PatrimonioPM, pbTmd, SrcFoto, SrcEditarFoto;
        public string placa, prefixo;
        private string nomeControleAcesso, REControleAcesso, POSTOGRADControleAcesso, TXBRGControleAcesso, UNIDADEControleAcesso,
            CIAControleAcesso, SECAOControleAcesso, NCARTAOontroleAcesso, VENCIMENTOControleAcesso, MARCAControleAcesso,
            MODELOControleAcesso, EMPLACAMENTOControleAcesso, CIDADEControleAcesso, CORControleAcesso, DATA, HORA, STATUS, MOTORISTA, STATUS_CARTAO;

        




        // Encapsulamento 
        public int Id { get => id; set => id = value; }
       
        //Info
        public string PatrimonioInfo { get => this.Patrimonio; set => this.Patrimonio = value; }
        public string ModeloInfo { get => Modelo; set => Modelo = value; }
        public string SerialInfo { get => Serial; set => Serial = value; }
        public string LocalInfo { get => Local; set => Local = value; }
        public string ObservacaoInfo { get => Observacao; set => Observacao = value; }
        public string PatrimonioPMInfo { get => PatrimonioPM; set => PatrimonioPM = value; }
        public string PbTmdInfo { get => pbTmd; set => pbTmd = value; }
        public string SrcFotoInfo{ get => SrcFoto; set => SrcFoto = value; }
        public string SrcEditarFotoInfo { get => SrcEditarFoto; set => SrcEditarFoto = value; }
        public string Placa { get => placa; set => placa = value; }
        public string Prefixo { get => prefixo; set => prefixo = value; }

        //CONTROLE DE ACESSO
        public string NomeControleAcesso { get => nomeControleAcesso; set => nomeControleAcesso = value; }
        public string REControleAcesso1 { get => REControleAcesso; set => REControleAcesso = value; }
        public string POSTOGRADControleAcesso1 { get => POSTOGRADControleAcesso; set => POSTOGRADControleAcesso = value; }
        public string TXBRGControleAcesso1 { get => TXBRGControleAcesso; set => TXBRGControleAcesso = value; }
        public string UNIDADEControleAcesso1 { get => UNIDADEControleAcesso; set => UNIDADEControleAcesso = value; }
        public string CIAControleAcesso1 { get => CIAControleAcesso; set => CIAControleAcesso = value; }
        public string SECAOControleAcesso1 { get => SECAOControleAcesso; set => SECAOControleAcesso = value; }
        public string NCARTAOontroleAcesso1 { get => NCARTAOontroleAcesso; set => NCARTAOontroleAcesso = value; }
        public string VENCIMENTOControleAcesso1 { get => VENCIMENTOControleAcesso; set => VENCIMENTOControleAcesso = value; }
        public string MARCAControleAcesso1 { get => MARCAControleAcesso; set => MARCAControleAcesso = value; }
        public string MODELOControleAcesso1 { get => MODELOControleAcesso; set => MODELOControleAcesso = value; }
        public string EMPLACAMENTOControleAcesso1 { get => EMPLACAMENTOControleAcesso; set => EMPLACAMENTOControleAcesso = value; }
        public string CIDADEControleAcesso1 { get => CIDADEControleAcesso; set => CIDADEControleAcesso = value; }
        public string CORControleAcesso1 { get => CORControleAcesso; set => CORControleAcesso = value; }
        public string DATA1 { get => DATA; set => DATA = value; }
        public string HORA1 { get => HORA; set => HORA = value; }
        public string STATUS1 { get => STATUS; set => STATUS = value; }
        public int IdSaida1 { get => IdSaida; set => IdSaida = value; }
        public string MOTORISTA1 { get => MOTORISTA; set => MOTORISTA = value; }
        public string STATUS_CARTAO1 { get => STATUS_CARTAO; set => STATUS_CARTAO = value; }
    }
}
