import React, {useEffect, useState} from 'react';
import './Login.css';
import {Grid, Paper, Avatar, TextField, Button} from '@mui/material'
import HeaderUser from './HeaderUser'
import axios from 'axios'
import { useNavigate } from 'react-router'
import Cookies from 'universal-cookie'
import { green, red } from '@mui/material/colors';

const cookies = new Cookies();

const AccountUpdate = () => {

  const [telephonePut,setTelephone] = React.useState("")
  const [emailPut,setEmail] = React.useState("")
  const [usernamePut,setUsername] = React.useState("")
  const [passwordPut,setPassword] = React.useState("")

  var id = cookies.get('id')
  var card = cookies.get('cardIdentification')
  var name = cookies.get('name')
  var lastName = cookies.get('lastName')
  var telephone = cookies.get('telephone')
  var user = cookies.get('username')
  var email = cookies.get('email')
  var numberHouse = cookies.get('numberHouse')

  const navigate = useNavigate()

    const paperStyle = {padding: 20, heigth: '70vh', width: 350, margin: "10px auto"}

    const handleSubmitUpdate = async (e) => {
      e.preventDefault() //evitar el recargar la pagina

      if(errorTelephone === true || errorEmail === true || errorPassword === true || errorUsername === true){
        alert("Incorrectly filled fields")
      }else{
        try {
        const response = await axios.put(`http://localhost:3000/owners/${cookies.get('id')}`,
        {
          id: id,
          ownerCard: card,
          ownerName: name,
          ownerLastName: lastName,
          ownerTelephone: telephonePut,
          ownerEmail: emailPut,
          ownerUsername: usernamePut,
          ownerPassword: passwordPut,
          ownerNumberHouse: numberHouse,
          ownerType: "owner"
        }
        ) 
        .then(response => {
          alert('Register was Ppdate')
          navigate({
            pathname: '/account'
          })
        })  
        cookies.set('username', usernamePut, {path: "/"})
      } catch (error) {
        console.log(error.message)
        alert("Connection problems.\n"+ error.message)
      }
  
    }}

  /*Sesiones*/
    useEffect(() => {
        if (typeof cookies.get('username') === 'undefined' ) {
            window.location.href = "./"
        }
    })

    useEffect(() => {
        if (cookies.get('ownerType') === "admin") {
            window.location.href = "./OwnerController"
        }
    })
    
    /*Validaciones */
    const expressions  = {
      username: /^[a-zA-Z0-9_-]{4,16}$/, // Letras, numeros, guion y guion_bajo
      name: /^[a-zA-ZÀ-ÿ\s]{1,40}$/, // Letras y espacios, pueden llevar acentos.
      password: /^.{4,17}$/, // 4 a 17 digitos.
      email: /^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$/,
      telephone: /^\d{7,10}$/ // 7 a 10 numeros.
    }
    const [validationTelephone, setValidationTelephone] = useState("")
    const [errorTelephone, setErrorTelephone] = useState(false)
    const [validationEmail, setValidationEmail] = useState("")
    const [errorEmail, setErrorEmail] = useState(false)
    const [validationUsername, setValidationUsername] = useState("")
    const [errorUsername, setErrorUsername] = useState(false)
    const [validationPassword, setValidationPassword] = useState("")
    const [errorPassword, setErrorPassword] = useState(false)



    const onChangeTelephone = (e) =>{
      setTelephone(e.target.value)
      console.log(telephonePut)

      if(expressions .telephone.test(telephonePut)){

        setValidationTelephone("Correct telephone")
        setErrorTelephone(false) 
      }else{
        setValidationTelephone("Wrong telephone, Only number 7 to 10")
        setErrorTelephone(true) 
      }

    }

    const onChangeEmail = (e) =>{
      setEmail(e.target.value)
      console.log(emailPut)

      if(expressions .email.test(emailPut)){

        setValidationEmail("Correct Email")
        setErrorEmail(false) 
      }else{
        setValidationEmail("Wrong email, example: pepito@gmail.com")
        setErrorEmail(true) 
      }

    }

    const onChangeUsername = (e) =>{
      setUsername(e.target.value)
      console.log(usernamePut)

      if(expressions .username.test(usernamePut)){

        setValidationUsername("Correct User")
        setErrorUsername(false) 
      }else{
        setValidationUsername("Wrong User, example: Pepito15")
        setErrorUsername(true) 
      }

    }

    const onChangePassword = (e) =>{
      setPassword(e.target.value)
      console.log(passwordPut)

      if(expressions .password.test(passwordPut)){

        setValidationPassword("Correct Password")
        setErrorPassword(false) 
      }else{
        setValidationPassword("Wrong password, example: pepito123456")
        setErrorPassword(true) 
      }

    }

    const cancel =() => {
      navigate({
          pathname: '/account'
      })
  }

    return (
      
      <Grid>
          <Grid><HeaderUser/></Grid> 
          <form onSubmit = { handleSubmitUpdate } className = "LogIn-margenT">
            <Paper elevation = {10} style = {paperStyle}  >
                <Grid>
                    <center>
                      <h1>My Account</h1>
                      <Avatar>{cookies.get('name').charAt(0)}</Avatar>
                    </center>
                </Grid>

                <TextField 
                  sx={{ m: 2, width: 300}} 
                  label = "Telephone" 
                  placeholder= {telephone} 
                  value={telephonePut} 
                  error = {errorTelephone}
                  helperText = {validationTelephone}
                  onChange={(onChangeTelephone)}
                  onBlur={(onChangeTelephone)}
                ></TextField>

                <TextField 
                  sx={{ m: 2, width: 300}} 
                  label = "Email" 
                  placeholder= {email} 
                  value={emailPut} 
                  error = {errorEmail}
                  helperText = {validationEmail}
                  onChange={(onChangeEmail)}
                  onBlur={(onChangeEmail)}
                ></TextField><br></br>

                <TextField 
                  sx={{ m: 2, width: 300}} 
                  label = "User" 
                  placeholder= {user} 
                  value={usernamePut} 
                  error = {errorUsername}
                  helperText = {validationUsername}
                  onChange={(onChangeUsername)}
                  onBlur={(onChangeUsername)}
                ></TextField><br></br>

                <TextField 
                  sx={{ m: 2, width: 300}} 
                  label = "Password" 
                  type="password" 
                  placeholder= 'New password' 
                  value={passwordPut} 
                  error = {errorPassword}
                  helperText = {validationPassword}
                  onChange={(onChangePassword)}
                  onBlur={(onChangePassword)}
                ></TextField><br></br>

                <div className="row justify-content-center">
                  <Button className='btn-back' color='success' variant="contained" 
                      variant="contained"
                      size = "large"
                      type = "submit"
                      sx={{ bgcolor: green[500], height: '50px', width: '90px', color: 'black'}} 
                  >
                      Edit
                  </Button>
                  &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                  <Button className='btn-back' color= 'error' variant="contained" 
                      variant="contained"
                      size = "large"
                      onClick = {cancel}
                      sx={{ bgcolor: red[500], height: '50px', width: '90px', color: 'black'}} 
                  >
                      Cancel
                  </Button>
              </div> 

            </Paper>
          </form>

      </Grid>
      
    )
  }
  
  export default AccountUpdate