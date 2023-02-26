import React, {useEffect,useState} from 'react';
import '../App.css';
import '../index.css';
import {Box,TextField,Button, Grid, MenuItem, Select, FormControl, InputLabel} from "@mui/material"
import HeaderAdmin from './HeaderAdmin';
import { useNavigate } from 'react-router'
import {getOwner} from '../services/ownerAxios'
import axios from 'axios'
import { green, red, grey} from '@mui/material/colors';
import AdapterDateFns from '@mui/lab/AdapterDateFns';
import LocalizationProvider from '@mui/lab/LocalizationProvider';
import MobileDatePicker from '@mui/lab/MobileDatePicker';
import Cookies from 'universal-cookie'

const cookies = new Cookies(); 

const FormPayment = () => {

    const [owners, setOwner] = useState([])
    const [payCode, setpayCode] = React.useState("")
    const [ownerName, setOwnerName] = React.useState("")
    const [ownerCard, setOwnerCard] = React.useState("")
    const [dateaaux, setdateaux] = React.useState(new Date('2022-02-13'))
    const [date, setdate] = React.useState("")
    const [value, setvalue] = React.useState("")
    const navigate = useNavigate()

    const handleSubmit = async (e) => {
        e.preventDefault() //evitar el recargar la pagina
        if(errorPayCode === true || errorOwnerName ===true || errorValue === true ){
            alert("Incorrectly filled fields ")
          }else{
            try {
            const ownerUp =""
            const response = await axios.post("http://localhost:3000/payments",
                {
                    payCode: payCode,
                    ownerName: ownerName,
                    ownerCard: ownerCard,
                    date: date,
                    value: value,
                    payState: "pending"
                }
            ).then(response => {
                alert("Payment Added succesfully")
                navigate({
                    pathname: '/PaymentControllerAdmin',
                })
            })
        } catch (error) {
          console.log(error.message)
          alert("Connection problems.\n"+ error.message)
        }
    }
}
    const salir = () =>{
        navigate({
            pathname: '/PaymentControllerAdmin',
        })
    }

     /*Obtener owners */
     useEffect(() => {
      async function owners() {
          const response = await getOwner()

          if (response.status === 200) {
              setOwner(response.data)
          }
      }

      owners()
      
  }, [])
    
    /*Sesiones*/
    useEffect(() => {
        if (typeof cookies.get('username') === 'undefined' ) {
            window.location.href = "./"
        }
    })

    useEffect(() => {
        if (cookies.get('ownerType') === "owner") {
            window.location.href = "./Home"
        }
    })
    
 /*Validaciones */
 const expressions  = { 
    payCode:  /^\d{1,10}$/, // 7 a 10 numeros.
    name: /^[a-zA-ZÀ-ÿ\s]{1,40}$/, // Letras y espacios, pueden llevar acentos.
    card: /^\d{10}$/, // 10 Digitos
    date:/^([0-2][0-9]|3[0-1])(\/|-)(0[1-9]|1[0-2])\2(\d{4})$/,
    value:  /^\d{1,2000}$/ // 7 a 10 numeros.
  }
    
  const [validationPayCode, setValidationPayCode] = useState("")
  const [errorPayCode, setErrorPayCode] = useState(false)
  const [validationOwnerName, setValidationOwnerName] = useState("")
  const [errorOwnerName, setErrorOwnerName] = useState(false)
  const [validationOwnerCard, setValidationOwnerCard] = useState("")
  const [errorOwnerCard, setErrorOwnerCard] = useState(false)
  const [validationDate, setValidationDate] = useState("")
  const [errorDate, setErrorDate] = useState(false)
  const [validationValue, setValidationValue] = useState("")
  const [errorValue, setErrorValue] = useState(false)
  
  const onChangePayCode = (e) =>{
    setpayCode(e.target.value)

    if(expressions .payCode.test(payCode)){

      setValidationPayCode("Correct Pay Code")
      setErrorPayCode(false) 
    }else{
      setValidationPayCode("Wrong Pay Code, The pay code are only numbers")
      setErrorPayCode(true) 
    }
  }

  const onChangeOwnerCard = (e) =>{

    
    setOwnerCard(e.target.value)

    if(expressions .card.test(ownerCard)){
      
      setValidationOwnerCard("Correct Identification Card")
      setErrorOwnerCard(false) 
    }else{
      setValidationOwnerCard("Wrong Identification Card, Example: 1729033605")
      setErrorOwnerCard(true) 
    }

  }

  const onBlurCard = () => {
    var owner ="";
    for(var i=0; i< owners.length; i++){
      if (owners[i].ownerCard === ownerCard){
        owner = owners[i];
      }
    }
    setOwnerName(owner.ownerName)
  }

  const onChangeDate = (newValue) =>{
    const newData = newValue.getDate()+"-"+(newValue.getMonth()+1)+"-"+newValue.getFullYear();
    const newData1 = newValue.getFullYear()+"-"+(newValue.getMonth()+1)+"-"+newValue.getDate();
    const dateAux = new Date(newData1);
    setdateaux(dateAux);
    setdate(newData);

    /*if(expressions .date.test(date)){

      setValidationDate("Correct Date")
      setErrorDate(false) 
    }else{
      setValidationDate("Wrong Date, Example: 27/05/2017")
      setErrorDate(true) 
    }*/

  }

  const onChangeValue = (e) =>{
    setvalue(e.target.value)
    console.log(value)

    if(expressions .value.test(value)){

      setValidationValue("Correct Value")
      setErrorValue(false) 
    }else{
      setValidationValue("Wrong Value, The value are only numbers")
      setErrorValue(true) 
    }
  }

    return(
       
        <Grid>
          <Grid><HeaderAdmin/></Grid>
        <form onSubmit={ handleSubmit }  >

            <Box 
                sx={{
                    width: '30%',
                    height: '100%',
                    marginLeft:'auto',
                    marginRight:'auto',
                    justifyContent: 'center',
                    display: 'flex',
                    alignItems: 'center',
                    flexDirection: 'column',
                    paddingLeft:'20px',
                    paddingRight:'20px',
                    background: '#fff',  
                    borderRadius: '15px',
                    boxShadow: '1px 1px 20px #333',
                    marginTop:'10px',
                    color: grey[900]
                }}
            >
                <br/>
                <h1 align="center">Add Payment</h1><br/>

                <TextField fullWidth 
                id="paymentPayCode" 
                name="paymentPayCode"  
                placeholder="Ex:1231"  
                label = "Pay Code" 
                value={payCode} 
                error = {errorPayCode}
                helperText = {validationPayCode}
                onChange={(onChangePayCode)}
                onBlur={(onChangePayCode)}
                />
                <br/>
                
                <FormControl fullWidth>
                    <InputLabel id="paymentOwnerCard">Owner Card</InputLabel>
                    <Select
                        fullWidth
                        labelId="paymentOwnerCard"
                        name='paymentOwnerCard'
                        id="paymentOwnerCard"
                        value={ownerCard}
                        onChange={onChangeOwnerCard}
                        onFocus = {onBlurCard}
                        onBlur = {onBlurCard}
                        label="Owner Card"
                    >
                        {
                            owners.map(item => (
                                <MenuItem value={item.ownerCard}>{item.ownerCard}</MenuItem>
                                
                            ))
                        }    
                    </Select>
                </FormControl>
                
                <br/>
                <TextField fullWidth 
                id="paymentOwnerName" 
                name="paymentOwnerName"   
                placeholder="Ex: Usuari" 
                label="Owner Name" 
                value={ownerName}
                error = {errorOwnerName}
                helperText = {validationOwnerName}
                disabled 
                
                />
                <br/>

                <LocalizationProvider dateAdapter={AdapterDateFns} fullWidth >
                  <MobileDatePicker
                    label="Pay Date"
                    inputFormat="yyyy-MM-dd"
                    value={dateaaux}
                    onChange={onChangeDate}
                    renderInput={(params) => <TextField fullWidth {...params} />}
                  />

                </LocalizationProvider>
            
                <br/>
                <TextField fullWidth 
                id="paymentValue"  
                name="paymentValue" 
                placeholder="300"  
                label="Pay value" 
                value={value} 
                error = {errorValue}
                helperText = {validationValue}
                onChange={(onChangeValue)}
                onBlur={(onChangeValue)}
                />
                <br/>

                <div className="row justify-content-center">
                  <Button className='btn-back' color='success' variant="contained" 
                      variant="contained"
                      size = "large"
                      type = "submit"
                      sx={{ bgcolor: green[500], height: '50px', width: '110px', color: 'black'}} 
                  >
                      Add Payment
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

export default FormPayment;