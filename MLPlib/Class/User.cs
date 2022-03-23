using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Data;

namespace MLPlib.Class
{
    public class User
    {
        public int IDUser { get; set; }
        public string Username { get; set; }
        public string Pin { get; set; }
        public DateTime RegDate { get; set; }
        public bool Active { get; set; }


        public User()
        {

        }

        public int CreateUser()
        {
            SistemaMLPDataSetTableAdapters.UserTableAdapter userTableAdapter = new SistemaMLPDataSetTableAdapters.UserTableAdapter();

            int result = (int)userTableAdapter.SPInsertUser(this.Username, EncriptarEnUnSentido(this.Pin));

            return result;
        }

        public int UpdateUser(string NewPin)
        {
            SistemaMLPDataSetTableAdapters.UserTableAdapter userTableAdapter = new SistemaMLPDataSetTableAdapters.UserTableAdapter();

            int result = (int)userTableAdapter.SPUpdateUser(this.IDUser, EncriptarEnUnSentido(this.Pin), EncriptarEnUnSentido(NewPin));

            return result;
        }

        public int DeleteUser()
        {
            SistemaMLPDataSetTableAdapters.UserTableAdapter userTableAdapter = new SistemaMLPDataSetTableAdapters.UserTableAdapter();

            int result = (int)userTableAdapter.SPDeleteUser(this.IDUser);

            return result;
        }

        public DataTable GetUsers()
        {
            SistemaMLPDataSet sistemaMLPDataSet = new SistemaMLPDataSet();
            SistemaMLPDataSetTableAdapters.UserTableAdapter userTableAdapter = new SistemaMLPDataSetTableAdapters.UserTableAdapter();


            userTableAdapter.Fill(sistemaMLPDataSet.User);
            return sistemaMLPDataSet.User;

        }

        public string EncriptarEnUnSentido(string Entrada)
        {

            SHA256CryptoServiceProvider ProveedorCrypto = new SHA256CryptoServiceProvider();

            //Descompone la cadenaDeEntrada en Bytes
            byte[] BytesDeEntrada = Encoding.UTF8.GetBytes(Entrada);

            //Usando los bytes de la cadena de entrada crea el Hash
            byte[] BytesConHash = ProveedorCrypto.ComputeHash(BytesDeEntrada);

            StringBuilder Resultado = new StringBuilder();

            //el for recorre cada byte del Hash y lo agrega a una cadena (stringbuilder)
            for (int i = 0; i < BytesConHash.Length; i++)
                Resultado.Append(BytesConHash[i].ToString("x2").ToLower());
            // el x2 lo que hace es poner los caracteres hexadecimales con cierto formato.

            return Resultado.ToString();

        }

    }
}
