using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Common.Cache;
using System.Runtime.Remoting.Messaging;
using System.Xml.Linq;
using System.Net;
using System.Security.Policy;
using System.Security.Cryptography;
using System.Data.SqlTypes;

namespace DataAccess
{
    public class UserDao:ConnectionToSql
    {
        public void editProfile(string id, string name, string mail, string photo, string phone)
        {
            using(var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "UPDATE PEEMP_EMPLE " +
                        "SET PEEMP_EMPLE.PEEMP_NOMBRE = @name, PEEMP_EMPLE.PEEMP_EMAIL = @mail, PEEMP_EMPLE.PEEMP_FOTO = @photo , PEEMP_EMPLE.PEEMP_TELEFO = @phone " +
                        "FROM PEEMP_EMPLE " +
                        "INNER JOIN XEUSU_USUAR ON PEEMP_EMPLE.PEEMP_CODIGO = XEUSU_USUAR.PEEMP_CODIGO " +
                        "WHERE PEEMP_EMPLE.PEEMP_CODIGO = @id AND XEUSU_USUAR.XEEST_CODIGO = 'A' ";
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@mail", mail);
                    command.Parameters.AddWithValue("@photo", photo);
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@phone", phone);
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                }
            }
        }
        public void editPassword(string id, string password)
        {
            byte[] data = Encoding.UTF8.GetBytes(password);
            string contraseña;
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] hash = sha256Hash.ComputeHash(data);
                contraseña = BitConverter.ToString(hash).Replace("-", string.Empty);
            }

            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "UPDATE XEUSU_USUAR " +
                        "SET XEUSU_USUAR.XEUSU_PASWD = @pass " +
                        "FROM XEUSU_USUAR " +
                        "INNER JOIN PEEMP_EMPLE ON PEEMP_EMPLE.PEEMP_CODIGO = XEUSU_USUAR.PEEMP_CODIGO " +
                        "WHERE PEEMP_EMPLE.PEEMP_CODIGO = @id AND XEUSU_USUAR.XEEST_CODIGO = 'A'";
                    command.Parameters.AddWithValue("@pass", contraseña);
                    command.Parameters.AddWithValue("@id", id);
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                }
            }
        }
        public bool Login(string user, string pass)
        {
            byte[] data = Encoding.UTF8.GetBytes(pass);
            string contraseña;
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] hash = sha256Hash.ComputeHash(data);
                contraseña = BitConverter.ToString(hash).Replace("-", string.Empty);
            }

            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT PEEMP_EMPLE.PEEMP_CODIGO,PEEMP_EMPLE.PEEMP_NOMBRE, " +
                    "PEEMP_EMPLE.PEEMP_APELLIDO,PEEMP_EMPLE.PEEMP_DIRECC, " +
                    "PEEMP_EMPLE.PEEMP_TELEFO,PEEMP_EMPLE.PEEMP_EMAIL, " +
                    "PEEMP_EMPLE.PEEMP_CEDULA,PEEMP_EMPLE.PEEMP_FECNAC,PEEMP_EMPLE.PEEMP_FECINGRESO,PEEMP_EMPLE.PEEMP_FECSAL, " +
                    "PEEMP_EMPLE.PEEMP_FOTO,PEEMP_EMPLE.PEEMP_CARFAM,PEEMP_EMPLE.PEEMP_PASAPO, " +
                    "PEEMP_EMPLE.PEEMP_DISCAPA " +
                    "FROM PEEMP_EMPLE " +
                    "INNER JOIN XEUSU_USUAR ON PEEMP_EMPLE.PEEMP_CODIGO = XEUSU_USUAR.PEEMP_CODIGO " +
                    "WHERE PEEMP_EMPLE.PEEMP_EMAIL = @user AND XEUSU_USUAR.XEUSU_PASWD = @pass AND XEUSU_USUAR.XEEST_CODIGO = 'A'";
                    command.Parameters.AddWithValue("@user", user);
                    command.Parameters.AddWithValue("@pass", contraseña);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            UserLoginCache.IdUser = reader.GetString(0);
                            UserLoginCache.Name = reader.GetString(1);
                            UserLoginCache.LastName = reader.GetString(2);
                            UserLoginCache.Address = reader.GetString(3);
                            UserLoginCache.Phone = reader.GetString(4);
                            UserLoginCache.Email = reader.GetString(5);
                            UserLoginCache.Dni = reader.GetString(6);
                            UserLoginCache.DateBirth = reader.GetDateTime(7);
                            UserLoginCache.DateAdmission = reader.GetDateTime(8);
                            UserLoginCache.DateDeparture = reader.GetDateTime(9);
                            UserLoginCache.Photo = reader.GetString(10);
                            UserLoginCache.CarFarm = reader.GetDecimal(11);
                            UserLoginCache.Passport = reader.GetString(12);
                            UserLoginCache.Password = pass;
                        }
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }

        public string recoverPassword(string userRequesting)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT PEEMP_EMPLE.PEEMP_CODIGO,PEEMP_EMPLE.PEEMP_NOMBRE, " +
                    "PEEMP_EMPLE.PEEMP_EMAIL, " +
                    "XEUSU_USUAR.XEUSU_PASWD " +
                    "FROM PEEMP_EMPLE " +
                    "INNER JOIN XEUSU_USUAR ON PEEMP_EMPLE.PEEMP_CODIGO = XEUSU_USUAR.PEEMP_CODIGO " +
                    "WHERE PEEMP_EMPLE.PEEMP_CEDULA=@user OR PEEMP_EMPLE.PEEMP_EMAIL=@mail";

                    command.Parameters.AddWithValue("@user", userRequesting);
                    command.Parameters.AddWithValue("@mail", userRequesting);

                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read() == true)
                    {
                        string id = reader.GetString(0);
                        string userName = reader.GetString(1);
                        string userMail = reader.GetString(2);
                        string accountPassword = reader.GetString(3);
                        string temporal = calcularContraseñaTemporal();
                        UserLoginCache.RecPassword = temporal;
                        UserLoginCache.IdUser = id;
                        UserLoginCache.Email = userMail;
                        var mailService = new MailService.SystemSupportMail();
                        mailService.sendMail(
                            subject: "SOPORTE MONSTER: Solicitud de recuperación de contraseña",
                            body: "Hola, " + userName + "\nSolicitaste recuperar tu contraseña.\n" +
                            "Tu contraseña temporal es: " + temporal +
                            "\nPresiona sobre (Continuar) en la aplicación."+
                            "\nDeberás cambiar la contraseña antes de que finalice el tiempo dado.",
                            recipentMail: new List<string> { userMail }
                            );
                        return "Hola, " + userName + "\nSolicitaste recuperar tu contraseña.\n" +
                            "Por favor, verifica tu correo: " + userMail +
                            "\nDeberás seguir las instrucciónes.";
                    }
                    else
                    {
                        return "Lo sentimos, no existe una cuenta con ese nombre de usuario o correo.";
                    }
                }
            }
        }


        public string registrarContraseña(string userRequesting,string temporal)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT PEEMP_EMPLE.PEEMP_CODIGO,PEEMP_EMPLE.PEEMP_NOMBRE, " +
                    "PEEMP_EMPLE.PEEMP_EMAIL, " +
                    "XEUSU_USUAR.XEUSU_PASWD " +
                    "FROM PEEMP_EMPLE " +
                    "INNER JOIN XEUSU_USUAR ON PEEMP_EMPLE.PEEMP_CODIGO = XEUSU_USUAR.PEEMP_CODIGO " +
                    "WHERE PEEMP_EMPLE.PEEMP_CEDULA=@user OR PEEMP_EMPLE.PEEMP_EMAIL=@mail";

                    command.Parameters.AddWithValue("@user", userRequesting);
                    command.Parameters.AddWithValue("@mail", userRequesting);

                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read() == true)
                    {
                        string id = reader.GetString(0);
                        string userName = reader.GetString(1);
                        string userMail = reader.GetString(2);
                        string accountPassword = reader.GetString(3);
                        UserLoginCache.Email = userMail;
                        var mailService = new MailService.SystemSupportMail();
                        mailService.sendMail(
                            subject: "SOPORTE MONSTER: Solicitud de registro de usuario",
                            body: "Hola, " + userName + "\nSe ha registrado correctamente.\n" +
                            "Tu contraseña temporal es: " + temporal +
                            "\nEn la siguiente pantalla deberás ingresar el código facilitado." +
                            "\nDeberás cambiar la contraseña antes de que finalice el tiempo dado."+
                            "\nCaso contrario deberás acceder a la opción de olvido de contraseña en el apartado de acceso.",
                            recipentMail: new List<string> { userMail }
                            );
                        return "Hola, " + userName + "\nte registraste en una cuenta.\n" +
                            "Por favor, verifica tu correo: " + userMail +
                            "\nDeberás seguir las instrucciónes para poder ingresar.";
                    }
                    else
                    {
                        return "Lo sentimos, no existe una cuenta con ese nombre de usuario o correo.";
                    }
                }
            }
        }



        private string calcularContraseñaTemporal()
        {
            int length = 10;  
            string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";  
            char[] code = new char[length];
            Random random = new Random();

            for (int i = 0; i < length; i++)
            {
                code[i] = characters[random.Next(characters.Length)];
            }
            return new string(code);
        }


        public void saveProfileData(string idUser,string name, string lastName, string address, string phone,
            string email, string dni, DateTime dateBirth, string photo, string passport, string discapacity)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO PEEMP_EMPLE " +
                        "VALUES(@id,@name,@lastName,@address,@phone,@email,@dni,@birth,'2021-11-09 00:00:00.000','2021-11-09 00:00:00.000',@photo,'100', " +
                        "@passport,0) ";
                    command.Parameters.AddWithValue("@id", idUser);
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@lastName", lastName);
                    command.Parameters.AddWithValue("@address", address);
                    command.Parameters.AddWithValue("@phone", phone);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@dni", dni);
                    command.Parameters.AddWithValue("@birth", dateBirth);
                    command.Parameters.AddWithValue("@photo", photo);
                    command.Parameters.AddWithValue("@passport", passport);
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                }
            }
        }

        public void savePasswordProfile(string idUser, string password)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO XEUSU_USUAR " +
                        "VALUES(@password,'A',@idUser,'2021-11-09 00:00:00.000','2021-11-09 00:00:00.000','NO CONTIENE FIRMA') ";
                    command.Parameters.AddWithValue("@password", password);
                    command.Parameters.AddWithValue("@idUser", idUser);
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                }
            }

        }

        public string comprobarContraseña(string idUser,string password)
        {
            password = calcularContraseñaTemporal();
            UserLoginCache.IdUser = idUser;
            UserLoginCache.RecPassword = password;
            password = calcularContraseñaTemporal();
            byte[] data = Encoding.UTF8.GetBytes(password);
            string contraseña;
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] hash = sha256Hash.ComputeHash(data);
                contraseña = BitConverter.ToString(hash).Replace("-", string.Empty);
            }
            return contraseña;
        }

        public string obtainLastId()
        {
            string lastID = "";
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT TOP 1 PEEMP_EMPLE.PEEMP_CODIGO FROM PEEMP_EMPLE " +
                        "ORDER BY PEEMP_EMPLE.PEEMP_CODIGO DESC ";
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read() == true)
                    {
                        lastID = reader.GetString(0);
                    }
                }
            }
            return lastID;
        }        

        public void AnyMethod()
        {

        }
    }
}
