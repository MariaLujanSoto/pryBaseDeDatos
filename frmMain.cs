using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.OleDb;

namespace pryBaseDeDatos
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        //declaraciòn de variables u objetos
        //CREAR LOS OBJETOS PARA CONECTARME A LA BASE DE DATOS
        OleDbConnection objConexion;
        OleDbCommand objComando;
        OleDbDataAdapter objAdaptador;
        OleDbDataReader objDataReader;

        private void btnConexiòn_Click(object sender, EventArgs e)
        {
            objConexion = new OleDbConnection();
            objComando = new OleDbCommand();
            
            try
            {
                string Ruta = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source ="+ Application.StartupPath + "\\NEPTUNO.accdb";
                objConexion.ConnectionString = Ruta;
                objConexion.Open();

                objComando.Connection = objConexion;
                objComando.CommandType = CommandType.TableDirect;
                objComando.CommandText = "SELECT RegiónDestinatario, "+
                    "COUNT(RegiónDestinatario)"+
                    "FROM Pedidos " +
                    "GROUP BY RegiónDestinatario";
               

                //SELECT RegiónDestinatario
                //FROM Pedidos
                //GROUP BY RegiónDestinatario

                objDataReader = objComando.ExecuteReader();

                if (objDataReader.HasRows)
                {
                    while(objDataReader.Read())
                    {
                        LBLdATOS.Text = LBLdATOS.Text + " - " + objDataReader[0]+ "-" + objDataReader[1] + "\n";  //PEDIR LA CANT JUST DE COLUMNAS
                    }
                }
            }
            catch (Exception mensajito)
            {
                MessageBox.Show(mensajito.Message);
                throw;
            }

 

        }

        private void LBLdATOS_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }    
}
