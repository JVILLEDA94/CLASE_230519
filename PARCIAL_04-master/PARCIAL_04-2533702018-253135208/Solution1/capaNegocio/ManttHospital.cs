using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;

namespace capaNegocio
{
    public class ManttHospital
    {
        bdConex test= new bdConex();
        private int cod1, cod2;

        public int Cod2
        {
            get { return cod2; }
            set { cod2 = value; }
        }

        public int Cod1
        {
            get { return cod1; }
            set { cod1 = value; }
        }
        private String var1, var2, var3;

        public String Var3
        {
            get { return var3; }
            set { var3 = value; }
        }

        public String Var2
        {
            get { return var2; }
            set { var2 = value; }
        }

        public String Var1
        {
            get { return var1; }
            set { var1 = value; }
        }
        public DataTable dt = new DataTable();
    

        public void insertVendor()
        {
            try 
            {
   //             String insert = "INSERT INTO [dbo].[VENDEDOR](VENDEDOR,NOMBRE) VALUES('" + CodVendor + "','" + NombreVendor + "')";
                test.Conectar();
     //           test.consultaSQL(insert);
                test.Desconectar();
            }
            catch
            {
            }

        }

        public void updateVendor()
        {
            try
            {
     //           String update = "update  [dbo].[VENDEDOR] set NOMBRE ='" + nombreVendor + "' where VENDEDOR ='" + codVendor + "'" ;
     //           test.Conectar();
     //           test.consultaSQL(update);
                test.Desconectar();
            }
            catch
            {
            }

        }

        public void deleteVendor()
        {
            try
            {
 //               String update = "delete from  [dbo].[VENDEDOR] where VENDEDOR ='" + codVendor + "'";
                test.Conectar();
      //          test.consultaSQL(update);
                test.Desconectar();
            }
            catch
            {

            }

        }

        public void mostrarVendor()
        {
            try
            {
 //               String consulta = "select * from VENDEDOR";
                test.Conectar();
  //              test.mostrarSQL(consulta);
                test.da.Fill(dt);
                test.Desconectar();
            }
            catch
            {

            }

        }


//DESDE ACA COMIENZAN NUESTRAS TABLAS   

        public void mostrarDoctor()
        {
            try
            {
                String consulta = "select * from [dbo].[Doctor]";
                test.Conectar();
                test.mostrarSQL(consulta);
                test.da.Fill(dt);
                test.Desconectar();
            }
            catch
            {

            }

        }

        public void mostrarEmpleado()
        {
            try
            {
                String consulta = "select * from VENDEDOR";
                test.Conectar();
                test.mostrarSQL(consulta);
                test.da.Fill(dt);
                test.Desconectar();
            }
            catch
            {

            }

        }

        public void mostrarEnfermo()
        {
            try
            {
                String consulta = "select * from VENDEDOR";
                test.Conectar();
                test.mostrarSQL(consulta);
                test.da.Fill(dt);
                test.Desconectar();
            }
            catch
            {

            }

        }

        public void mostrarPlantilla()
        {
            try
            {
                String consulta = "select * from VENDEDOR";
                test.Conectar();
                test.mostrarSQL(consulta);
                test.da.Fill(dt);
                test.Desconectar();
            }
            catch
            {

            }

        }

        public void mostrarDepartamento()
        {
            try
            {
                String consulta = "SELECT [Dept_No],[DNombre],[Loc]FROM [hospital].[hospital].[Dept]";
                test.Conectar();
                test.mostrarSQL(consulta);
                test.da.Fill(dt);
                test.Desconectar();
            }
            catch
            {

            }

        }

        public void mostrarHospital()
        {
            try
            {
                String consulta = "SELECT [Hospital_Cod],[Nombre],[Direccion],[Telefono],[Num_Cama] FROM [hospital].[hospital].[Hospital]";
                test.Conectar();
                test.mostrarSQL(consulta);
                test.da.Fill(dt);
                test.Desconectar();
            }
            catch
            {

            }

        }

        public void mostrarSala()
        {
            try
            {
                String consulta = "";
                test.Conectar();
                test.mostrarSQL(consulta);
                test.da.Fill(dt);
                test.Desconectar();
            }
            catch
            {

            }

        }



        //Desde aca trabajo los insert

        public void insertDoctor()
        {
            try
            {
                String insert = "insert into [dbo].[Doctor] values ('" + Cod1 + "','" + Cod2 + "','" + Var1 + "','" + Var2 + "')";
                test.Conectar();
                test.consultaSQL(insert);
                test.Desconectar();
            }
            catch
            {
            }

        }

        public void insertDepartamento()
        {
            try
            {
                String insert = "insert into [hospital].[Dept] values ('" + Cod1 + "','" + Var1 + "','" + Var2 + "')";
                test.Conectar();
                test.consultaSQL(insert);
                test.Desconectar();
            }
            catch
            {
            }

        }

        public void insertHospital()
        {
            try
            {
                String insert = "insert into [hospital].[hospital] values ('" + Cod1 + "','" + Var1 + "','" + Var2 + "','" + Var3 + "','" + Cod2 + "')";
                test.Conectar();
                test.consultaSQL(insert);
                test.Desconectar();
            }
            catch
            {
            }

        }

        //



        public String prueba()
        {
            String mensaje;
            if (test.Conectar() == true)
            {
                test.Desconectar();
                mensaje = "Conexion realizada";
            }
            else {
                test.Desconectar();
                mensaje = "Conexion no realizada";
            }
            return mensaje;

        }

        //aca comienzan los update

        public void updateDoctor()
        {
            try
            {
                String update = "update  [dbo].[Doctor] set [Hospital_Cod] ='" + Cod2 + "' ,[Apellido] ='" + Var1 + "' [Especialidad] ='" + Var2 + "' where [Doctor_No] ='" + Cod1 + "'";
                          test.Conectar();
                          test.consultaSQL(update);
                test.Desconectar();
            }
            catch
            {
            }

        }

        public void updateDepartamento()
        {
            try
            {
                String update = "update [hospital].[Dept] set [DNombre] ='" + Var1 + "', [Loc] ='" + Var2 + "' where [Dept_No] ='" + Cod1 + "'";
                test.Conectar();
                test.consultaSQL(update);
                test.Desconectar();
            }
            catch
            {
            }

        }

        //aca comienzan los delete

        public void deleteDoctor()
        {
            try
            {
                String update = "delete from  [dbo].[Doctor] where [Doctor_No] ='" + Cod1 + "'";
                test.Conectar();
                test.consultaSQL(update);
                test.Desconectar();
            }
            catch
            {

            }

        }

        public void deleteDepartamento()
        {
            try
            {
                String update = "delete from  [hospital].[Dept] where [Dept_No] ='" + Cod1 + "'";
                test.Conectar();
                test.consultaSQL(update);
                test.Desconectar();
            }
            catch
            {

            }

        }
    }
}
