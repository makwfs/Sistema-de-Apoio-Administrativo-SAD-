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
    public class PessoaDAO  //Camada 3
    {
        MySqlCommand sql;
        Conexao con = new Conexao();
        
        
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

        public void CadastroTmd(Pessoas dados)
        {
            
            try
            {
                con.Conectar();
                sql = new MySqlCommand("INSERT INTO controletmd (id, Patrimônio, Modelo, Serial, Local, PatrimônioPm, Observação,Foto) values (@Id, @Patrimônio, @Modelo, @Serial, @Local, @PatrimonioPm, @Observação, @Foto)", con.con);  // inclusão de dados no BD pessoa
                sql.Parameters.AddWithValue("@id", dados.PatrimonioTmd1);
                sql.Parameters.AddWithValue("@Patrimônio", dados.PatrimonioTmd1);
                sql.Parameters.AddWithValue("@Modelo", dados.ModeloTmd1);
                sql.Parameters.AddWithValue("@Serial", dados.SerialTmd1);
                sql.Parameters.AddWithValue("@Local", dados.LocalTmd1);
                sql.Parameters.AddWithValue("@PatrimonioPm", dados.PatrimonioPMTmd1);
                sql.Parameters.AddWithValue("@Observação", dados.ObservacaoTmd1);
                sql.Parameters.AddWithValue("@Foto", dados.SrcFotoTmd1);
                sql.ExecuteNonQuery();

                
                

                /*
                sql = new MySqlCommand("INSERT INTO controletodos (id, Patrimônio, Modelo, Serial, Local, PatrimônioPm, Observação) values (@Id, @Patrimônio, @Modelo, @Serial, @Local, @PatrimonioPm, @Observação)", con.con);
                sql.Parameters.AddWithValue("@Id", dados.PatrimonioTmd1);
                sql.Parameters.AddWithValue("@Patrimônio", dados.PatrimonioTmd1);
                sql.Parameters.AddWithValue("@Modelo", dados.ModeloTmd1);
                sql.Parameters.AddWithValue("@Serial", dados.SerialTmd1);
                sql.Parameters.AddWithValue("@Local", dados.LocalTmd1);
                sql.Parameters.AddWithValue("@PatrimonioPm", dados.PatrimonioPMTmd1);
                sql.Parameters.AddWithValue("@Observação", dados.ObservacaoTmd1);
                sql.ExecuteNonQuery();*/
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
                sql = new MySqlCommand("INSERT INTO controlepc (id, Patrimônio, Modelo, Serial, Local, PatrimônioPm, Observação,Foto) values (@Id, @Patrimônio, @Modelo, @Serial, @Local, @PatrimonioPm, @Observação, @Foto )", con.con);  // inclusão de dados no BD pessoa
                sql.Parameters.AddWithValue("@id", dados.PatrimonioPc1);
                sql.Parameters.AddWithValue("@Patrimônio", dados.PatrimonioPc1);
                sql.Parameters.AddWithValue("@Modelo", dados.ModeloPc1);
                sql.Parameters.AddWithValue("@Serial", dados.SerialPc1);
                sql.Parameters.AddWithValue("@Local", dados.LocalPc1);
                sql.Parameters.AddWithValue("@PatrimonioPm", dados.PatrimonioPMPc1);
                sql.Parameters.AddWithValue("@Observação", dados.ObservacaoPc1);
                sql.Parameters.AddWithValue("@Foto", dados.SrcFotoPc1);
                sql.ExecuteNonQuery();




                /*
                sql = new MySqlCommand("INSERT INTO controletodos (id, Patrimônio, Modelo, Serial, Local, PatrimônioPm, Observação) values (@Id, @Patrimônio, @Modelo, @Serial, @Local, @PatrimonioPm, @Observação)", con.con);
                sql.Parameters.AddWithValue("@Id", dados.PatrimonioTmd1);
                sql.Parameters.AddWithValue("@Patrimônio", dados.PatrimonioTmd1);
                sql.Parameters.AddWithValue("@Modelo", dados.ModeloTmd1);
                sql.Parameters.AddWithValue("@Serial", dados.SerialTmd1);
                sql.Parameters.AddWithValue("@Local", dados.LocalTmd1);
                sql.Parameters.AddWithValue("@PatrimonioPm", dados.PatrimonioPMTmd1);
                sql.Parameters.AddWithValue("@Observação", dados.ObservacaoTmd1);
                sql.ExecuteNonQuery();*/
                con.FecharConexao();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar 1" + ex);
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
                sql.Parameters.AddWithValue("@Patrimônio", dados.PatrimonioTmd1 +"%");                                                          // % necessário para busca aproximada funcionar
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

    } 
}
