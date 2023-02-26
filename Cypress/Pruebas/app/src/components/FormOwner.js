import React, {useEffect,useState} from 'react';
import '../App.css';
import '../index.css';
import {Box,TextField,Button, Grid} from "@mui/material"
import { green, red, grey } from '@mui/material/colors';
import HeaderAdmin from './HeaderAdmin';
import { useNavigate } from 'react-router'
import axios from 'axios'
import Cookies from 'universal-cookie'

const cookies = new Cookies();

const FormOwner = () => {

    const [ownerCard, setOwnerCard] = React.useState("")
    const [ownerName, setOwnerName] = React.useState("")
    const [ownerLastName, setOwnerLastName] = React.useState("")
    const [ownerTelephone, setOwnerTelephone] = React.useState("")
    const [ownerEmail, setOwnerEmail] = React.useState("")
    const [ownerUsername, setOwnerUsername] = React.useState("")
    const [ownerPassword, setOwnerPassword] = React.useState("")
    const [ownerNumberHouse, setOwnerNumberHouse] = React.useState("")
    const navigate = useNavigate()

    const handleSubmit = async (e) => {
        e.preventDefault() //evitar el recargar la pagina
        if(errorOwnerCard === true || errorOwnerName === true || errorOwnerLastName === true || errorOwnerTelephone === true || errorOwnerEmail === true|| errorOwnerUsername === true|| errorOwnerPassword=== true|| errorOwnerNumberHouse === true){
            alert("Incorrectly filled fields ")
          }else{
            try {
            const ownerUp =""
            const response = await axios.post("http://localhost:3000/owners",
                {
                    ownerCard: ownerCard,
                    ownerName: ownerName,
                    ownerLastName: ownerLastName,
                    ownerTelephone: ownerTelephone,
                    ownerEmail: ownerEmail,
                    ownerUsername: ownerUsername,
                    ownerPassword: ownerPassword,
                    ownerNumberHouse: ownerNumberHouse,
                    ownerType: "owner"
                }
            ).then(response => {
                alert("Owner Added succesfully")
                navigate({
                    pathname: '/OwnerController',
                })
            })
        } catch (error) {
          console.log(error.message)
          alert("Connection problems.\n"+ error.message)
        }
    }}

    const salir = () =>{
        navigate({
            pathname: '/OwnerController',
        })
    }

    /*Sesiones*/
    useEffect(() => {
        if (typeof cookies.get('username') === 'undefined' ) {
            window.location.href = "./"
        }
    })

    useEffect(() => {
        if (cookies.get('ownerType') === "owner") {
            window.location.href = "./account"
        }
    })
      
 /*Validaciones */
 const expressions  = { 
    card: /^\d{10}$/, // 10 Digitos
    name: /^[a-zA-ZÀ-ÿ\s]{1,40}$/, // Letras y espacios, pueden llevar acentos.
    lastName: /^[a-zA-ZÀ-ÿ\s]{1,40}$/, // Letras y espacios, pueden llevar acentos.
    telephone:  /^\d{7,10}$/, // 7 a 10 numeros.
    email: /^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$/,
    username: /^[a-zA-Z0-9_-]{4,16}$/, // Letras, numeros, guion y guion_bajo
    password: /^.{4,17}$/, // 4 a 17 digitos.
    numberHouse: /^\d{1,3}$/ // 1 a 3 numeros.
  }

    const [validationOwnerCard, setValidationOwnerCard] = useState("")
    const [errorOwnerCard, setErrorOwnerCard] = useState(false)
    const [validationOwnerName, setValidationOwnerName] = useState("")
    const [errorOwnerName, setErrorOwnerName] = useState(false)
    const [validationOwnerLastName, setValidationOwnerLastName] = useState("")
    const [errorOwnerLastName, setErrorOwnerLastName] = useState(false)
    const [validationOwnerTelephone, setValidationOwnerTelephone] = useState("")
    const [errorOwnerTelephone, setErrorOwnerTelephone] = useState(false)
    const [validationOwnerEmail, setValidationOwnerEmail] = useState("")
    const [errorOwnerEmail, setErrorOwnerEmail] = useState(false)
    const [validationOwnerUsername, setValidationOwnerUsername] = useState("")
    const [errorOwnerUsername, setErrorOwnerUsername] = useState(false)
    const [validationOwnerPassword, setValidationOwnerPassword] = useState("")
    const [errorOwnerPassword, setErrorOwnerPassword] = useState(false)
    const [validationOwnerNumberHouse, setValidationOwnerNumberHouse] = useState("")
    const [errorOwnerNumberHouse, setErrorOwnerNumberHouse] = useState(false)

    const onChangeOwnerCard = (e) =>{
        setOwnerCard(e.target.value)
        console.log(ownerCard)
  
        if(expressions .card.test(ownerCard)){
  
          setValidationOwnerCard("Correct Identification Card")
          setErrorOwnerCard(false) 
        }else{
          setValidationOwnerCard("Wrong Identification Card, Example: 1729033605")
          setErrorOwnerCard(true) 
        }
  
      }

      const onChangeOwnerName = (e) =>{
        setOwnerName(e.target.value)
        console.log(ownerName)
  
        if(expressions .name.test(ownerName)){
  
          setValidationOwnerName("Correct Name")
          setErrorOwnerName(false) 
        }else{
          setValidationOwnerName("Wrong Name, Example: Pepito")
          setErrorOwnerName(true) 
        }
  
      }

      const onChangeOwnerLastName = (e) =>{
        setOwnerLastName(e.target.value)
        console.log(ownerLastName)
  
        if(expressions .lastName.test(ownerLastName)){
  
          setValidationOwnerLastName("Correct Last Name")
          setErrorOwnerLastName(false) 
        }else{
          setValidationOwnerLastName("Wrong Last Name, Example: Moreno")
          setErrorOwnerLastName(true) 
        }
  
      }

      const onChangeOwnerTelephone = (e) =>{
        setOwnerTelephone(e.target.value)
        console.log(setOwnerTelephone)
  
        if(expressions .telephone.test(ownerTelephone)){
  
          setValidationOwnerTelephone("Correct Telephone")
          setErrorOwnerTelephone(false) 
        }else{
          setValidationOwnerTelephone("Wrong Identification Card, Example: 0998060648-2051735")
          setErrorOwnerTelephone(true) 
        }
  
      }

      const onChangeOwnerEmail = (e) =>{
        setOwnerEmail(e.target.value)
        console.log(ownerEmail)
  
        if(expressions .email.test(ownerEmail)){
  
          setValidationOwnerEmail("Correct Email")
          setErrorOwnerEmail(false) 
        }else{
          setValidationOwnerEmail("Wrong email, example: pepito@gmail.com")
          setErrorOwnerEmail(true) 
        }
  
      }
  
      const onChangeOwnerUsername = (e) =>{
        setOwnerUsername(e.target.value)
        console.log(ownerUsername)
  
        if(expressions .username.test(ownerUsername)){
  
          setValidationOwnerUsername("Correct User")
          setErrorOwnerUsername(false) 
        }else{
          setValidationOwnerUsername("Wrong User, example: Pepito15")
          setErrorOwnerUsername(true) 
        }
  
      }
  
      const onChangeOwnerPassword = (e) =>{
        setOwnerPassword(e.target.value)
        console.log(ownerPassword)
  
        if(expressions .password.test(ownerPassword)){
  
          setValidationOwnerPassword("Correct Password")
          setErrorOwnerPassword(false) 
        }else{
          setValidationOwnerPassword("Wrong password, example: pepito123456")
          setErrorOwnerPassword(true) 
        }
  
      }
  
      const onChangeOwnerNumberHouse = (e) =>{
        setOwnerNumberHouse(e.target.value)
        console.log(ownerPassword)
  
        if(expressions .numberHouse.test(ownerNumberHouse)){
  
          setValidationOwnerNumberHouse("Correct Number House")
          setErrorOwnerNumberHouse(false) 
        }else{
          setValidationOwnerNumberHouse("Wrong Number House example: 72")
          setErrorOwnerNumberHouse(true) 
        }
  
      }


    return(
      
        <Grid>
          <Grid><HeaderAdmin/></Grid>
            <form onSubmit={ handleSubmit } >

                <Box 
                    sx={{
                        width: '40%',
                        height: '100%',
                        marginLeft:'auto',
                        marginRight:'auto',
                        marginTop:'10px',
                        justifyContent: 'center',
                        display: 'flex',
                        alignItems: 'center',
                        flexDirection: 'column',
                        paddingLeft:'20px',
                        paddingRight:'20px',
                        background: '#fff',  
                        borderRadius: '15px',
                        boxShadow: '1px 1px 20px #333',
                        color: grey[900]
                        
                    }}
                >
                    <br/>
                    <h1 align="center" >Create Owner</h1><br/>
                    <div className="row">
                      <div className="col">
                          
                          <TextField fullWidth 
                          id="ownerName" 
                          name="ownerName" 
                          placeholder="Ex:Josue" 
                          label="Name" 
                          sx = {{width: '100%'}}
                          value={ownerName} 
                          error = {errorOwnerName}
                          helperText = {validationOwnerName}
                          onChange={(onChangeOwnerName)}
                          onBlur={(onChangeOwnerName)}
                          />
                      </div>
                    <br/>
                      <div className="col">
                        <TextField fullWidth 
                        id="ownerLastName"  
                        name="ownerLastName"  
                        placeholder="Ex:Moreno" 
                        label="Last Name" 
                        value={ownerLastName} 
                        error = {errorOwnerLastName}
                        helperText = {validationOwnerLastName}
                        onChange={(onChangeOwnerLastName)}
                        onBlur={(onChangeOwnerLastName)}/>
                      </div>

                    </div><br></br>

                    <div className="row">
                      <div className="col">
                        <TextField fullWidth 
                          id="ownerCard" 
                          name="ownerCard"  
                          placeholder="Ex:1719039305" 
                          label="Identification Card" 
                          value={ownerCard} 
                          error = {errorOwnerCard}
                          helperText = {validationOwnerCard}
                          onChange={(onChangeOwnerCard)}
                          onBlur={(onChangeOwnerCard)}
                        />
                      </div>
                        <br/>
                      <div className="col">
                        <TextField fullWidth 
                        id="ownerTelephone" 
                        name="ownerTelephone" 
                        placeholder="Ex:0998060648"  
                        label="Telephone" 
                        value={ownerTelephone} 
                        error = {errorOwnerTelephone}
                        helperText = {validationOwnerTelephone}
                        onChange={(onChangeOwnerTelephone)}
                        onBlur={(onChangeOwnerTelephone)} />
                      </div>
                    </div>
                    <br/>
                    <div className="row">
                      <div className="col">
                        <TextField fullWidth 
                        id="ownerEmail"  
                        name="ownerEmail" 
                        placeholder="Ex:jamoreno@hotmail.com"  
                        label="Email:" value={ownerEmail} 
                        error = {errorOwnerEmail}
                        helperText = {validationOwnerEmail}
                        onChange={(onChangeOwnerEmail)}
                        onBlur={(onChangeOwnerEmail)}/>
                      </div><br/>
                      <div className="col">
                        
                        <TextField fullWidth 
                        id="ownerUserName" 
                        name="ownerUserName" 
                        placeholder="Ex:jamoreno15"  
                        label="Username" 
                        value={ownerUsername} 
                        error = {errorOwnerUsername}
                        helperText = {validationOwnerUsername}
                        onChange={(onChangeOwnerUsername)}
                        onBlur={(onChangeOwnerUsername)} />

                      </div>
                    </div>
                    <br/>

                    <div className="row">
                      <div className="col">
                        <TextField fullWidth 
                        id="ownerPassword" 
                        name="ownerPassword" 
                        placeholder="Ex:12345"  
                        type="password" 
                        label="Password" 
                        value={ownerPassword} 
                        error = {errorOwnerPassword}
                        helperText = {validationOwnerPassword}
                        onChange={(onChangeOwnerPassword)}
                        onBlur={(onChangeOwnerPassword)}/>
                      </div>
                        <br/>
                      <div className="col">
                        <TextField fullWidth 
                        id="ownerNumberHouse" 
                        name="ownerNumberHouse" 
                        placeholder="Ex:72"   
                        label="Number of House" 
                        value={ownerNumberHouse} 
                        error = {errorOwnerNumberHouse}
                        helperText = {validationOwnerNumberHouse}
                        onChange={(onChangeOwnerNumberHouse)}
                        onBlur={(onChangeOwnerNumberHouse)} />
                      </div>
                    </div>
                    <br/>
                    <div className="row justify-content-center">
                      <Button className='btn-back' color='success' variant="contained" 
                          variant="contained"
                          size = "large"
                          type = "submit"
                          sx={{ bgcolor: green[500], height: '50px', width: '110px', color: 'black'}} 
                      >
                          Add Owner
                      </Button>
                      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                      <Button className='btn-back' color= 'error' variant="contained" 
                          variant="contained"
                          size = "large"
                          onClick = {salir}    
                          sx={{ bgcolor: red[500], height: '50px', width: '110px', color: 'black'}} 
                      >
                          Cancel
                      </Button>
                    </div>
                    <br/>
                </Box>
            </form>
            
        </Grid> 
    )
}

export default FormOwner;