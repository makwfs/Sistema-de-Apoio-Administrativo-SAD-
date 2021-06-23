using SistemaMysql.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SistemaMysql;
using SistemaMysql.Model;
using SistemaMysql.Entidades;
using System.Data.SqlClient;
using System.IO;
using System.Drawing.Imaging;

namespace SistemaMysql.DAO
{
    public class DAO  //Camada 3
    {
        MySqlCommand sql;        
        Conexao con = new Conexao();
        public bool tem = false;
        public String mensagem = "";
        

        public DataTable Listar()
        {

            
            try                                                                                                               // Usar o try para caso ocorra algum erro
            {
                con.Conectar();
                sql = new MySqlCommand("select * from controletmd", con.con);                                                    // comando para buscar dados no BD
                
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = sql;
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception)
            {

                throw;
            }
        }


        public DataTable ListarTmd()
        {


            try                                                                                                               // Usar o try para caso ocorra algum erro
            {
                con.Conectar();
                sql = new MySqlCommand("select * from controletmd", con.con);                                                    // comando para buscar dados no BD

                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = sql;
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataTable ListarImpressora()
        {


            try                                                                                                               // Usar o try para caso ocorra algum erro
            {
                con.Conectar();
                sql = new MySqlCommand("select * from controleImpressora", con.con);                                                    // comando para buscar dados no BD

                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = sql;
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataTable ListarPc()
        {


            try                                                                                                               // Usar o try para caso ocorra algum erro
            {
                con.Conectar();
                sql = new MySqlCommand("select * from controlepc", con.con);                                                    // comando para buscar dados no BD

                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = sql;
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataTable ListarTodos()
        {


            try                                                                                                               // Usar o try para caso ocorra algum erro
            {
                con.Conectar();
                sql = new MySqlCommand("select * from controletodos", con.con);                                                    // comando para buscar dados no BD

                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = sql;
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception)
            {

                throw;
            }
        }


        public DataTable ListarRadio()
        {


            try                                                                                                               // Usar o try para caso ocorra algum erro
            {
                con.Conectar();
                sql = new MySqlCommand("select * from controleradio", con.con);                                                    // comando para buscar dados no BD

                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = sql;
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataTable ListarVtr()
        {


            try                                                                                                               // Usar o try para caso ocorra algum erro
            {
                con.Conectar();
                sql = new MySqlCommand("select * from controlevtr", con.con);                                                    // comando para buscar dados no BD

                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = sql;
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataTable ListarUsuario()
        {


            try                                                                                                               // Usar o try para caso ocorra algum erro
            {
                con.Conectar();
                sql = new MySqlCommand("select * from usuarios", con.con);                                                    // comando para buscar dados no BD

                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = sql;
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataTable ListarControle()
        {


            try                                                                                                               // Usar o try para caso ocorra algum erro
            {
                con.Conectar();
                sql = new MySqlCommand("select * from entradasaida", con.con);                                                    // comando para buscar dados no BD

                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = sql;
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception)
            {

                throw;
            }
        }

         
        


        public void CadastroTmd(Pessoas dados)
        {
            
            try
            {
                con.Conectar();
                sql = new MySqlCommand("INSERT INTO controletmd (Patrimônio, Modelo, Serial, Local, PatrimônioPm, Observação,Foto) values ( @Patrimônio, @Modelo, @Serial, @Local, @PatrimonioPm, @Observação, @Foto)", con.con);  // inclusão de dados no BD pessoa
                
                sql.Parameters.AddWithValue("@Patrimônio", dados.PatrimonioInfo);
                sql.Parameters.AddWithValue("@Modelo", dados.ModeloInfo);
                sql.Parameters.AddWithValue("@Serial", dados.SerialInfo);
                sql.Parameters.AddWithValue("@Local", dados.LocalInfo);
                sql.Parameters.AddWithValue("@PatrimonioPm", dados.PatrimonioPMInfo);
                sql.Parameters.AddWithValue("@Observação", dados.ObservacaoInfo);
                sql.Parameters.AddWithValue("@Foto", dados.SrcFotoInfo);
                sql.ExecuteNonQuery();

                
                

                
                sql = new MySqlCommand("INSERT INTO controletodos ( Patrimônio, Modelo, Serial, Local, PatrimônioPm, Observação, Foto) values ( @Patrimônio, @Modelo, @Serial, @Local, @PatrimonioPm, @Observação, @Foto)", con.con);
                
                sql.Parameters.AddWithValue("@Patrimônio", dados.PatrimonioInfo);
                sql.Parameters.AddWithValue("@Modelo", dados.ModeloInfo);
                sql.Parameters.AddWithValue("@Serial", dados.SerialInfo);
                sql.Parameters.AddWithValue("@Local", dados.LocalInfo);
                sql.Parameters.AddWithValue("@PatrimonioPm", dados.PatrimonioPMInfo);
                sql.Parameters.AddWithValue("@Observação", dados.ObservacaoInfo);
                sql.Parameters.AddWithValue("@Foto", dados.SrcFotoInfo);
                sql.ExecuteNonQuery();
                con.FecharConexao();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar 1" + ex);
                //MessageBox.Show("O número de patrimônio inserido já esta cadastrado! Verifique o numéro e tente novamente!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.FecharConexao();
            }
        }



        public void CadastroPc(Pessoas dados)
        {

            try
            {
                con.Conectar();
                sql = new MySqlCommand("INSERT INTO controlepc ( Patrimônio, Modelo, Serial, Local, PatrimônioPm, Observação,Foto) values ( @Patrimônio, @Modelo, @Serial, @Local, @PatrimonioPm, @Observação, @Foto )", con.con);  // inclusão de dados no BD pessoa
                
                sql.Parameters.AddWithValue("@Patrimônio", dados.PatrimonioInfo);
                sql.Parameters.AddWithValue("@Modelo", dados.ModeloInfo);
                sql.Parameters.AddWithValue("@Serial", dados.SerialInfo);
                sql.Parameters.AddWithValue("@Local", dados.LocalInfo);
                sql.Parameters.AddWithValue("@PatrimonioPm", dados.PatrimonioPMInfo);
                sql.Parameters.AddWithValue("@Observação", dados.ObservacaoInfo);
                sql.Parameters.AddWithValue("@Foto", dados.SrcFotoInfo);
                sql.ExecuteNonQuery();




                
                sql = new MySqlCommand("INSERT INTO controletodos (Patrimônio, Modelo, Serial, Local, PatrimônioPm, Observação, Foto) values ( @Patrimônio, @Modelo, @Serial, @Local, @PatrimonioPm, @Observação,@Foto)", con.con);
                
                sql.Parameters.AddWithValue("@Patrimônio", dados.PatrimonioInfo);
                sql.Parameters.AddWithValue("@Modelo", dados.ModeloInfo);
                sql.Parameters.AddWithValue("@Serial", dados.SerialInfo);
                sql.Parameters.AddWithValue("@Local", dados.LocalInfo);
                sql.Parameters.AddWithValue("@PatrimonioPm", dados.PatrimonioPMInfo);
                sql.Parameters.AddWithValue("@Observação", dados.ObservacaoInfo);
                sql.Parameters.AddWithValue("@Foto", dados.SrcFotoInfo);
                sql.ExecuteNonQuery();
                con.FecharConexao();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar 1" + ex);
                //MessageBox.Show("O número de patrimônio inserido já esta cadastrado! Verifique o numéro e tente novamente!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.FecharConexao();
            }
        }

        public void CadastroImpressora(Pessoas dados)
        {

            try
            {
                con.Conectar();
                sql = new MySqlCommand("INSERT INTO controleImpressora ( Patrimônio, Modelo, Serial, Local, PatrimônioPm, Observação,Foto) values ( @Patrimônio, @Modelo, @Serial, @Local, @PatrimonioPm, @Observação, @Foto )", con.con);  // inclusão de dados no BD pessoa

                sql.Parameters.AddWithValue("@Patrimônio", dados.PatrimonioInfo);
                sql.Parameters.AddWithValue("@Modelo", dados.ModeloInfo);
                sql.Parameters.AddWithValue("@Serial", dados.SerialInfo);
                sql.Parameters.AddWithValue("@Local", dados.LocalInfo);
                sql.Parameters.AddWithValue("@PatrimonioPm", dados.PatrimonioPMInfo);
                sql.Parameters.AddWithValue("@Observação", dados.ObservacaoInfo);
                sql.Parameters.AddWithValue("@Foto", dados.SrcFotoInfo);
                sql.ExecuteNonQuery();





                sql = new MySqlCommand("INSERT INTO controletodos (Patrimônio, Modelo, Serial, Local, PatrimônioPm, Observação, Foto) values ( @Patrimônio, @Modelo, @Serial, @Local, @PatrimonioPm, @Observação,@Foto)", con.con);

                sql.Parameters.AddWithValue("@Patrimônio", dados.PatrimonioInfo);
                sql.Parameters.AddWithValue("@Modelo", dados.ModeloInfo);
                sql.Parameters.AddWithValue("@Serial", dados.SerialInfo);
                sql.Parameters.AddWithValue("@Local", dados.LocalInfo);
                sql.Parameters.AddWithValue("@PatrimonioPm", dados.PatrimonioPMInfo);
                sql.Parameters.AddWithValue("@Observação", dados.ObservacaoInfo);
                sql.Parameters.AddWithValue("@Foto", dados.SrcFotoInfo);
                sql.ExecuteNonQuery();
                con.FecharConexao();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar 1" + ex);
                //MessageBox.Show("O número de patrimônio inserido já esta cadastrado! Verifique o numéro e tente novamente!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.FecharConexao();
            }
        }


        public void CadastroRadio(Pessoas dados)
        {

            try
            {
                con.Conectar();
                sql = new MySqlCommand("INSERT INTO controleradio ( Patrimônio, Modelo, Serial, Local, PatrimônioPm, Observação,Foto) values ( @Patrimônio, @Modelo, @Serial, @Local, @PatrimonioPm, @Observação, @Foto )", con.con);  // inclusão de dados no BD pessoa

                sql.Parameters.AddWithValue("@Patrimônio", dados.PatrimonioInfo);
                sql.Parameters.AddWithValue("@Modelo", dados.ModeloInfo);
                sql.Parameters.AddWithValue("@Serial", dados.SerialInfo);
                sql.Parameters.AddWithValue("@Local", dados.LocalInfo);
                sql.Parameters.AddWithValue("@PatrimonioPm", dados.PatrimonioPMInfo);
                sql.Parameters.AddWithValue("@Observação", dados.ObservacaoInfo);
                sql.Parameters.AddWithValue("@Foto", dados.SrcFotoInfo);
                sql.ExecuteNonQuery();





                sql = new MySqlCommand("INSERT INTO controletodos (Patrimônio, Modelo, Serial, Local, PatrimônioPm, Observação, Foto) values ( @Patrimônio, @Modelo, @Serial, @Local, @PatrimonioPm, @Observação,@Foto)", con.con);

                sql.Parameters.AddWithValue("@Patrimônio", dados.PatrimonioInfo);
                sql.Parameters.AddWithValue("@Modelo", dados.ModeloInfo);
                sql.Parameters.AddWithValue("@Serial", dados.SerialInfo);
                sql.Parameters.AddWithValue("@Local", dados.LocalInfo);
                sql.Parameters.AddWithValue("@PatrimonioPm", dados.PatrimonioPMInfo);
                sql.Parameters.AddWithValue("@Observação", dados.ObservacaoInfo);
                sql.Parameters.AddWithValue("@Foto", dados.SrcFotoInfo);
                sql.ExecuteNonQuery();
                con.FecharConexao();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar 1" + ex);
                //MessageBox.Show("O número de patrimônio inserido já esta cadastrado! Verifique o numéro e tente novamente!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.FecharConexao();
            }
        }

        public void CadastroVtr(Pessoas dados)                                
        {

            try
            {
                con.Conectar();
                sql = new MySqlCommand("INSERT INTO controlevtr ( Patrimônio, Modelo, Placa, Local, Prefixo, Observação,Foto) values ( @Patrimônio, @Modelo, @Placa, @Local, @Prefixo, @Observação, @Foto )", con.con);  // inclusão de dados no BD pessoa

                sql.Parameters.AddWithValue("@Patrimônio", dados.PatrimonioInfo);
                sql.Parameters.AddWithValue("@Modelo", dados.ModeloInfo);
                sql.Parameters.AddWithValue("@Placa", dados.SerialInfo);
                sql.Parameters.AddWithValue("@Local", dados.LocalInfo);
                sql.Parameters.AddWithValue("@Prefixo", dados.PatrimonioPMInfo);
                sql.Parameters.AddWithValue("@Observação", dados.ObservacaoInfo);
                sql.Parameters.AddWithValue("@Foto", dados.SrcFotoInfo);
                sql.ExecuteNonQuery();





                sql = new MySqlCommand("INSERT INTO controletodos (Patrimônio, Modelo, Local, Observação, Foto, Placa, Prefixo) values ( @Patrimônio, @Modelo,  @Local, @Observação, @Foto, @Placa,  @Prefixo)", con.con);

                sql.Parameters.AddWithValue("@Patrimônio", dados.PatrimonioInfo);
                sql.Parameters.AddWithValue("@Modelo", dados.ModeloInfo);
                sql.Parameters.AddWithValue("@Placa", dados.SerialInfo);
                sql.Parameters.AddWithValue("@Local", dados.LocalInfo);
                sql.Parameters.AddWithValue("@Prefixo", dados.PatrimonioPMInfo);
                sql.Parameters.AddWithValue("@Observação", dados.ObservacaoInfo);
                sql.Parameters.AddWithValue("@Foto", dados.SrcFotoInfo);

                sql.ExecuteNonQuery();
                con.FecharConexao();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar" + ex);
                //MessageBox.Show("O número de patrimônio inserido já esta cadastrado! Verifique o numéro e tente novamente!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.FecharConexao();
            }
        }

        public void CadastroControleAcesso(Pessoas dados)
        {

            try
            {
                con.Conectar();
                sql = new MySqlCommand("INSERT INTO controleacessoteste ( NOME, RE, POSTO, RG, UNIDADE, CIA, SEÇÃO, CARTÃO, VENCIMENTO, MARCA, MODELO, EMPLACAMENTO, CIDADE, COR, DATA, HORA)" +
                    " values ( @NOME, @RE, @POSTO, @RG, @UNIDADE, @CIA, @SEÇÃO, @CARTÃO, @VENCIMENTO, @MARCA, @MODELO, @EMPLACAMENTO, @CIDADE, @COR, @DATA, @HORA )", con.con);  // inclusão de dados no BD pessoa

                sql.Parameters.AddWithValue("@NOME", dados.NomeControleAcesso);
                sql.Parameters.AddWithValue("@RE", dados.REControleAcesso1);
                sql.Parameters.AddWithValue("@POSTO", dados.POSTOGRADControleAcesso1);
                sql.Parameters.AddWithValue("@RG", dados.TXBRGControleAcesso1);
                sql.Parameters.AddWithValue("@UNIDADE", dados.UNIDADEControleAcesso1);
                sql.Parameters.AddWithValue("@CIA", dados.CIAControleAcesso1);
                sql.Parameters.AddWithValue("@SEÇÃO", dados.SECAOControleAcesso1);
                sql.Parameters.AddWithValue("@CARTÃO", dados.NCARTAOontroleAcesso1);
                sql.Parameters.AddWithValue("@VENCIMENTO", dados.VENCIMENTOControleAcesso1);
                sql.Parameters.AddWithValue("@MARCA", dados.MARCAControleAcesso1);
                sql.Parameters.AddWithValue("@MODELO", dados.MODELOControleAcesso1);
                sql.Parameters.AddWithValue("@EMPLACAMENTO", dados.EMPLACAMENTOControleAcesso1);
                sql.Parameters.AddWithValue("@CIDADE", dados.CIDADEControleAcesso1);
                sql.Parameters.AddWithValue("@COR", dados.CORControleAcesso1);
                sql.Parameters.AddWithValue("@DATA", dados.DATA1);
                sql.Parameters.AddWithValue("@HORA", dados.HORA1);
                sql.ExecuteNonQuery();                
                con.FecharConexao();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar" + ex);
                //MessageBox.Show("O número de patrimônio inserido já esta cadastrado! Verifique o numéro e tente novamente!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.FecharConexao();
            }
        }

        

        public void ENTRADAControleAcesso(Pessoas dados)
        {

            try
            {
                /*con.Conectar();
                sql = new MySqlCommand("INSERT INTO entradacontroleacessoteste ( NOME, RE, POSTO, RG, UNIDADE, CIA, SEÇÃO, CARTÃO, VENCIMENTO, MARCA, MODELO, EMPLACAMENTO, CIDADE, COR, DATA, HORA)" +
                    " values ( @NOME, @RE, @POSTO, @RG, @UNIDADE, @CIA, @SEÇÃO, @CARTÃO, @VENCIMENTO, @MARCA, @MODELO, @EMPLACAMENTO, @CIDADE, @COR, @DATA, @HORA )", con.con);  // inclusão de dados no BD pessoa*/

                con.Conectar();
                sql = new MySqlCommand("INSERT INTO entradasaida ( NOME, RE, POSTO, RG, UNIDADE, CIA, SEÇÃO, CARTÃO, VENCIMENTO, MARCA, MODELO, EMPLACAMENTO, CIDADE, COR, DATA, HORA, fk_id_ES)" +
                    " values ( @NOME, @RE, @POSTO, @RG, @UNIDADE, @CIA, @SEÇÃO, @CARTÃO, @VENCIMENTO, @MARCA, @MODELO, @EMPLACAMENTO, @CIDADE, @COR, @DATA, @HORA, @fk_id_ES )", con.con);  // inclusão de dados no BD pessoa

                sql.Parameters.AddWithValue("@NOME", dados.NomeControleAcesso);
                sql.Parameters.AddWithValue("@RE", dados.REControleAcesso1);
                sql.Parameters.AddWithValue("@POSTO", dados.POSTOGRADControleAcesso1);
                sql.Parameters.AddWithValue("@RG", dados.TXBRGControleAcesso1);
                sql.Parameters.AddWithValue("@UNIDADE", dados.UNIDADEControleAcesso1);
                sql.Parameters.AddWithValue("@CIA", dados.CIAControleAcesso1);
                sql.Parameters.AddWithValue("@SEÇÃO", dados.SECAOControleAcesso1);
                sql.Parameters.AddWithValue("@CARTÃO", dados.NCARTAOontroleAcesso1);
                sql.Parameters.AddWithValue("@VENCIMENTO", dados.VENCIMENTOControleAcesso1);
                sql.Parameters.AddWithValue("@MARCA", dados.MARCAControleAcesso1);
                sql.Parameters.AddWithValue("@MODELO", dados.MODELOControleAcesso1);
                sql.Parameters.AddWithValue("@EMPLACAMENTO", dados.EMPLACAMENTOControleAcesso1);
                sql.Parameters.AddWithValue("@CIDADE", dados.CIDADEControleAcesso1);
                sql.Parameters.AddWithValue("@COR", dados.CORControleAcesso1);
                sql.Parameters.AddWithValue("@DATA", dados.DATA1);
                sql.Parameters.AddWithValue("@HORA", dados.HORA1);
                sql.Parameters.AddWithValue("@fk_id_ES", dados.Id);
                sql.ExecuteNonQuery();
                MessageBox.Show("ENTRADA CADASTRADA COM SUCESSO !");
                con.FecharConexao();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar" + ex);
                //MessageBox.Show("O número de patrimônio inserido já esta cadastrado! Verifique o numéro e tente novamente!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.FecharConexao();
            }
        }

        public DataTable PesquisarTmd(Pessoas dados)
        {
            try                                                                                                                                // Usar o try para caso ocorra algum erro
            {
                con.Conectar();
                sql = new MySqlCommand("select * from controletmd where  Patrimônio LIKE @Patrimônio", con.con);                                  // comando para buscar dados no BD // Like -> Buscar aproximado
                sql.Parameters.AddWithValue("@Patrimônio", dados.PatrimonioInfo +"%");                                                          // % necessário para busca aproximada funcionar
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = sql;
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataTable PesquisarUsuario(User dado)
        {
            try                                                                                                                                // Usar o try para caso ocorra algum erro
            {
                con.Conectar();
                sql = new MySqlCommand("select * from usuarios where  RE LIKE @RE", con.con);                                  // comando para buscar dados no BD // Like -> Buscar aproximado
                sql.Parameters.AddWithValue("@RE", dado.RE + "%");                                                          // % necessário para busca aproximada funcionar
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = sql;
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataTable PesquisarPc(Pessoas dados)
        {
            try                                                                                                                                // Usar o try para caso ocorra algum erro
            {
                con.Conectar();
                sql = new MySqlCommand("select * from controlepc where  Patrimônio LIKE @Patrimônio", con.con);                                  // comando para buscar dados no BD // Like -> Buscar aproximado
                sql.Parameters.AddWithValue("@Patrimônio", dados.Patrimonio + "%");                                                          // % necessário para busca aproximada funcionar
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = sql;
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataTable PesquisarImpressora(Pessoas dados)
        {
            try                                                                                                                                // Usar o try para caso ocorra algum erro
            {
                con.Conectar();
                sql = new MySqlCommand("select * from controleImpressora where  Patrimônio LIKE @Patrimônio", con.con);                                  // comando para buscar dados no BD // Like -> Buscar aproximado
                sql.Parameters.AddWithValue("@Patrimônio", dados.Patrimonio + "%");                                                          // % necessário para busca aproximada funcionar
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = sql;
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataTable PesquisarRadio(Pessoas dados)
        {
            try                                                                                                                                // Usar o try para caso ocorra algum erro
            {
                con.Conectar();
                sql = new MySqlCommand("select * from controleradio where  Patrimônio LIKE @Patrimônio", con.con);                                  // comando para buscar dados no BD // Like -> Buscar aproximado
                sql.Parameters.AddWithValue("@Patrimônio", dados.Patrimonio + "%");                                                          // % necessário para busca aproximada funcionar
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = sql;
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataTable PesquisarVtr(Pessoas dados)
        {
            try                                                                                                                                // Usar o try para caso ocorra algum erro
            {
                con.Conectar();
                sql = new MySqlCommand("select * from controlevtr where  Patrimônio LIKE @Patrimônio", con.con);                                  // comando para buscar dados no BD // Like -> Buscar aproximado
                sql.Parameters.AddWithValue("@Patrimônio", dados.Patrimonio + "%");                                                              // % necessário para busca aproximada funcionar
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = sql;
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void EditarDadosTmd(Pessoas dados)
        {
            try
            {
                con.Conectar();
                sql = new MySqlCommand("UPDATE controletmd SET Patrimônio = @PatrimonioTmd, Modelo = @ModeloTmd, Serial = @SerialTmd, " +
                    "Local = @LocalTmd, PatrimônioPm = @PatrimonioTmdPM, Observação = @ObservacaoTmd, Foto = @SrcEditarFoto  WHERE id = @id", con.con);   // comando para editar dados no BD
                
                sql.Parameters.AddWithValue("@Id", dados.Id);
                sql.Parameters.AddWithValue("@PatrimonioTmd", dados.Patrimonio);
                sql.Parameters.AddWithValue("@SerialTmd", dados.Serial);
                sql.Parameters.AddWithValue("@PatrimonioTmdPM", dados.PatrimonioPM);
                sql.Parameters.AddWithValue("@ModeloTmd", dados.Modelo);
                sql.Parameters.AddWithValue("@LocalTmd", dados.Local);
                sql.Parameters.AddWithValue("@ObservacaoTmd", dados.Observacao);
                sql.Parameters.AddWithValue("@SrcEditarFoto", dados.SrcEditarFoto);
                sql.ExecuteNonQuery();



                sql = new MySqlCommand("UPDATE controletodos SET Patrimônio = @PatrimonioTmd, Modelo = @ModeloTmd, Serial = @SerialTmd, " +
                    "Local = @LocalTmd, PatrimônioPm = @PatrimonioTmdPM, Observação = @ObservacaoTmd, Foto = @SrcEditarFoto  WHERE id = @id", con.con);   // comando para editar dados no BD

                sql.Parameters.AddWithValue("@Id", dados.Id);
                sql.Parameters.AddWithValue("@PatrimonioTmd", dados.Patrimonio);
                sql.Parameters.AddWithValue("@SerialTmd", dados.Serial);
                sql.Parameters.AddWithValue("@PatrimonioTmdPM", dados.PatrimonioPM);
                sql.Parameters.AddWithValue("@ModeloTmd", dados.Modelo);
                sql.Parameters.AddWithValue("@LocalTmd", dados.Local);
                sql.Parameters.AddWithValue("@ObservacaoTmd", dados.Observacao);
                sql.Parameters.AddWithValue("@SrcEditarFoto", dados.SrcEditarFoto);
                sql.ExecuteNonQuery();
                con.FecharConexao();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao editar" + ex);
                con.FecharConexao();
            }
        }

        public void EditarDadosImpressora(Pessoas dados)
        {
            try
            {
                con.Conectar();
                sql = new MySqlCommand("UPDATE controleimpressora SET Patrimônio = @PatrimonioTmd, Modelo = @ModeloTmd, Serial = @SerialTmd, " +
                    "Local = @LocalTmd, PatrimônioPm = @PatrimonioTmdPM, Observação = @ObservacaoTmd, Foto = @SrcEditarFoto  WHERE id = @id", con.con);   // comando para editar dados no BD

                sql.Parameters.AddWithValue("@Id", dados.Id);
                sql.Parameters.AddWithValue("@PatrimonioTmd", dados.Patrimonio);
                sql.Parameters.AddWithValue("@SerialTmd", dados.Serial);
                sql.Parameters.AddWithValue("@PatrimonioTmdPM", dados.PatrimonioPM);
                sql.Parameters.AddWithValue("@ModeloTmd", dados.Modelo);
                sql.Parameters.AddWithValue("@LocalTmd", dados.Local);
                sql.Parameters.AddWithValue("@ObservacaoTmd", dados.Observacao);
                sql.Parameters.AddWithValue("@SrcEditarFoto", dados.SrcEditarFoto);
                sql.ExecuteNonQuery();



                sql = new MySqlCommand("UPDATE controletodos SET Patrimônio = @PatrimonioTmd, Modelo = @ModeloTmd, Serial = @SerialTmd, " +
                    "Local = @LocalTmd, PatrimônioPm = @PatrimonioTmdPM, Observação = @ObservacaoTmd, Foto = @SrcEditarFoto  WHERE id = @id", con.con);   // comando para editar dados no BD

                sql.Parameters.AddWithValue("@Id", dados.Id);
                sql.Parameters.AddWithValue("@PatrimonioTmd", dados.Patrimonio);
                sql.Parameters.AddWithValue("@SerialTmd", dados.Serial);
                sql.Parameters.AddWithValue("@PatrimonioTmdPM", dados.PatrimonioPM);
                sql.Parameters.AddWithValue("@ModeloTmd", dados.Modelo);
                sql.Parameters.AddWithValue("@LocalTmd", dados.Local);
                sql.Parameters.AddWithValue("@ObservacaoTmd", dados.Observacao);
                sql.Parameters.AddWithValue("@SrcEditarFoto", dados.SrcEditarFoto);
                sql.ExecuteNonQuery();
                con.FecharConexao();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao editar" + ex);
                con.FecharConexao();
            }
        }


        public void EditarVtr(Pessoas dados)
        {
            try
            {
                con.Conectar();
                sql = new MySqlCommand("UPDATE controlevtr SET Patrimônio = @Patrimonio, Modelo = @Modelo, Local = @Local, " +
                    "Observação = @Observação, Foto = @SrcEditarFoto, Placa = @Placa, Prefixo = @Prefixo  WHERE id = @id", con.con);   // comando para editar dados no BD

                sql.Parameters.AddWithValue("@Id", dados.Id);
                sql.Parameters.AddWithValue("@Patrimonio", dados.Patrimonio);
                sql.Parameters.AddWithValue("@Modelo", dados.Modelo);
                sql.Parameters.AddWithValue("@Local", dados.Local);
                sql.Parameters.AddWithValue("@Observação", dados.Observacao);               
                sql.Parameters.AddWithValue("@Placa", dados.Placa);
                sql.Parameters.AddWithValue("@Prefixo", dados.Prefixo);
                sql.Parameters.AddWithValue("@SrcEditarFoto", dados.SrcEditarFoto);
                sql.ExecuteNonQuery();
                MessageBox.Show("Salvo com Sucesso!");



                sql = new MySqlCommand("UPDATE controletodos SET Patrimônio = @Patrimonio, Modelo = @Modelo, Local = @Local, " +
                    "Observação = @Observação, Foto = @SrcEditarFoto, Placa = @Placa, Prefixo = @Prefixo  WHERE id = @id", con.con);   // comando para editar dados no BD

                sql.Parameters.AddWithValue("@Id", dados.Id);
                sql.Parameters.AddWithValue("@Patrimonio", dados.Patrimonio);
                sql.Parameters.AddWithValue("@Modelo", dados.Modelo);
                sql.Parameters.AddWithValue("@Local", dados.Local);
                sql.Parameters.AddWithValue("@Observação", dados.Observacao);
                sql.Parameters.AddWithValue("@Placa", dados.Placa);
                sql.Parameters.AddWithValue("@Prefixo", dados.Prefixo);
                sql.Parameters.AddWithValue("@SrcEditarFoto", dados.SrcEditarFoto);
                sql.ExecuteNonQuery();
                con.FecharConexao();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao editar" + ex);
                con.FecharConexao();
            }
        }

        public void EditarDadosPc(Pessoas dados)
        {
            try
            {
                con.Conectar();
                sql = new MySqlCommand("UPDATE controlepc SET Patrimônio = @PatrimonioTmd, Modelo = @ModeloTmd, Serial = @SerialTmd, " +
                    "Local = @LocalTmd, PatrimônioPm = @PatrimonioTmdPM, Observação = @ObservacaoTmd, Foto = @SrcEditarFoto  WHERE id = @id", con.con);   // comando para editar dados no BD

                sql.Parameters.AddWithValue("@Id", dados.Id);
                sql.Parameters.AddWithValue("@PatrimonioTmd", dados.Patrimonio);
                sql.Parameters.AddWithValue("@SerialTmd", dados.Serial);
                sql.Parameters.AddWithValue("@PatrimonioTmdPM", dados.PatrimonioPM);
                sql.Parameters.AddWithValue("@ModeloTmd", dados.Modelo);
                sql.Parameters.AddWithValue("@LocalTmd", dados.Local);
                sql.Parameters.AddWithValue("@ObservacaoTmd", dados.Observacao);
                sql.Parameters.AddWithValue("@SrcEditarFoto", dados.SrcEditarFoto);
                sql.ExecuteNonQuery();



                sql = new MySqlCommand("UPDATE controletodos SET Patrimônio = @PatrimonioTmd, Modelo = @ModeloTmd, Serial = @SerialTmd, " +
                    "Local = @LocalTmd, PatrimônioPm = @PatrimonioTmdPM, Observação = @ObservacaoTmd, Foto = @SrcEditarFoto  WHERE id = @id", con.con);   // comando para editar dados no BD

                sql.Parameters.AddWithValue("@Id", dados.Id);
                sql.Parameters.AddWithValue("@PatrimonioTmd", dados.Patrimonio);
                sql.Parameters.AddWithValue("@SerialTmd", dados.Serial);
                sql.Parameters.AddWithValue("@PatrimonioTmdPM", dados.PatrimonioPM);
                sql.Parameters.AddWithValue("@ModeloTmd", dados.Modelo);
                sql.Parameters.AddWithValue("@LocalTmd", dados.Local);
                sql.Parameters.AddWithValue("@ObservacaoTmd", dados.Observacao);
                sql.Parameters.AddWithValue("@SrcEditarFoto", dados.SrcEditarFoto);
                sql.ExecuteNonQuery();
                con.FecharConexao();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao editar" + ex);
                con.FecharConexao();
            }
        }


        public void EditarDadosRadio(Pessoas dados)
        {
            try
            {
                con.Conectar();
                sql = new MySqlCommand("UPDATE controleradio SET Patrimônio = @PatrimonioTmd, Modelo = @ModeloTmd, Serial = @SerialTmd, " +
                    "Local = @LocalTmd, PatrimônioPm = @PatrimonioTmdPM, Observação = @ObservacaoTmd, Foto = @SrcEditarFoto  WHERE id = @id", con.con);   // comando para editar dados no BD

                sql.Parameters.AddWithValue("@Id", dados.Id);
                sql.Parameters.AddWithValue("@PatrimonioTmd", dados.Patrimonio);
                sql.Parameters.AddWithValue("@SerialTmd", dados.Serial);
                sql.Parameters.AddWithValue("@PatrimonioTmdPM", dados.PatrimonioPM);
                sql.Parameters.AddWithValue("@ModeloTmd", dados.Modelo);
                sql.Parameters.AddWithValue("@LocalTmd", dados.Local);
                sql.Parameters.AddWithValue("@ObservacaoTmd", dados.Observacao);
                sql.Parameters.AddWithValue("@SrcEditarFoto", dados.SrcEditarFoto);
                sql.ExecuteNonQuery();



                sql = new MySqlCommand("UPDATE controletodos SET Patrimônio = @PatrimonioTmd, Modelo = @ModeloTmd, Serial = @SerialTmd, " +
                    "Local = @LocalTmd, PatrimônioPm = @PatrimonioTmdPM, Observação = @ObservacaoTmd, Foto = @SrcEditarFoto  WHERE id = @id", con.con);   // comando para editar dados no BD

                sql.Parameters.AddWithValue("@Id", dados.Id);
                sql.Parameters.AddWithValue("@PatrimonioTmd", dados.Patrimonio);
                sql.Parameters.AddWithValue("@SerialTmd", dados.Serial);
                sql.Parameters.AddWithValue("@PatrimonioTmdPM", dados.PatrimonioPM);
                sql.Parameters.AddWithValue("@ModeloTmd", dados.Modelo);
                sql.Parameters.AddWithValue("@LocalTmd", dados.Local);
                sql.Parameters.AddWithValue("@ObservacaoTmd", dados.Observacao);
                sql.Parameters.AddWithValue("@SrcEditarFoto", dados.SrcEditarFoto);
                sql.ExecuteNonQuery();
                con.FecharConexao();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao editar" + ex);
                con.FecharConexao();
            }
        }

        public void EditarUsuario(User dado)
        {
            try
            {
                con.Conectar();
                sql = new MySqlCommand("UPDATE usuarios SET RE = @RE, Nome = @Nome, Senha = @Senha, " +
                    "EMAIL = @EMAIL, Função = @Função  WHERE id = @id", con.con);   // comando para editar dados no BD

                sql.Parameters.AddWithValue("@Id", dado.Id);
                sql.Parameters.AddWithValue("@RE", dado.RE);
                sql.Parameters.AddWithValue("@Nome", dado.Nome);
                sql.Parameters.AddWithValue("@Senha", dado.Senha);
                sql.Parameters.AddWithValue("@EMAIL", dado.EMAIL);
                sql.Parameters.AddWithValue("@Função", dado.Função);
                sql.ExecuteNonQuery();                              
                con.FecharConexao();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao editar" + ex);
                con.FecharConexao();
            }
        }

        public void ExcluirTmd(Pessoas dados)
        {
            try
            {
                con.Conectar();
                sql = new MySqlCommand("DELETE FROM controletmd WHERE id = @id", con.con);  // Comando para exclusão de dados no BD
                sql.Parameters.AddWithValue("@Id", dados.Id);
                sql.ExecuteNonQuery();
                con.FecharConexao();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Excluir" + ex);
                con.FecharConexao();
            }
        }

        public void ExcluirPc(Pessoas dados)
        {
            try
            {
                con.Conectar();
                sql = new MySqlCommand("DELETE FROM controlepc WHERE id = @id", con.con);  // Comando para exclusão de dados no BD
                sql.Parameters.AddWithValue("@Id", dados.Id);
                sql.ExecuteNonQuery();
                con.FecharConexao();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Excluir" + ex);
                con.FecharConexao();
            }
        }


        public void ExcluirUsuario(Pessoas dados)
        {
            try
            {
                con.Conectar();
                sql = new MySqlCommand("DELETE FROM usuarios WHERE id = @id", con.con);  // Comando para exclusão de dados no BD
                sql.Parameters.AddWithValue("@Id", dados.Id);
                sql.ExecuteNonQuery();
                MessageBox.Show("Excluido com Sucesso!");
                con.FecharConexao();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Excluir" + ex);
                con.FecharConexao();
            }
        }

        public void ExcluirVtr(Pessoas dados)
        {
            try
            {
                con.Conectar();
                sql = new MySqlCommand("DELETE FROM controlevtr WHERE id = @id", con.con);  // Comando para exclusão de dados no BD
                sql.Parameters.AddWithValue("@Id", dados.Id);
                sql.ExecuteNonQuery();
                MessageBox.Show("Excluido com Sucesso!");
                con.FecharConexao();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Excluir" + ex);
                con.FecharConexao();
            }
        }

        public void ExcluirRadio(Pessoas dados)
        {
            try
            {
                con.Conectar();
                sql = new MySqlCommand("DELETE FROM controleradio WHERE id = @id", con.con);  // Comando para exclusão de dados no BD
                sql.Parameters.AddWithValue("@Id", dados.Id);
                sql.ExecuteNonQuery();
                MessageBox.Show("Excluido com Sucesso!");
                con.FecharConexao();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Excluir" + ex);
                con.FecharConexao();
            }
        }

        public void ExcluirTodos(Pessoas dados)
        {
            try
            {
                con.Conectar();
                sql = new MySqlCommand("DELETE FROM controletodos WHERE id = @id", con.con);  // Comando para exclusão de dados no BD
                sql.Parameters.AddWithValue("@Id", dados.Id);
                sql.ExecuteNonQuery();
                con.FecharConexao();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Excluir" + ex);
                con.FecharConexao();
            }
        }

        public static byte[] ConvertImageToByte(System.Drawing.Image image)     // Metodo para converter Image em Byte
        {
            if (image == null)
                return null;

            byte[] data;

            using (MemoryStream stream = new MemoryStream())
            {
                Bitmap bmp = new Bitmap(image);
                bmp.Save(stream, ImageFormat.Jpeg);
                data = stream.ToArray();
            }

            return data;
        }


        public void Login(User dados)
        {
            try
            {
                con.Conectar();
                sql = new MySqlCommand("DELETE FROM controletmd WHERE id = @id", con.con);  // Comando para exclusão de dados no BD
                sql.Parameters.AddWithValue("@Id", dados.Id);
                sql.ExecuteNonQuery();
                con.FecharConexao();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Excluir" + ex);
                con.FecharConexao();
            }
        }






    } 



}
