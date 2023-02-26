using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Common.Cache;

namespace Domain
{
    public class UserModel
    {
        UserDao userDao = new UserDao();

        //Attributes
        private string idUser;
        private string name;
        private string lastName;
        private string address;
        private string phone;
        private string email;
        private string dni;
        private DateTime dateBirth;
        private DateTime dateAdmission;
        private DateTime dateDeparture;
        private string photo;
        private Decimal carFarm;
        private string passport;
        private string discapacity;
        private string password;



        public UserModel(string idUser,string name,string lastName,string address,string phone,
            string email, string dni, DateTime dateBirth, DateTime dateAdmission, DateTime dateDeparture,
            string photo, Decimal carFarm, string passport, string discapacity, string password)
        {
            this.idUser = idUser;
            this.name = name;
            this.lastName = lastName;
            this.address = address;
            this.phone = phone;
            this.email = email;
            this.dni = dni;
            this.dateBirth = dateBirth;
            this.dateAdmission = dateAdmission;
            this.dateDeparture = dateDeparture;
            this.photo = photo;
            this.carFarm = carFarm;
            this.passport = passport;
            this.discapacity = discapacity;
            this.password = password;
        }

        public UserModel(string idUser,string name, string password, string photo, string email,
            string dni, string phone)
        {
            this.idUser = idUser;
            this.name = name;
            this.password = password;
            this.photo = photo;
            this.email = email;
            this.dni = dni;
            this.phone = phone;
        }
        public UserModel()
        {

        }

        public string editUserProfile()
        {
            try
            {
                userDao.editProfile(idUser, name, email, photo, phone);
                userDao.editPassword(idUser,password);
                LoginUser(email, password);
                return "Tu perfil se ha actualizado correctamente.";
            }
            catch (Exception ex)
            {
                return "Ha ocurrido un error " + ex;
            }
        }

        public bool LoginUser(string user, string pass)
        {
            return userDao.Login(user, pass);
        }
        public string recoverPassword(String userRequesting)
        {
            return userDao.recoverPassword(userRequesting);
        }

        public string obtainLastId()
        {
            return userDao.obtainLastId();
        }



        public string saveUser()
        {
            try
            {
                userDao.saveProfileData(idUser, name, lastName, address, phone,
                email, dni,dateBirth,photo,passport,discapacity);
                string valpassword = userDao.comprobarContraseña(idUser,password);
                userDao.savePasswordProfile(idUser, valpassword);
                string val = userDao.registrarContraseña(email, UserLoginCache.RecPassword);
                //LoginUser(email, password);
                return val;
            }
            catch (Exception ex)
            {
                return "Ha ocurrido un error " + ex;
            }
        }

        public string saveNewPassword(String idUserx,String passwordx, String emailx)
        {
            try
            {
                userDao.editPassword(idUserx, passwordx);
                LoginUser(emailx, passwordx);
                return "Contraseña modificada exitosamente";
            }
            catch (Exception ex)
            {
                return "Ha ocurrido un error " + ex;
            }
        }

        public void AnyMethod()
        {

        }
    }
}
