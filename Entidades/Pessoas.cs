using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMysql.Entidades
{
    public class Pessoas
    {
        int id;
        public string Patrimonio, Modelo, Serial, Local, Observacao, PatrimonioPM, pbTmd, SrcFoto, SrcEditarFoto;
        public string placa, prefixo;
       



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
        
    }
}
