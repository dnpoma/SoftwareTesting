import React, {useEffect, useState} from 'react';
import './Login.css';
import {Grid, Paper, Avatar, TextField, Button} from '@mui/material'
import { useNavigate } from 'react-router'
import HeaderUser from './HeaderUser'
import Cookies from 'universal-cookie'
import axios from 'axios'
import { green, red } from '@mui/material/colors';
import Card from '@mui/material/Card';
import CardContent from '@mui/material/CardContent';
import Typography from '@mui/material/Typography';

const cookies = new Cookies();

const Account = () => {
 
    var nameCookie = "";
    const paperStyle = {padding: 20, heigth: '70vh', width: 350, margin: "20px auto"}
    const [username, setUsername] = useState(cookies.get('username'))
    const navigate = useNavigate()

    if(cookies.get('name')){
        nameCookie = cookies.get('name');
    }
    const handleSubmit = async (e) => {
        e.preventDefault() //evitar el recargar la pagina
        try {
            
            navigate({
                pathname: '/accountUpdate'
            })
        } catch (error) {
          console.log(error.message)
        }
    }

    const cancel =() => {
        navigate({
            pathname: '/Home'
        })
    }

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
    
    
    
    return (
    

      <Grid>
          <Grid><HeaderUser /></Grid> 
          <form onSubmit = {handleSubmit } className ="LogIn-margenT" >
            
            <Card elevation = {10} style = {paperStyle}>
                    <Grid>
                        <center>
                        <h1>My Account</h1>
                        <Avatar>{nameCookie.charAt(0)}</Avatar>
                        </center>
                    </Grid>

                    <CardContent>
                        <Typography 
                            sx={{ mb: 1.5 }} 
                            color="text.secondary"
                        >
                            <br/>
                            <strong>Name: </strong>{cookies.get('name')}
                        </Typography><hr/>
                        
                        <Typography 
                            sx={{ mb: 1.5 }} 
                            color="text.secondary"
                        >
                            <br/>
                            <strong>Last Name: </strong>{cookies.get('lastName')} 
                        </Typography><hr/>

                        <Typography 
                            sx={{ mb: 1.5 }} 
                            color="text.secondary"
                        >
                            <br/>
                            <strong>Username: </strong>{cookies.get('username')} 
                        </Typography><hr/>

                        <Typography 
                            sx={{ mb: 1.5 }} 
                            color="text.secondary"
                        >
                            <br/>
                            <strong>Identification Card: </strong>{cookies.get('cardIdentification')} 
                        </Typography><hr/>

                        <Typography variant="body2">
                            <br/>
                        </Typography>
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
                    </CardContent>
                </Card>  

          </form>

      </Grid>
      
    )
  }
  
  export default Account